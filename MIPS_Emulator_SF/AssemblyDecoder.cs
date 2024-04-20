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

        private static String[] returnArray = new String[11];
        /* Only way I can think of sending muliple elements I want to send back to form1 without making everything public
            *  returnArray[0] = function opcode
            *  returnArray[1] = source 1
            *  returnArray[2] = source 2/immediate data
            *  returnArray[3] = destination
            *  returnArray[4] = shift
            *  returnArray[5] = R/I/J - Type
            *  returnArray[6] = if header = 1
            *  returnArray[7] = if comment = 1
            *  returnArray[8] = instruction line
            *  returnArray[9] = Console
            *  returnArray[10] = Memory Location
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
                }else //Label read
                {
                    returnArray[6] = "1"; //Label true
                    returnArray[9] = "Read label: " + instruction + "\r\n";
                    return returnArray;
                }

            }else //Comment read
            {
                returnArray[7] = "1"; //Comment true
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
                    returnArray[3] = temp[1].Remove(temp[1].Length-1); //Removes the , at the end of the string for desintation
                    returnArray[1] = temp[2].Remove(temp[2].Length-1); //Removes the , at the end of the string for source 1
                    returnArray[2] = temp[3];//source 2 or immediate data
                    returnArray[9] = "Caught at case add/addi: " + instruction + "\r\n";
                    return returnArray;

                default:
                    returnArray[9] = "Function not implemented/Function incorrect: " + instruction + "\r\n";
                    return returnArray;

            }

        }
    }
}
 