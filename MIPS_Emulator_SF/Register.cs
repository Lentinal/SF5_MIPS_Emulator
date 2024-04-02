using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPS_Emulator_SF
{

    /// <summary>
    /// Prototyping / Brainstorming
    /// 
    /// MAYBE SCRAPPED IN LIEU OF REGULAR BYTE ARRAY -KA
    /// </summary>
    public class Register
    {
        private static byte at;
        private static byte v0;

        public Register()
        {
            //sets registers to zero
            at = 0;
            v0 = 0;
        }

        public static byte Rzero()
            {
            return 0;
            }

        public static byte Rat() 
        {
            return at;
        }

        public static void setAt(byte value)
        {
            at = value;
        }

        public static byte Rv0()
        {
            return v0;
        }

        public static void setV0(byte value)
        {
            v0 = value;
        }

    }
}

