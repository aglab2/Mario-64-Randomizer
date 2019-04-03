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
        public readonly short Rx;
        public readonly short Ry;
        public readonly short Rz;


        public ObjectPosition(ROM rom)
        {
            X = rom.Read16(4);
            Y = rom.Read16(6);
            Z = rom.Read16(8);

            Rx = rom.Read16(10);
            Ry = rom.Read16(12);
            Rz = rom.Read16(14);
        }
    
        public void Write(ROM rom)
        {
            rom.Write16(X, 4);
            rom.Write16(Y, 6);
            rom.Write16(Z, 8);

            rom.Write16(Rx, 10);
            rom.Write16(Ry, 12);
            rom.Write16(Rz, 14);
        }
    }

    public class Object
    {
        public readonly byte act;
        public readonly byte model;
        public readonly int bparams;
        public readonly int behaviour;
        public readonly ObjectPosition pos;
        public readonly int addr;

        public Object(ROM rom, int addr)
        {
            rom.PushOffset(addr);

            pos       = new ObjectPosition(rom);
            act       = rom.Read8(2);
            model     = rom.Read8(3);
            bparams   = rom.Read32(16);
            behaviour = rom.Read32(20);
            this.addr = addr;

            rom.PopOffset();
        }

        public Object(Int32 behaviour, int addr, ROM rom)
        {            
            this.behaviour = behaviour;
            this.addr = addr;
            rom.PushOffset(addr);
            this.pos = new ObjectPosition(rom);
            this.act = rom.Read8(2);
            this.model = rom.Read8(3);
            this.bparams = rom.Read32(16);

            rom.PopOffset();
        }

        public void Write(ROM rom)
        {
            Console.WriteLine("Writing: " + this.behaviour.ToString("X") + " into: " + this.addr.ToString() + ", bParams: " + this.bparams.ToString());

            rom.PushOffset(addr);

            pos.Write(rom);

            rom.Write8(2, act);
            rom.Write8(3, model);
            rom.Write32(16, bparams);
            rom.Write32(20, behaviour);

            rom.PopOffset();
        }
    }
}
