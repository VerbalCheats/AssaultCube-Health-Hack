using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace boredasfuck
{
    /*
        Random AC Health Hack
        I was rlly bored :)    
    */
    internal class Program
    {
        public static int Base = 0x004E4DBC;
        public static int Health = 0xF4;

        static void Main(string[] args)
        {
            VAMemory memory = new VAMemory("ac_client");

            int LocalPlayer = memory.ReadInt32((IntPtr)Base);

            while(true)
            {
                int address = LocalPlayer + Health;
                memory.WriteInt32((IntPtr)address, 69420);

                Thread.Sleep(100);
            }
        }
    }
}
