using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mario64Randomizer.SM64
{
    public class Color
    {
        public readonly int addr;
        public byte[] address;
        public byte value;

        public Color(ROM rom, byte[] addr, byte value)
        {
            rom.PushOffset(addr);            
            this.addr = addr;
            this.value = value;
            rom.PopOffset();
        }        

        public void Write(ROM rom)
        {            
            for(int i = 0; i < address.Length; i+=2)
            {
                rom.PushOffset((address[i] - Convert.ToInt32("8007EC20") + ((int)"2abca4")));
                rom.Write8(value, 8);
                rom.PopOffset();
            }            
        }
    }
}
