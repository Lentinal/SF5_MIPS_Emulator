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
        private static readonly string[] RegisterNames = {
        "$zero", "$at", "$v0", "$v1", "$a0", "$a1", "$a2", "$a3",
        "$t0", "$t1", "$t2", "$t3", "$t4", "$t5", "$t6", "$t7",
        "$s0", "$s1", "$s2", "$s3", "$s4", "$s5", "$s6", "$s7",
        "$t8", "$t9", "$k0", "$k1", "$gp", "$sp", "$fp", "$ra"
        };
        /// <summary>
        /// * Splits instruction
        /// </summary>
        /// <param name="instruction"></param>
        public static void EncodeType(string[] instruction)
        {

            /* Proof of concept
             * to be decoded
             * 000000 01000 00000 01000 00000 100000
             * ==
             * add $t0, $t0, $zero # sum = 0 
             * 
             */
            Form1 form1 = new button1_Click_1(); //Identifier not being recognized
            instruction[] = form1.fileContents;
            string mipsType;
            string rType;
            string iType;
            string jType;
            foreach (string mipsLine in instruction) {
                String opcode = instruction.Substring(10, 15);
                switch (opcode) {
                    case "000000": mipsType = rType;
                        break;
                    case "001001":
                    case "001010":
                    case "001011":
                    case "001100":
                    case "001101":
                    case "001110":
                    case "001111": mipsType = iType;
                        break;
                    case "000010":
                    case "000011":
                    case "000100":
                    case "000101":
                    case "000110":
                    case "000111":
                    case "000001":
                    case "000001": mipsType = jType;
                        break;
                    default:
                        throw new InvalidOperationException("Unsupported MIPS instruction.");
                        break;

                }
                //need to check if its register encoding, immediate encoding, or jump

                //Testing to display to the textbox forms
                //Form1.textBox2.Text = opcode;
                //Form1.textBox3.Text = instruction;
            }

            static void RegisterDecode(string instruction)
            {
                string rstemp = instruction.Substring(16, 20);
                string rttemp = instruction.Substring(21, 25);
                string rdtemp = instruction.Substring(26, 30);
                string shampttemp = instruction.Substring(31, 35);
                string functemp = instruction.Substring(36, 41);
                string rs = RegisterNames[Convert.ToInt32(rstemp, 2)];
                string rt = RegisterNames[Convert.ToInt32(rttemp, 2)];
                string rd = RegisterNames[Convert.ToInt32(rdtemp, 2)];
                string shampt = RegisterNames[Convert.ToInt32(shampttemp, 2)];
                string func;
                switch (functemp) {
                    case 100000:
                        func = "add";
                        break;
                    case 100010:
                        func = "sub";
                        break;
                    case 011000:
                        func = "mult";
                        break;
                    case 011010:
                        func = "div";
                        break;
                    case 100100:
                        func = "and";
                        break;
                    case 100101:
                        func = "or";
                        break;
                    case 100111:
                        func = "nor"; // Could not find a "not" function
                        break;
                    case 100110:
                        func = "xor";
                        break;
                    default:
                        throw new InvalidOperationException("Unsupported MIPS Function");
                        break;
                }
                string decoded = func + " " + rd + ", " + rs + ", " + rt;
                return decoded;
            }

            static void ImmediateDecode()
            {

            }

            static void Jump()
            {

            }


        }
    }
}
