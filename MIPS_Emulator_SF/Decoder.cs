using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPS_Emulator_SF
{
    /**
     * Decodes MIPS instruction set
     * WRITTEN WITHOUT THE MEMORY ADDRESS IN MIND
     */
    public class Decoder
    {
        /**
         * Splits instruction
         */
        public static void Decode(string instruction)
        {
            /** Proof of concept
             * to be decoded
             * 000000 01000 00000 01000 00000 100000
             * ==
             * add $t0, $t0, $zero # sum = 0
            */
            String opcode = instruction.Substring(0,6);
            Form1.textBox2.Text = opcode;
        }


    }
}
