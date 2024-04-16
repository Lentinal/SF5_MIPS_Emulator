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
            try
            {
                String opcode = instruction.Substring(0, 6);
                //need to check if its register encoding, immediate encoding, or jump

                switch (opcode)
                {
                    case "000000":
                        return opcode + " " + registerDecode(instruction);
                    //break; //breaks "cant be reached" when we are setting the instruction from text box

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


            }catch(Exception e)
            {
                Form1.textBox33.Text += "Decoder.Encoder instruction too short or bad code: " + e.Message + "\r\n";
                return "0000000000000000000000000000000";

            }

        }

        private static String registerDecode(string instruction) 
        {
            try
            {
                String firstRegister = instruction.Substring(6, 5);
                String secondRegister = instruction.Substring(11, 5);
                String destinationRegister = instruction.Substring(16, 5);
                String shiftAmmount = instruction.Substring(21, 5);
                String function = instruction.Substring(26, 6);

                return "this is R-type" + " " + firstRegister + " " + secondRegister + " " + destinationRegister + " " + shiftAmmount + " " + function;
            }
            catch(Exception e)
            {
                Form1.textBox33.Text += "registerDecoding Instruction too short or bad code: " + e.Message + "\r\n";
                return "00000000000000000000000000000000";
            }

            
        }

        private static String immediateDecode(string instruction) 
        {
            return "this is I-Type";
        }

        private static String jump(string instruction)
        {
            return "this is j-type";
        }


    }
}
