using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mario64Randomizer.SM64
{
    public class ObjectPosition
    {
        public readonly short X;
        public readonly short Y;
        public readonly short Z;


        public ObjectPosition(ROM rom)
        {
            X = rom.Read16(4);
            Y = rom.Read16(6);
            Z = rom.Read16(8);
        }
    
        public void Write(ROM rom)
        {
            rom.Write16(X, 4);
            rom.Write16(Y, 6);
            rom.Write16(Z, 8);
        }
    }

    public class ObjectRotation
    {
        public readonly short Rx;
        public readonly short Ry;
        public readonly short Rz;


        public ObjectRotation(ROM rom)
        {
            Rx = rom.Read16(10);
            Ry = rom.Read16(12);
            Rz = rom.Read16(14);
        }

        public void Write(ROM rom)
        {
            rom.Write16(Rx, 10);
            rom.Write16(Ry, 12);
            rom.Write16(Rz, 14);
        }
    }



    public class Object
    {
        public readonly byte area;
        public readonly byte act;
        public readonly byte model;
        public readonly int bparams;
        public readonly int behaviour;
        public readonly ObjectPosition position;
        public readonly ObjectRotation rotation;
        public readonly int addr;
        public readonly int level;

        public byte BParam1 { get { return (byte)((bparams & 0xFF000000) >> 24); } }
        public byte BParam2 { get { return (byte)((bparams & 0x00FF0000) >> 16); } }

        public Object(byte area, int level, ROM rom, int addr)
        {
            this.area = area;
            this.level = level;

            rom.PushOffset(addr);

            position  = new ObjectPosition(rom);
            rotation  = new ObjectRotation(rom);
            act       = rom.Read8(2);
            model     = rom.Read8(3);
            bparams   = rom.Read32(16);
            behaviour = rom.Read32(20);
            this.addr = addr;

            rom.PopOffset();
        }

        public Object(byte area, int level, byte act, byte model, int bparams, int behaviour, ObjectPosition position, ObjectRotation rotation, int addr)
        {
            this.area = area;
            this.level = level;
            this.behaviour = behaviour;
            this.addr = addr;
            this.position = position;
            this.rotation = rotation;
            this.act = act;
            this.model = model;
            this.bparams = bparams;
        }

        public void Write(ROM rom)
        {
            rom.PushOffset(addr);

            position.Write(rom);
            rotation.Write(rom);
            rom.Write8(act, 2);
            rom.Write8(model, 3);
            rom.Write32(bparams, 16);
            rom.Write32(behaviour, 20);

            rom.PopOffset();
        }
    }
}
