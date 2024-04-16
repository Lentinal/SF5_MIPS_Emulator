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
        public static String EncodeType(string instruction)
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

            switch(opcode)
            {
                case "000000":
                    return opcode+ " " + registerDecode(instruction);
                    //break;

                case "000010":
                case "000011":
                case "001001":
                case "001000":
                    return opcode + " " + jump(instruction);
                    //break;

                default:
                    return opcode + " " + immediateDecode(instruction);
                    //break;

            }


            //Testing to display to the textbox forms

        }

        private static String registerDecode(string instruction) 
        {
            return "this is R-type";
        }

        private static String immediateDecode(string instruction) 
        {
            return "this is I-Type";
        }

        private static String jump(string instruction)
        {
            return "this si j-type";
        }


    }
}
