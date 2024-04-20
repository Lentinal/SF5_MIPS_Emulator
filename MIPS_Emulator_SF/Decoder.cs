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
        private static String[] returnArray = new String[10];
        /* Only way I can think of sending muliple elements I want to send back to form1 without making everything public
            *  returnArray[0] = function opcode
            *  returnArray[1] = source 1
            *  returnArray[2] = source 2/immediate data
            *  returnArray[3] = destination
            *  returnArray[4] = shift
            *  returnArray[5] = R/I/J - Type
            *  returnArray[6] = unused
            *  returnArray[7] = unused
            *  returnArray[8] = instruction line
            *  returnArray[9] = Console
            */

        /// <summary>
        /// * Splits instruction
        /// </summary>
        /// <param name="instruction"></param>
        public static String[] EncodeType(string instruction)
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
                returnArray[0] = opcode;
                //need to check if its register encoding, immediate encoding, or jump

                switch (opcode)
                {
                    //Register encode
                    case "000000":
                        returnArray[0] = registerDecode(instruction);
                        return returnArray;
                    //break; //breaks "cant be reached" when we are setting the instruction from text box

                    //Jump
                    case "000010"://j       pc += i << 2 
                    case "000011"://jal     #31 = pc; pc += i <<2
                    case "001001"://jalr    $31 = pc; pc = $s
                    case "001000"://jr      pc = $s
                    case "011010"://Trap function prob wont do
                        returnArray[6] = jump(instruction);
                        return returnArray;
                    //break;

                     //Immediate encode
                    default:
                        returnArray[6] = immediateDecode(instruction);
                        return returnArray;
                        //break;

                }


            }catch(Exception e)
            {
                returnArray[9]= "Decoder.Encoder instruction too short or bad code: " + e.Message + "\r\n";
                return returnArray;

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

                returnArray[9] = "Read in raw instruction: " + instruction + "\r\n"; 
                return "this is R-type" + " " + firstRegister + " " + secondRegister + " " + destinationRegister + " " + shiftAmmount + " " + function + "\r\n";
            }
            catch(Exception e)
            {
                returnArray[9] = "registerDecoding Instruction too short or bad code: " + e.Message + "\r\n";
                return "00000000000000000000000000000000";
            }

            
        }

        private static String immediateDecode(string instruction) 
        {
            return "this is I-Type \r\n";
        }

        private static String jump(string instruction)
        {
            return "this is j-type \r\n";
        }


    }
}
