using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPS_Emulator_SF
{
    /// <summary>
    /// Decodes MIPS instruction set
    /// WRITTEN WITHOUT THE MEMORY ADDRESS IN MIND
    /// </summary>
    public class Decoder
    {
        /// <summary>
        /// * Splits instruction
        /// </summary>
        /// <param name="instruction"></param>
        public static void EncodeType(string instruction)
        {
            /* Proof of concept
             * to be decoded
             * 000000 01000 00000 01000 00000 100000
             * ==
             * add $t0, $t0, $zero # sum = 0 
             * 
             */
            String opcode = instruction.Substring(0,6);
            //need to check if its register encoding, immediate encoding, or jump

            //Testing to display to the textbox forms
            Form1.textBox2.Text = opcode;
            Form1.textBox3.Text = instruction;
        }

        public static void RegisterDecode() 
        { 
        
        }

        public static void ImmediateDecode() 
        { 

        }

        public static void Jump()
        {

        }


    }
}
