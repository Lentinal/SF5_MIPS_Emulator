using System.Windows.Forms.VisualStyles;

namespace MIPS_Emulator_SF
{
    internal class AssemblyDecoder
    {

        private static String[] returnArray = new String[10];
        /* Only way I can think of sending muliple elements I want to send back to form1 without making everything public
            *  returnArray[0] = function opcode
            *  returnArray[1] = source 1
            *  returnArray[2] = source 2/immediate data
            *  returnArray[3] = destination
            *  returnArray[4] = shift
            *  returnArray[5] = R/I/J - Type
            *  returnArray[6] = Label or Comment = 1    Instruction = 0
            *  returnArray[7] = Write data
            *  returnArray[8] = instruction line
            *  returnArray[9] = Console
            */

        /// <summary>
        /// Fetch
        /// Takes line and sends it to decode if it is something to decode
        /// When microstep
        /// </summary>
        /// <param name="instruction"></param>
        /// <returns></returns>
        public static String[] Fetch(string instruction)
        {
            returnArray[8] = instruction;
            if (instruction.StartsWith("#")) //Checks for comment
            {
                returnArray[6] = "1"; //Comment true
                returnArray[9] = "Dectected Comment: " + returnArray[8] + "\r\n";
                return returnArray;
            }

            if (instruction.Contains(':')) //Checks for segment headers
            {
                returnArray[6] = "1"; //Label true
                returnArray[9] = "Dectected Label: " + returnArray[8] + "\r\n";
                return returnArray;
            }

            returnArray[6] = "0";
            returnArray[9] = "Fetched: " + returnArray[8] + "\r\n";
            return returnArray;
        }

        /// <summary>
        /// Decode
        /// Helps me split and read it better prob can fix and force it in the if SADwich
        /// </summary>
        /// <param name="instruction"></param>
        /// <returns></returns>
        public static String[] Decode(string[] instruction)
        {
            redundancy(instruction);
            String lowercase = instruction[8].ToLower();
            String[] temp = lowercase.Split(' '); //Need first part of the instruction
            returnArray[0] = temp[0];

            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i].Contains(",")) {
                    temp[i] = temp[i].TrimEnd(','); //Removes weird characters
                }

            }

            switch (returnArray[0])
            {
                case "add":
                case "addi":
                    returnArray[3] = temp[1];
                    returnArray[1] = temp[2];
                    returnArray[2] = temp[3];
                    returnArray[9] = "Caught at case add/addi: " + returnArray[8] + "\r\n";
                    return returnArray;

                default:
                    returnArray[9] = "Function not implemented/Function incorrect: " + returnArray[8] + "\r\n";
                    return returnArray;

            }

        }

        public static String[] Execute(string[] instruction)
        {
            redundancy(instruction);
            switch (returnArray[0])
            {
                case "add":
                case "addi":
                    returnArray[7] = (Convert.ToInt32(returnArray[1]) + Convert.ToInt32(returnArray[2])).ToString();
                    break;
                default:
                    returnArray[9] = "Error at Execute with instruction: " + returnArray[8];
                    break;
            }

            return returnArray;
        }

        public static String[] MemoryAccess(string[] instruction)
        {
            redundancy(instruction);

            return returnArray;
        }

        public static String[] Writeback(string[] instruction)
        {
            redundancy(instruction);
            return returnArray;
        }

        private static void redundancy(string[] instruction)
            {
            for(int i = 0; i < instruction.Length; i++)
            {
                returnArray[i] = instruction[i];
                
            }
        }



    }
}
