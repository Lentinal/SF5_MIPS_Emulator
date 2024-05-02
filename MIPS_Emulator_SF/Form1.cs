using System.Collections;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace MIPS_Emulator_SF
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Global Variables
        /// </summary>
        private static List<OpcodeObject> list = new List<OpcodeObject>();
        private static int intPC = 0; //For holding PC
        private static int intMem = 0;
        private static int intCache = 0; //For cache
        private static int stepCount = 0; //For microstep
        private static List<string> cache = new List<string>();


        private static bool toggle = false; //for run

        //House keeping and initalizations
        /// <summary>
        /// Form1 
        /// Initalize and sets register textboxes
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            foreach (Control control in registerPanel.Controls)
            {
                if (control is TextBox text && text.Name.StartsWith("textBox"))
                {
                    text.Text = "00000000000000000000000000000000";
                }
            }


        }

        /// <summary> FINISHED/UNUSED
        /// Form1_Load
        /// Whenever the form loads in runs below
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //Delanie was here 
            //Kian moved the msg above to be in the method
        }
        

        //Radio Buttons
        /// <summary> CHECK
        /// radioBinary_CheckedChanged
        /// BinaryRadio
        /// CHECK: On back burner; Maybe scrapped
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioBinary_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control control in registerPanel.Controls)
            {
                if (control is TextBox text && text.Name.StartsWith("textBox"))
                {
                    int getText = int.Parse(text.Text);
                    String getBinary = convertToBinary(getText);
                    Debug.WriteLine(getBinary);
                    text.Text = getBinary;
                }
            }
        }

        /// <summary> CHECK
        /// radioDecimal_CheckChanged
        /// CHECK: On back burner; Maybe scrapped
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioDecimal_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control control in registerPanel.Controls)
            {
                if (control is TextBox text && text.Name.StartsWith("textBox"))
                {
                    int getDecimal = signedBinaryToDecimal(text.Text);
                    text.Text = getDecimal.ToString();
                }
            }
        }


        //Buttons
        /// <summary> CHECK
        /// stepButtonClick
        /// Advances by one instruction
        /// CHECK: Unfinished primary focus
        /// Need to figure out how we want to step
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stepButtonClick(object sender, EventArgs e)
        {
            try
            {
                OpcodeObject temp = list[intPC]; //Gets next instruction inline
                console.AppendText("\r\n" + "Retrieved line: " + temp.toString() + "\r\n");

                switch (temp.getMisc())
                {
                    //Label
                    case 0:
                        //Failsafe will most likely never go here
                        advancePC();
                        break;

                    //R-Type instruction FINISHED
                    case 1:
                        console.AppendText("Fetching registers for R-Type \r\n");
                        Control source1 = getRegisterTextBox(temp.getSource1()); //Retrieves register1 textbox
                        Control source2 = getRegisterTextBox(temp.getSource2()); //Retrieves register2 textbox
                        String source1Int = source1.Text; //Retrieves register1 contents
                        String source2Int = source2.Text; //Retrieves register2 contents

                        console.AppendText("Decoding R-type instruction \r\n");
                        int write = executeR(temp.getOpcode(), source1Int, source2Int); //Calls executeR to calculate result

                        console.AppendText("Accessing destination register \r\n");
                        Control destin = getRegisterTextBox(temp.getDestination()); //Retrieves destination register

                        console.AppendText("Writing back to " + temp.getDestination() + "\r\n");
                        destin.Text = convertToBinary(write); //Writes to destination register
                        destin.Update(); //For realtime textbox updates

                        advancePC();
                        break;

                    //J-Type instruction FINISHED
                    case 2:
                        console.AppendText("Fetched J-Type \r\n");

                        console.AppendText("Decoding J-Type instruction \r\n");
                        write = executeJ(temp.getOpcode(), temp.getDestination());//Calls executeJ for new intPC

                        console.AppendText("Accessing jump location \r\n");

                        console.AppendText("Setting PC \r\n");
                        intPC = write;//Sets PC
                        break;

                    //I-Type instruction FINISHED
                    case 3:
                        console.AppendText("Fetching registers for I-Type \r\n");
                        source1 = getRegisterTextBox(temp.getSource1()); //Retrieves register location
                        source1Int = source1.Text; //Retrieves binary string from textbox

                        console.AppendText("Decoding I-type instruction \r\n");
                        source2Int = temp.getSource2(); //Retrieves int value from object

                        write = executeI(temp.getOpcode(), source1Int, source2Int); //Calls executeI to calculate 

                        console.AppendText("Accessing destination register \r\n");
                        destin = getRegisterTextBox(temp.getDestination()); //Retrieves destination register

                        console.AppendText("Writing back to " + temp.getDestination() + "\r\n");
                        destin.Text = convertToBinary(write); //Writes to destination register
                        destin.Update(); //For realtime textbox updating

                        advancePC();
                        break;

                    //li la sw sa instruction Data transfer
                    case 4:
                        console.AppendText("Detected data transfer instruction \r\n");

                        console.AppendText("Decoding data transfer instruction \r\n");
                        String source1Text = temp.getSource1();//Retrieves immediate or the address in register

                        write = executeData(temp.getOpcode(), source1Text);

                        //Checks to see if it was a move instruction move already sets the below 
                        if (!temp.getOpcode().Equals("move"))
                        {
                            console.AppendText("Accessing destination register \r\n");
                            destin = getRegisterTextBox(temp.getDestination()); //Retrieves destination register

                            console.AppendText("Writing back to " + temp.getDestination() + "\r\n");
                            destin.Text = convertToBinary(write); //Writes to destination register
                            destin.Update(); //For real time textbox updates
                        }

                        advancePC();
                        break;

                    //Branch instruction
                    case 5:
                        console.AppendText("Fetched branch \r\n");

                        console.AppendText("Decoding branch instruction \r\n");
                        source1 = getRegisterTextBox(temp.getDestination());
                        source1Int = source1.Text;
                        source2 = getRegisterTextBox(temp.getSource1());
                        source2Int = source2.Text;

                        console.AppendText("Executing branch instruction \r\n");
                        write = executeBranch(temp.getOpcode(), source1Int, source2Int);

                        if (write == 1)
                        {
                            console.AppendText("Accessing jump location \r\n");
                            foreach (OpcodeObject ex in list)
                            {
                                if (ex.getOpcode().Contains(temp.getSource2()))
                                {
                                    intPC = ex.getLocation();
                                    console.AppendText("Setting PC \r\n");
                                }

                            }
                        }
                        else
                        {
                            console.AppendText("Branch is false \r\n");
                        }

                        advancePC();
                        break;

                    //Not sure?? its .data .text .globl main marker idk what to do with this UNIMPLEMENTED
                    case 6:
                        advancePC();
                        break;

                    //Syscall PARTIAL
                    case 7:
                        console.AppendText("Detected a Syscall \r\n");
                        int systemCall = Convert.ToInt32(textBox2.Text, 2);//turns $v0 to decimal
                        executeSyscall(systemCall);
                        advancePC();
                        break;

                    //Defaulted
                    default:
                        console.AppendText("Defaulted on Form1.stepButton: " + temp.ToString() + "\r\n");
                        advancePC();
                        break;
                }

                /*
                 * Cache update? *shrugs* Prototype
                 * TEMPORORY PLEASE CHECK 
                 */
                if (temp.getMisc() >= 1 && temp.getMisc() < 6)
                {
                    if (intCache < 5) //Check if there  < 5 instructions in cache
                    {
                        if (!cacheTextBox.Text.Contains(temp.toString()))
                        {
                            cache.Add(temp.toString());
                            cacheTextBox.Clear();
                            foreach (string instruction in cache)
                            {
                                cacheTextBox.AppendText(instruction + "\r\n");
                            }
                            //cacheTextBox.AppendText(intCache + "\t" + cache[intCache] + "\r\n");
                            intCache++;
                        }
                    }

                    else if (intCache >= 5) //if there are 5 instructions in cache...
                    {
                        
                        if (!cacheTextBox.Text.Contains(temp.toString())) //if the cache box doesn't contain the current instruction...
                        {
                            cache.RemoveAt(0);
                            cache.Add(temp.toString());
                            cacheTextBox.Clear();
                            foreach(string instruction in cache)
                            {
                                cacheTextBox.AppendText(instruction + "\r\n");
                            }
                            intCache++;
                        }
                    }
                    

                    
                    
                }

            }
            catch (Exception ex)
            {
                console.AppendText("Encountered error: " + ex.Message + "\r\n");
            }
        }

        /// <summary> UNIMPLEMENTED
        /// microStepButton
        /// Takes one line and goes thru each part of the pipeline
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void microButton_Click(Object sender, EventArgs e)
        {
            console.AppendText("test");
        }

        /// <summary> FINISHED
        /// clearConsole_Click
        /// Clears console text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearConsole_Click(object sender, EventArgs e)
        {
            console.Text = "";
        }

        /// <summary> FINISHED
        /// clearButton_Click
        /// Calls clear()
        /// </summary>
        private void clearButton_Click(object sender, EventArgs e)
        {
            clear();
            console.Text = "CLEARED\r\n";
        }

        /// <summary> FINISHED
        /// pcButton_Click
        /// Sets PC value to what is in the setPCTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pcButton_Click(object sender, EventArgs e)
        {
            PC.Text = convertToBinary(int.Parse(setPCTextBox.Text));
            intPC = int.Parse(setPCTextBox.Text);
            console.AppendText("Set PC to : " + intPC + "\r\n");
        }

        /// <summary> UNIMPLEMENTED POSSIBLE SCRAP
        /// runButton_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void runButton_Click(object sender, EventArgs e)
        {
            toggle = !toggle;
            running(sender, e);
        }

        private async void running(object sender, EventArgs e)
        {
            while (toggle && intPC < list.Count && (!list[intPC].getOpcode().Equals("syscall")))
            {
                stepButtonClick(sender, e);
                await Task.Delay(5);
            }
            toggle = false;
        }

        /// <summary> UNIMPLEMENTED
        /// saveButton_Click
        /// Saves current register values into a .txt file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveButton_Click(object sender, EventArgs e)
        {

            foreach (Control control in registerPanel.Controls)
            {
                if (control is TextBox text && text.Name.StartsWith("textBox"))
                {

                }
            }
        }
        

        //File handler
        /// <summary> CHECK
        /// fileButton_Click
        /// Opens a dialog to select file
        /// Splits the contents into an array for decoding and execution
        /// CHECK: Needs a clearing from delanie and possible change needed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|Assembly (*.asm)|*.asm|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Read the contents of the file
                        clear(); //Insures no "corruption"
                        string filePath = openFileDialog.FileName;
                        string fileContents = File.ReadAllText(filePath);
                        char[] charsToTrimEnd = { ' ', '#', '\n', '\r', '\t' };
                        char[] charsToTrimStart = { ' ', '\t', };
                        String[] instructions = fileContents.Split("\n");

                        for (int i = 0; i < instructions.Length; i++)
                        {
                            if (instructions[i].Length > 1 && !instructions[i].StartsWith("#"))
                            {
                                string commentcut = instructions[i];
                                if (instructions[i].Contains('#'))
                                {
                                    commentcut = (instructions[i].Substring(0, instructions[i].LastIndexOf("#") + 1)).ToLower();
                                }
                                commentcut = commentcut.TrimStart(charsToTrimStart);
                                commentcut = commentcut.TrimEnd(charsToTrimEnd);
                                FileHandler(commentcut);

                            }
                        }

                        intPC = 0; //Resets counter
                        console.AppendText("Loaded in: " + filePath + "\r\n");
                        //Debugging 
                        //console.Text += string.Join(" | ", instructionsArray) + "\r\n"; 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error reading the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary> CHECK
        /// FileHandler
        /// For file button legibility 
        /// CHECK: Need clearing and review
        /// </summary>
        /// <param name="instruction"></param>
        private void FileHandler(string instruction)
        {
            String[] temp = instruction.Split(" ");
            //Trim
            if (temp.Length >= 1)
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    if (temp[i].Contains(","))
                    {
                        temp[i] = temp[i].TrimEnd(','); //Removes weird characters
                    }
                }

                console.AppendText(string.Join(" | ", temp));//Splits line from fileButton to an array to be pushed to make an object
                OpcodeObject instruct;
                //0 string opcode;//opcode/function/label
                //1 string destination;
                //2 string source1;
                //3 string source2;// or immediate data
                //4 int misc; //Indicator label, instruction, or other 0 = label      1 = r type      2 = jump        3 = i type      4= Load/Save        5=Branch        6=.something        7=syscall
                //5 int location;

                switch (temp.Length)
                {
                    case 0:
                        console.AppendText("Empty line \r\n");
                        break;
                    case 1:
                        if (instruction.Contains(':'))
                        {
                            console.AppendText(" Possible label: " + instruction + "\r\n");
                            memoryTextBox.AppendText(intMem + "\t" + instruction + "\r\n");
                            instruct = new OpcodeObject(instruction, "", "", "", 0, intMem);
                            list.Add(instruct);
                            break;
                        }
                        else if (instruction.Contains('.'))
                        {
                            console.AppendText(" Possible data or cache allocation remark: " + instruction + "\r\n");
                            memoryTextBox.AppendText(intMem + "\t" + instruction + "\r\n");
                            instruct = new OpcodeObject(instruction, "", "", "", 6, intMem);
                            list.Add(instruct);
                            break;
                        }
                        else if (instruction.Contains("syscall"))
                        {
                            console.AppendText(" System Functions: " + instruction + "\r\n");
                            memoryTextBox.AppendText(intMem + "\t" + instruction + "\r\n");
                            instruct = new OpcodeObject(instruction, "", "", "", 7, intMem);
                            list.Add(instruct);
                            break;
                        }
                        else
                        {
                            console.AppendText(" Passed thru fileHandler case 1 possible bad formatting random tabs or spaces: " + instruction + "\r\n");
                            intMem--;
                            break;
                        }
                    case 2:
                        console.AppendText(" Possible J-Type instruction: " + instruction + "\r\n");
                        memoryTextBox.AppendText(intMem + "\t" + instruction + "\r\n");
                        instruct = new OpcodeObject(temp[0], temp[1], "", "", 2, intMem);
                        list.Add(instruct);
                        break;
                    case 3:
                        console.AppendText(" Possible Load or Save instruction: " + instruction + "\r\n");
                        memoryTextBox.AppendText(intMem + "\t" + instruction + "\r\n");
                        instruct = new OpcodeObject(temp[0], temp[1], temp[2], "", 4, intMem);
                        list.Add(instruct);
                        break;
                    case 4:
                        if (!(temp[0].Contains('i') || !temp[3].Contains('$')))
                        {
                            console.AppendText(" Possible R-Type instruction: " + instruction + "\r\n");
                            memoryTextBox.AppendText(intMem + "\t" + instruction + "\r\n");
                            instruct = new OpcodeObject(temp[0], temp[1], temp[2], temp[3], 1, intMem);
                            list.Add(instruct);
                        }
                        else
                        {
                            if (!(temp[0].Contains("b")))
                            {
                                console.AppendText(" Possible I-Type instruction: " + instruction + "\r\n");
                                memoryTextBox.AppendText(intMem + "\t" + instruction + "\r\n");
                                instruct = new OpcodeObject(temp[0], temp[1], temp[2], temp[3], 3, intMem);
                                list.Add(instruct);
                            }
                            else
                            {
                                console.AppendText(" Possible Branch instruction: " + instruction + "\r\n");
                                memoryTextBox.AppendText(intMem + "\t" + instruction + "\r\n");
                                instruct = new OpcodeObject(temp[0], temp[1], temp[2], temp[3], 5, intMem);
                                list.Add(instruct);
                            }
                        }
                        break;
                    case 5:
                        console.AppendText(" Possible instruction 5: " + instruction + "\r\n");
                        memoryTextBox.AppendText(intMem + "\t" + instruction + "\r\n");
                        instruct = new OpcodeObject(temp[0], temp[1], temp[2], temp[3], 1, intMem);
                        list.Add(instruct);
                        break;
                    default:
                        if ((temp[0].Contains(":")))
                        {
                            console.AppendText(" Possible label: " + instruction + "\r\n");
                            memoryTextBox.AppendText(intMem + "\t" + instruction + "\r\n");
                            instruct = new OpcodeObject(instruction, "", "", "", 0, intMem);
                            list.Add(instruct);
                            break;
                        }
                        console.AppendText(" Confused." + instruction + "\r\n");
                        memoryTextBox.AppendText(intMem + "\t" + instruction + "\r\n");
                        break;

                }
                intMem++;
            }
        }



        //Executions
        /// <summary> CHECK
        /// executeR
        /// Called for R-Type instructions
        /// CHECK: Needs review
        /// </summary>
        /// <param name="function"></param>
        /// <param name="source1"></param>
        /// <param name="source2"></param>
        /// <returns></returns>
        private int executeR(string function, string source1, string source2)
        {
            int s1 = signedBinaryToDecimal(source1); //Converts source1 binary to decimal int
            int s2 = signedBinaryToDecimal(source2); //Converts source2 binary to decimal int
            switch (function)
            {
                //Arithmetic
                case "add":
                    console.AppendText("Executing Addition: " + s1 + " + " + s2 + "\r\n");
                    int result = s1 + s2;
                    return result;
                case "sub":
                    console.AppendText("Executing Subtraction: " + s1 + " - " + s2 + "\r\n");
                    result = s1 - s2;
                    return result;
                case "mult":
                    console.AppendText("Executing Multiplication: " + s1 + " * " + s2 + "\r\n");
                    result = s1 * s2;
                    return result;
                case "div":
                    console.AppendText("Executing Division: " + s1 + " / " + s2 + "\r\n");
                    result = s1 / s2;
                    return result;

                //Comparison: set on less than
                case "slt": //if s1 < s2 sends 1 other wise sends 0
                    if(s1 < s2)
                    {
                        result = 1;
                    }
                    else
                    {
                        result = 0;
                    }
                    return result;

                //Logical
                case "and":
                    console.AppendText("Executing and \r\n");
                    result = s1 & s2;
                    return result;
                case "or":
                    console.AppendText("Executing or \r\n");
                    result = s1 | s2;
                    return result;
                case "xor":
                    console.AppendText("Executing xor \r\n");
                    result = s1 ^ s2;
                    return result;
                case "nor": //If ~($r | $zero) == not $r
                    console.AppendText("Executing nor \r\n");
                    result = ~(s1 | s2);
                    return result;
                default:
                    console.AppendText("Defaulted on Form1.execute: " + function + "\r\n");
                    return 0;
            }

        }

        /// <summary> CHECK
        /// executeI
        /// Called for I-Type instructions
        /// CHECK: Needs review
        /// </summary>
        /// <param name="function"></param>
        /// <param name="source1"></param>
        /// <param name="source2"></param>
        /// <returns></returns>
        private int executeI(string function, string source1, string source2)
        {
            int s1 = signedBinaryToDecimal(source1); //Converts binary to decimal int
            int s2 = int.Parse(source2); //Converts decimal string to int
            switch (function)
            {
                case "addi":
                    console.AppendText("Executing Addition: " + s1 + " + " + s2 + "\r\n");
                    int result = s1 + s2;
                    return result;

                //Comparison: set on less than immediate
                case "slti":
                    if (s1 < s2)
                    {
                        result = 1;
                    }
                    else
                    {
                        result = 0;
                    }
                    return result;
                default:
                    console.AppendText("Defaulted executeI: " + function + "\r\n");
                    return result = 0;
            }

        }

        /// <summary> CHECK
        /// executeJ
        /// Called for J-Type instructions
        /// CHECK: Needs review
        /// </summary>
        /// <param name="function"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        private int executeJ(string function, string destination)
        {
            switch (function)
            {
                //Jumps to destination
                case "j":
                    console.AppendText("Dectected j \r\n");
                    foreach (OpcodeObject e in list)
                    {
                        if (e.getOpcode().Contains(destination))
                        {
                            return e.getLocation() + 1; //Returns the memory location of jump location
                        }

                    }
                    console.AppendText("Case j didnt find " + destination + " location \r\n");
                    return 0;

                //CHECK THIS
                //Jumps to destination AND Stores current address in $ra 
                case "jal":
                    console.AppendText("Dectected jal \r\n");
                    foreach (OpcodeObject e in list)
                    {
                        if (e.getOpcode().Contains(destination))
                        {
                            textBox31.Text = convertToBinary(intPC); //Sets $ra to current pos
                            return e.getLocation() + 1; //Returns the memory location of jump location
                        }

                    }
                    console.AppendText("Case jal didnt find " + destination + " location \r\n");
                    return 0;

                //Jumps to register stored in register
                case "jr":
                    console.AppendText("Dectected jr \r\n");
                    Control desRegist = getRegisterTextBox(destination);
                    int address = signedBinaryToDecimal(desRegist.Text);//Converts register contents from binary to decimal
                    return address;
                default:
                    console.AppendText("Could not locate jump destination \r\n");
                    return 0;

            }

        }

        /// <summary> CHECK
        /// executeData
        /// Called for data transfer instruction
        /// CHECK: Not complete missing some
        /// </summary>
        /// <param name="function"></param>
        /// <param name="source1"></param>
        /// <returns></returns>
        private int executeData(string function, string source1)
        {
            switch (function)
            {
                //Load word
                case "lw":
                    return 0;

                //Store word
                case "sw":

                    return 0;

                //Load immediate
                case "li":
                    console.AppendText("Executing: " + list[intPC].toString() + "\r\n");
                    return int.Parse(source1); //Returns string decimal source1 to int

                //Load Address
                case "la":
                    console.AppendText("Executing: " + list[intPC].toString() + "\r\n");
                    foreach (OpcodeObject e in list)
                    {
                        if (e.getOpcode().Contains(source1))
                        {
                            return e.getLocation() + 1; //Returns memory address of a matching label
                        }

                    }
                    console.AppendText("Case la cant find " + source1 + " label \r\n");
                    return 0; //Returns 0 if cant find the label

                //Move
                case "move":
                    console.AppendText("Detected Move: ");
                    string destination = list[intPC].getDestination();
                    Control destin = getRegisterTextBox(destination); //Retrieves destination register
                    Control source = getRegisterTextBox(source1); //Retrieves source register
                    console.AppendText("Moving " + source1 + " to " + destination + "\r\n");
                    destin.Text = source.Text; //Sets source textbox value to destination textbox
                    source.Text = "00000000000000000000000000000000"; //sets source text to zero
                    return 0;
                default:
                    console.AppendText("Defaulted at executeData: " + function + "\r\n");
                    return 0; //Returns 0 if cant find matching case

            }
        }

        /// <summary> FINISHED
        /// executeBranch
        /// Called for Branch instructions
        /// </summary>
        /// <param name="function"></param>
        /// <param name="destination"></param>
        /// <param name="source1"></param>
        /// <returns></returns>
        private int executeBranch(string function, string destination, string source1)
        {

            int s1 = Convert.ToInt32(destination, 2);
            int s2 = Convert.ToInt32(source1, 2);
            int result;
            switch (function)
            {
                //Branch on equal
                case "beq": 
                    if (s1 == s2)
                    {
                        result = 1;
                        return result;
                    }
                    else
                    {
                        result = 0;
                        return result;
                    }

                //Branch on not equal
                case "bne": 
                    if(s1 != s2)
                    {
                        result = 1;
                    }else
                    {
                        result = 0;
                    }
                    return result;

                //Branch on greater than
                case "bgt": 
                    if (s1 > s2)
                    {
                        result = 1;
                    }
                    else
                    {
                        result = 0;
                    }
                    return result;

                //Branch on greater than or equal
                case "bge": 
                    if (s1 >= s2)
                    {
                        result = 1;
                    }
                    else
                    {
                        result = 0;
                    }
                    return result;

                //Branch on less than
                case "blt": 
                    if (s1 < s2)
                    {
                        result = 1;
                    }
                    else
                    {
                        result = 0;
                    }
                    return result;

                //Branch on less than or equal
                case "ble": 
                    if (s1 <= s2)
                    {
                        result = 1;
                    }
                    else
                    {
                        result = 0;
                    }
                    return result;
                default:
                    console.AppendText("Defaulted on Form1.executeBranch: " + function + "\r\n");
                    return 0;
            }
        }

        /// <summary> CHECK
        /// executeSyscall
        /// Depeneding on the value in $v0 will execute System Functions
        /// CHECK: Some of the functions are implemented floats are generally unimplementable currently
        /// </summary> 
        /// <param name="type"></param>
        private void executeSyscall(int function)
        {

            switch (function)
            {
                //1 = Print integer    $a0 = int to print FINISHED
                case 1:
                    console.AppendText("Detected 1 in $v0: Print integer \r\n");
                    int s1 = Convert.ToInt32(textBox4.Text, 2);//gets the address from $a0
                    string[] toPrint = list[s1 - 1].toString().Split('"');//gets the contents from memory and splits it by " to get the int to be printed
                    MessageBox.Show(toPrint[1] + "\r\n");
                    break;

                //2 = Print float      $f12 = float to print UNIMPLEMENTED
                case 2:
                    MessageBox.Show("UNIMPLEMENTED print float");
                    break;

                //3 = Print double     $f12 = float to print UNIMPLEMENTED
                case 3:
                    MessageBox.Show("UNIMPLEMENTED print double");
                    break;

                //4 = Print string     $a0 = address of string FINISHED
                case 4:
                    console.AppendText("Detected syscall 4 in $v0: Print string \r\n");
                    s1 = Convert.ToInt32(textBox4.Text, 2);//gets the address from $a0
                    toPrint = list[s1 - 1].toString().Split('"');//gets the contents from memory and splits it by " to get the string to be printed
                    MessageBox.Show(toPrint[1] + "\r\n");
                    break;

                // 5 = Read integer Stored in $v0 FINISHED
                case 5:
                    console.AppendText("Detected syscall 5 in $v0: Reading integer \r\n");
                    s1 = int.Parse(userInput.Text);
                    textBox2.Text = convertToBinary(s1);
                    break;

                //6 = Read float       Stored in $f0 UNIMPLEMENTED
                case 6:
                    MessageBox.Show("UNIMPLEMENTED read float");
                    break;

                //7 = Read double      Stored in $f0 UNIMPLEMENTED
                case 7:

                    MessageBox.Show("UNIMPLEMENTED read double");
                    break;

                //8 = Read string      Stored in buffer UNIMPLEMENTED
                case 8:
                    MessageBox.Show("UNIMPLEMENTED read string");
                    break;

                //9 = sbrk (allocate memory buffer)    $v0 = address of buffer UNIMPLEMENTED
                case 9:
                    MessageBox.Show("UNIMPLEMENTED sbrk");
                    break;

                //10 = exit UNIMPLEMENTED
                case 10:
                    MessageBox.Show("Syscall Exit CHECK TO-DO: STOP RUNNING/JUMP TO END");
                    break;

                //11 = Print Char UNIMPLEMENTED
                case 11:
                    MessageBox.Show("UNIMPLEMENTED print char");
                    break;

                default:
                    console.AppendText("Defaulted on executeSyscall: " + function + "\r\n");
                    break;
            }

        }



        //Conversions, Counters, Resets, and Retrievals
        /// <summary> FINISHED
        /// advancePC
        /// AdvancesPC counter and rewrites to PC textbox
        /// </summary>
        private void advancePC()
        {
            intPC++;
            PC.Text = convertToBinary(intPC);
            PC.Update();
        }

        /// <summary> FINISHED
        /// clear
        /// Clears every thing need this for when they open new file: cannot call the button listener
        /// </summary>
        private void clear()
        {
            intPC = 0;
            memoryTextBox.Text = "";
            console.Text = "";
            PC.Text = "";
            list.Clear();
            cacheTextBox.Clear();
            foreach (Control control in registerPanel.Controls)
            {
                if (control is TextBox text && text.Name.StartsWith("textBox"))
                {
                    text.Text = "00000000000000000000000000000000";
                }
            }
        }

        /// <summary> FINISHED
        /// getRegisterTextBox
        /// Takes in string name of the register and sends back the corresponding textbox object associated with it.
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        private Control getRegisterTextBox(string search)
        {
            switch (search)
            {
                case "$zero":
                case "0":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox0;
                case "$at":
                case "1":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox1;
                case "$v0":
                case "2":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox2;
                case "$v1":
                case "3":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox3;
                case "$a0":
                case "4":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox4;
                case "$a1":
                case "5":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox5;
                case "$a2":
                case "6":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox6;
                case "$a3":
                case "7":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox7;
                case "$t0":
                case "8":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox8;
                case "$t1":
                case "9":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox9;
                case "$t2":
                case "10":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox10;
                case "$t3":
                case "11":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox11;
                case "$t4":
                case "12":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox12;
                case "$t5":
                case "13":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox13;
                case "$t6":
                case "14":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox14;
                case "$t7":
                case "15":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox15;
                case "$s0":
                case "16":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox16;
                case "$s1":
                case "17":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox17;
                case "$s2":
                case "18":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox18;
                case "$s3":
                case "19":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox19;
                case "$s4":
                case "20":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox20;
                case "$s5":
                case "21":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox21;
                case "$s6":
                case "22":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox22;
                case "$s7":
                case "23":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox23;
                case "$t8":
                case "24":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox24;
                case "$t9":
                case "25":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox25;
                case "$k0":
                case "26":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox26;
                case "$k1":
                case "27":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox27;
                case "$gp":
                case "28":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox28;
                case "$sp":
                case "29":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox29;
                case "$fp":
                case "30":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox30;
                case "$ra":
                case "31":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox31;
                default:
                    console.AppendText("Did not recognize the register: " + search + "\r\n");
                    return textBox0;
            }

        }

        /// <summary> FINISHED
        /// convertToBinary
        /// Converts from int to binary
        /// Seemingly converts to signed
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private static string convertToBinary(int number)
        {
            string binaryString = Convert.ToString(number, 2); // Convert to binary string
            int length = binaryString.Length;
            binaryString = binaryString.PadLeft(32, '0'); // I want to add zeros until the length is 32 bits

            return binaryString;
        }

        /// <summary> CHECK
        /// signedBinaryToDecimal
        /// Converts string binary to decimal 
        /// Assumes Binary is signed
        /// CHECK: Testing for signed binary
        /// </summary>
        /// <param name="binary"></param>
        /// <returns></returns>
        private static int signedBinaryToDecimal(string binary)
        {
            int result = 0;
            int sign = 1;

            // Check if the number is negative
            if (binary[0] == '1')
            {
                sign = -1;
                // Invert bits for two's complement
                binary = binary.Replace('0', 'x').Replace('1', '0').Replace('x', '1');
            }

            // Convert binary to decimal
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                if (binary[i] == '1')
                {
                    result += (int)Math.Pow(2, binary.Length - 1 - i);
                }
            }

            // Apply sign
            return result * sign;
        }

        /// <summary> UNUSED CHECK
        /// decimalToBinary
        /// Converts string decimal to string binary
        /// </summary>
        /// <param name="deci"></param>
        /// <returns></returns>
        private static string decimalToBinary(string deci)
        {
            int intDeci = Convert.ToInt32(deci,2);
            string binaryString;
            if (intDeci >= 0)
            {
                binaryString = Convert.ToString(intDeci, 2); // Convert to binary string
                binaryString = binaryString.PadLeft(32, '0'); // I want to add zeros until the length is 32 bits
                return binaryString;
            }
            else
            {
                binaryString = Convert.ToString(intDeci, 2); // Convert to binary string
                binaryString = binaryString.PadLeft(32, '1'); // I want to add 1s until the length is 32 bits because it will be negative
                return binaryString;
            }
        }
    }
}
