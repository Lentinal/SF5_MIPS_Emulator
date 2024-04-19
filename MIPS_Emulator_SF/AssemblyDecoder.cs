using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPS_Emulator_SF
{
    internal class AssemblyDecoder
    {

        private static String[] returnArray = new String[10];
        /* Only way I can think of sending muliple elements I want to send back to form1 without making everything public
            *  returnArray[0] = function opcode
            *  returnArray[1] = source 1
            *  returnArray[2] = source 2
            *  returnArray[3] = destination
            *  returnArray[4] = shift
            *  returnArray[5] = immediate data
            *  returnArray[6] = # - Type
            *  returnArray[7] = unused
            *  returnArray[8] = instruction line
            *  returnArray[9] = Console
            */
        //Takes line and sends it to decode if it is something to decode
        public static String[] Fetch(string instruction) 
        {
            returnArray[8] = instruction;
           

            if (!instruction.StartsWith("#")) //Checks for comment
            {
                if (!instruction.Contains(':')) //Checks for segment headers
                {
                    Decoder(instruction);//Helps me read this mess better  
                    return returnArray;
                }else //Header read
                {
                    returnArray[9] = "Read header: " + instruction+ "\r\n";
                    return returnArray;
                }

            }else //Comment read
            {
                returnArray[9] = "Read Comment: " + instruction + "\r\n";
                return returnArray;
            }
        }


        //Helps me split and read it better prob can fix and force it in the if SADwich
        private static String[] Decoder(string instruction)
        {
            String lowercase = instruction.ToLower();
            String[] temp = lowercase.Split(' '); //Need first part of the instruction
            returnArray[0] = temp[0];

            switch (returnArray[0])
            {
                case "add":
                case "addi":
                    returnArray[1] = temp[1].Remove(temp.Length); //Removes the , at the end of the string
                    returnArray[2] = temp[2].Remove(temp.Length); //Removes the , at the end of the string
                    returnArray[9] = "Caught at case add/addi: " + instruction + "\r\n";
                    return returnArray;

                default:
                    returnArray[9] = "Function not implemented/Function incorrect: " + instruction + "\r\n";
                    return returnArray;

            }

        }
    }
}
