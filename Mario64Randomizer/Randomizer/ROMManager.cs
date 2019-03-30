using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Mario64Randomizer
{
    class ROMManager : IDisposable
    {
        BinaryReader reader;
        BinaryWriter writer;

        public readonly Dictionary<int, string> behavioursDescription;

        static int[] courseForOffset = { 0x10, 0x0F, 0x08, 0x11, 0x13, 0x0C, 0x15, 0x16,
                0x0E, 0x18, 0x19, 0x1A, 0x08, 0x1B, 0x21, 0x1C, 0x23, 0x1D, 0x12,
                0x14, 0x0D, 0x24, 0x08, 0x1E, 0x1F, 0x20, -1, 0x22, -1, -1, 0x17 };

        static string[] nameForOffset = { "C05", "C04", "Inside", "C06", "C08", "C01", "C10", "C11", "C03", "C13",
                                          "C14", "C15", "Grounds", "B1", "VC", "B2", "Aquarium", "B3", "C07",
                                          "C09", "C02", "The End", "Courty", "Slide", "MC", "WC", "B1f",
                                          "Clouds", "B2f", "B3f", "C12"  };

        static int courseBaseAddress = 0x02AC094;
        static byte objectDescriptor = 0x24;
        static int boxParamDescriptorsAddress = 0x01204000;
        static byte maxBehaviour = 0x63;

        static byte[] collectStarBehaviour = { 0x13, 0x00, 0x3E, 0x3C };
        static byte[] redCoinStarBehaviour = { 0x13, 0x00, 0x3E, 0x8C };
        static byte[] hiddenStarBehaviour = { 0x13, 0x00, 0x3E, 0xFC };

        static byte[] boxBehaviour = { 0x13, 0x00, 0x22, 0x50 };
        static byte[] checkpointBehaviour = { 0x13, 0x00, 0x3F, 0x1C };

        static byte[] rotation = { 0x00, 0x00, 0x00, 0x00, 0x00, 0xB4 };

        static byte[] secretReplaceObject = { 0xA7 }; //Splash

        public ROMManager(string fileName, string behaviourListFileName)
        {
            var a = File.Open(fileName, FileMode.Open);
            reader = new BinaryReader(a);
            writer = new BinaryWriter(a);

            //behavioursDescription = BehaviourManager.Parse(behaviourListFileName);
        }
        public void Dispose()
        {
            reader.Dispose();
            writer.Dispose();
        }

        private int ReadInt32()
        {
            byte[] a32 = reader.ReadBytes(4);
            Array.Reverse(a32);
            return BitConverter.ToInt32(a32, 0);
        }

        private int ReadInt32(int offset)
        {
            reader.BaseStream.Position = offset;
            byte[] a32 = reader.ReadBytes(4);
            Array.Reverse(a32);
            return BitConverter.ToInt32(a32, 0);
        }

        private byte ReadByte()
        {
            return reader.ReadByte();
        }

        private byte ReadByte(int offset)
        {
            reader.BaseStream.Position = offset;
            return reader.ReadByte();
        }

        private byte[] ReadBehaviour(int offset)
        {
            reader.BaseStream.Position = offset + 0x14;
            return reader.ReadBytes(4);
        }

        private byte ReadBParam1(int offset)
        {
            reader.BaseStream.Position = offset + 0x10;
            return reader.ReadByte();
        }

        private byte ReadBParam2(int offset)
        {
            reader.BaseStream.Position = offset + 0x11;
            return reader.ReadByte();
        }

        private byte ReadObjectID(int offset)
        {
            reader.BaseStream.Position = offset + 0x03;
            return reader.ReadByte();
        }

        private void WriteRotation(int offset, byte[] rotation)
        {
            writer.BaseStream.Position = offset + 0x0A;
            writer.Write(rotation);
        }

        private void WriteObjectID(int offset, byte[] objectID)
        {
            reader.BaseStream.Position = offset + 0x03;
            writer.Write(objectID);
        }

        private byte[] ReadDestination(int offset)
        {
            reader.BaseStream.Position = offset + 0x03;
            return reader.ReadBytes(3);
        }

        private void WriteDestination(int offset, byte[] data)
        {
            writer.BaseStream.Position = offset + 0x03;
            writer.Write(data, 0, 3);
        }

        private byte ReadWarpID(int offset)
        {
            reader.BaseStream.Position = offset + 0x02;
            return reader.ReadByte();
        }

        public Object[] ReadBoxBehaviours()
        {
            Object[] ret = new Object[maxBehaviour];
            reader.BaseStream.Position = boxParamDescriptorsAddress;
            while (true)
            {
                byte[] data = reader.ReadBytes(8);
                if (data[0] == maxBehaviour) return ret;
                //Object obj = new Object(data[1], data[2], data[3], IPAddress.HostToNetworkOrder(BitConverter.ToInt32(data, 4)));
                //ret[data[0]] = obj;
            }
        }

        public void DetrollLevels(ISet<int> trollObjects, bool isRevertingStars, bool isShowingSecrets)
        {
            for (int index = 0; index < courseForOffset.Length; index++)
            {
                int levelAddressStart = ReadInt32(courseBaseAddress + index * 0x14 + 0x04); //base offset + offset for descriptor + address in descriptor
                int levelAddressEnd = ReadInt32();

                Console.Write(String.Format("{0} is address {1:x} -> {2:x} - {3:x}\n", nameForOffset[index], reader.BaseStream.Position - 0x08, levelAddressStart, levelAddressEnd));
                DetrollData(levelAddressStart, levelAddressEnd, trollObjects, isRevertingStars, isShowingSecrets);
            }
        }

        private void Detroll(int offset)
        {
            WriteRotation(offset, rotation);
        }

        private void DetrollData(int start, int end, ISet<int> trollObjects, bool isRevertingStars, bool isShowingSecrets)
        {
            for (int offset = start; offset < end; offset++)
            {
                reader.BaseStream.Position = offset;
                if (reader.ReadByte() != objectDescriptor) continue; //work with 3D object only
                byte[] behaviour = ReadBehaviour(offset);
                if (behaviour.SequenceEqual(collectStarBehaviour) ||
                    behaviour.SequenceEqual(redCoinStarBehaviour) ||
                    behaviour.SequenceEqual(hiddenStarBehaviour))
                {
                    byte starByte = ReadBParam1(offset);
                    if (isRevertingStars && starByte > 0x06)
                    {
                        Console.Write(String.Format("[TrollStar] '{0:x}' Star {1} detected!\n", offset, starByte));
                        Detroll(offset);
                    }
                }

                if (behaviour.SequenceEqual(boxBehaviour))
                {
                    byte starByte = ReadBParam2(offset);

                    if (trollObjects.Contains(starByte))  //not a star
                    {
                        Console.Write(String.Format("[Weird Box] '{0:x}' WObj {1} detected!\n", offset, starByte));
                        Detroll(offset);
                    }
                    if (starByte == 0x8) //star for random shit
                    {
                        byte starByteParam = ReadBParam1(offset);
                        if (isRevertingStars && starByteParam > 0x06)
                        {
                            Console.Write(String.Format("[Troll Box] '{0:x}' Star {1} detected!\n", offset, starByte));
                            Detroll(offset);
                        }
                    }
                }

                if (behaviour.SequenceEqual(checkpointBehaviour))
                {
                    byte objectID = ReadObjectID(offset);
                    if (isShowingSecrets && objectID == 0)
                    {
                        Console.Write(String.Format("[InvSecret] '{0:x}' Invisible secret detected!\n", offset));
                        WriteObjectID(offset, secretReplaceObject);
                    }
                }
            }
        }

        public List<byte[]> getDestinations()
        {
            List<byte[]> warps = new List<byte[]>();
            for (int index = 0; index < courseForOffset.Length; index++)
            {
                int levelAddressStart = ReadInt32(courseBaseAddress + index * 0x14 + 0x04); //base offset + offset for descriptor + address in descriptor
                int levelAddressEnd = ReadInt32();

                Console.Write(String.Format("{0} is address {1:x} -> {2:x} - {3:x}\n", nameForOffset[index], reader.BaseStream.Position - 0x08, levelAddressStart, levelAddressEnd));
                List<byte[]> curwarps = GetWarpsDestinations(levelAddressStart, levelAddressEnd);
                Console.WriteLine(curwarps.Count);
                warps.AddRange(curwarps);
            }
            return warps;
        }

        private List<byte[]> GetWarpsDestinations(int start, int end)
        {
            List<byte[]> warps = new List<byte[]>();
            try
            {
                reader.BaseStream.Position = start;
                int offset = start;
                if (reader.ReadByte() == 0x80) offset += 0x1C;
                while (offset < end)
                {
                    reader.BaseStream.Position = offset;

                    byte command = reader.ReadByte();
                    int length = reader.ReadByte();
                    if (length == 0) return warps;

                    if (command == 0x26 || command == 0x27)
                    {
                        Console.WriteLine(ReadWarpID(offset));
                        if (ReadWarpID(offset) < 0xF0 )
                            warps.Add(ReadDestination(offset));
                    }

                    offset += length;
                }
            }
            catch (IOException) { }
            return warps;
        }

        public void writeDestinations(List<byte[]> warps)
        {
            int curWarp = 0;
            for (int index = 0; index < courseForOffset.Length; index++)
            {
                int levelAddressStart = ReadInt32(courseBaseAddress + index * 0x14 + 0x04); //base offset + offset for descriptor + address in descriptor
                int levelAddressEnd = ReadInt32();

                Console.Write(String.Format("{0} is address {1:x} -> {2:x} - {3:x}\n", nameForOffset[index], reader.BaseStream.Position - 0x08, levelAddressStart, levelAddressEnd));
                curWarp = WriteWarpsDestinations(levelAddressStart, levelAddressEnd, warps, curWarp);
            }
        }

        private int WriteWarpsDestinations(int start, int end, List<byte[]> warps, int warpStart)
        {
            int curWarp = warpStart;
            try
            {
                reader.BaseStream.Position = start;
                int offset = start;
                if (reader.ReadByte() == 0x80) offset += 0x1C;
                while (offset < end)
                {
                    reader.BaseStream.Position = offset;

                    byte command = reader.ReadByte();
                    int length = reader.ReadByte();
                    if (length == 0) return curWarp;

                    if (command == 0x26 || command == 0x27)
                    {
                        if (ReadWarpID(offset) < 0xF0)
                        {
                            WriteDestination(offset, warps[curWarp]);
                            curWarp++;
                        }
                    }

                    offset += length;
                }
            }
            catch (IOException) { }
            return curWarp;
        }

        public void randomizeMusic()
        {
            //List<byte[]> songList = new List<byte[]>();
            for (int index = 0; index < courseForOffset.Length; index++)
            {
                int levelAddressStart = ReadInt32(courseBaseAddress + index * 0x14 + 0x04); //base offset + offset for descriptor + address in descriptor
                int levelAddressEnd = ReadInt32();

                //Console.Write(String.Format("{0} is address {1:x} -> {2:x} - {3:x}\n", nameForOffset[index], reader.BaseStream.Position - 0x08, levelAddressStart, levelAddressEnd));

                setSong(levelAddressStart, levelAddressEnd);

                //Regex.IsMatch(input, ".NET");
            }
        }

        private void setSong(int start, int end)
        {
            //byte song = new byte();
            try
            {
                reader.BaseStream.Position = start;
                int offset = start;
                //if (reader.ReadByte() == 0x80) offset += 0x1C;
                /*while (offset < end)
                {*/
                    reader.BaseStream.Position = offset;
                    
                    byte command = reader.ReadByte();
                    int length = reader.ReadByte();
                    //if (length == 0) return warps;

                    string sPattern = "36 08 .. .. .. .. 00 00";

                    if (Regex.IsMatch((reader.Read()).ToString(), sPattern))
                    {
                        Console.WriteLine("ok");
                    }

                    //offset += length;
                //}
            }
            catch (IOException) { }
        }

        private int WriteNewSong(int start, int end, List<byte[]> warps, int warpStart)
        {
            int curWarp = warpStart;
            try
            {
                reader.BaseStream.Position = start;
                int offset = start;
                if (reader.ReadByte() == 0x80) offset += 0x1C;
                while (offset < end)
                {
                    reader.BaseStream.Position = offset;

                    byte command = reader.ReadByte();
                    int length = reader.ReadByte();
                    if (length == 0) return curWarp;

                    if (command == 0x26 || command == 0x27)
                    {
                        if (ReadWarpID(offset) != 0xF0)
                        {
                            WriteDestination(offset, warps[curWarp]);
                            curWarp++;
                        }
                    }

                    offset += length;
                }
            }
            catch (IOException) { }
            return curWarp;
        }

        private void warpLogic()
        {

        }
    }
}
