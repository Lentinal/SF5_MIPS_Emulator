using System.Diagnostics;

namespace MIPS_Emulator_SF
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Global Variables
        /// </summary>
        private static List<OpcodeObject> list = new List<OpcodeObject>();
        private static int intPC = 0; //For holding PC/Memory location
        private static int stepCount = 0; //For microstep

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
                    text.Text = "0000000000000000000000000000000";
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

        /// <summary> FINISHED
        /// convertToBinary
        /// Converts from int to binary
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
                    String getText = text.Text;
                    int getDecimal = Convert.ToInt32(getText, 2);
                    text.Text = getDecimal.ToString();
                }
            }
        }

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
                OpcodeObject temp = list[intPC];
                console.AppendText("\r\n" + "Retrieved line: " + temp.toString() + "\r\n" );

                switch (temp.getMisc())
                {
                    //Label
                    case 0:
                        advancePC();
                        break;

                    //R-Type instruction
                    case 1:
                        console.AppendText("Fetching registers for R-Type \r\n");
                        Control source1 = getRegisterTextBox(temp.getSource1());
                        Control source2 = getRegisterTextBox(temp.getSource2());
                        String source1Int = source1.Text;
                        String source2Int = source2.Text;

                        console.AppendText("Decoding R-type instruction \r\n");
                        int write = executeR(temp.getOpcode(), source1Int, source2Int);

                        console.AppendText("Accessing destination register \r\n");
                        Control destin = getRegisterTextBox(temp.getDestination());

                        console.AppendText("Writing back to " + temp.getDestination() + "\r\n");
                        destin.Text = convertToBinary(write);

                        advancePC();
                        break;

                    //J-Type instruction
                    case 2:
                        console.AppendText("Fetched J-Type \r\n");

                        console.AppendText("Decoding J-Type instruction \r\n");
                        console.AppendText("Accessing jump location \r\n");
                        write = executeJ(temp.getOpcode(), temp.getDestination());

                        console.AppendText("Setting PC \r\n");
                        intPC = write;
                        break;

                    //I-Type instruction
                    case 3:
                        console.AppendText("Fetching registers for I-Type \r\n");
                        source1 = getRegisterTextBox(temp.getSource1());
                        source1Int = source1.Text;

                        console.AppendText("Decoding I-type instruction \r\n");
                        source2Int = temp.getSource2();

                        write = executeI(temp.getOpcode(), source1Int, source2Int);

                        console.AppendText("Accessing destination register \r\n");
                        destin = getRegisterTextBox(temp.getDestination());

                        console.AppendText("Writing back to " + temp.getDestination() + "\r\n");
                        destin.Text = convertToBinary(write);
                        advancePC();
                        break;

                    //li la sw sa instruction UNIMPLEMENTED
                    case 4:
                        console.AppendText("Possibly a load/save instruction: (UNIMPLEMENTED) \r\n");
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

                    //Syscall UNIMPLEMENTED
                    case 7:
                        advancePC();
                        break;

                    //Defaulted
                    default:
                        console.AppendText("Defaulted on Form1.stepButton: " + temp.ToString() + "\r\n");
                        advancePC();
                        break;
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
            console.Text += "test";
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
            foreach (Control control in registerPanel.Controls)
            {
                if (control is TextBox text && text.Name.StartsWith("textBox"))
                {
                    text.Text = "0000000000000000000000000000000";
                }
            }
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
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
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
                        String[] instructions = fileContents.Split("\n");

                        for (int i = 0; i < instructions.Length; i++)
                        {
                            if (instructions[i].Length > 1 && !instructions[i].StartsWith("#"))
                            {
                                FileHandler(instructions[i]);
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

        /// <summary> FINISHED
        /// advancePC
        /// AdvancesPC counter and rewrites to PC textbox
        /// </summary>
        private void advancePC()
        {
            intPC++;
            PC.Text = convertToBinary(intPC);
        }

        /// <summary> CHECK
        /// FileHandler
        /// For file button legibility 
        /// CHECK: Need clearing and review
        /// </summary>
        /// <param name="instruction"></param>
        private void FileHandler(string instruction)
        {
            char[] charsToTrimEnd = { ' ', '#', '\n', '\r', '\t' };
            char[] charsToTrimStart = { ' ', '\t', };
            string commentcut = (instruction.Substring(0, instruction.LastIndexOf("#") + 1)).ToLower();
            commentcut = commentcut.TrimStart();
            commentcut = commentcut.TrimEnd(charsToTrimEnd);
            String[] temp = commentcut.Split(" ");
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

                console.Text += string.Join(" | ", temp);//Splits line from fileButton to an array to be pushed to make an object
                OpcodeObject instruct;
                //string opcode;//opcode/function/label
                //string destination;
                //string source1;
                //string source2;// or immediate data
                //int misc; //Indicator label, instruction, or other 0 = label      1 = r type      2 = jump        3 = i type      4= Load/Save        5=Branch        6=.something        7=syscall
                //int location;

                switch (temp.Length)
                {
                    case 0:
                        console.AppendText("Empty line \r\n");
                        break;
                    case 1:
                        if (instruction.Contains(":"))
                        {
                            console.AppendText("Possible label: " + instruction + "\r\n");
                            memoryTextBox.Text += intPC + "\t" + instruction + "\r\n";
                            instruct = new OpcodeObject(instruction, "", "", "", 0, intPC);
                            list.Add(instruct);
                            break;
                        }
                        else if (instruction.Contains("."))
                        {
                            console.AppendText("Possible data or cache allocation remark: " + instruction + "\r\n");
                            memoryTextBox.Text += intPC + "\t" + instruction + "\r\n";
                            instruct = new OpcodeObject(instruction, "", "", "", 6, intPC);
                            list.Add(instruct);
                            break;
                        }
                        else if (instruction.Contains("syscall"))
                        {
                            console.AppendText("System Functions: " + instruction + "\r\n");
                            memoryTextBox.Text += intPC + "\t" + instruction + "\r\n";
                            instruct = new OpcodeObject(instruction, "", "", "", 7, intPC);
                            list.Add(instruct);
                            break;
                        }
                        else
                        {
                            console.AppendText("Passed thru fileHandler case 1: " + instruction + "\r\n");
                            break;
                        }
                    case 2:
                        console.AppendText(" Possible J-Type instruction: " + instruction + "\r\n");
                        memoryTextBox.Text += intPC + "\t" + instruction + "\r\n";
                        instruct = new OpcodeObject(temp[0], temp[1], "", "", 2, intPC);
                        list.Add(instruct);
                        break;
                    case 3:
                        console.AppendText(" Possible Load or Save instruction: " + instruction + "\r\n");
                        memoryTextBox.Text += intPC + "\t" + instruction + "\r\n";
                        instruct = new OpcodeObject(temp[0], temp[1], temp[2], "", 4, intPC);
                        list.Add(instruct);
                        break;
                    case 4:
                        if (!(temp[0].Contains("i") || !temp[3].Contains("$")))
                        {
                            console.AppendText(" Possible R-Type instruction: " + instruction + "\r\n");
                            memoryTextBox.Text += intPC + "\t" + instruction + "\r\n";
                            instruct = new OpcodeObject(temp[0], temp[1], temp[2], temp[3], 1, intPC);
                            list.Add(instruct);
                        }
                        else
                        {
                            if (!(temp[0].Contains("b")))
                            {
                                console.AppendText(" Possible I-Type instruction: " + instruction + "\r\n");
                                memoryTextBox.Text += intPC + "\t" + instruction + "\r\n";
                                instruct = new OpcodeObject(temp[0], temp[1], temp[2], temp[3], 3, intPC);
                                list.Add(instruct);
                            }
                            else
                            {
                                console.AppendText(" Possible Branch instruction: " + instruction + "\r\n");
                                memoryTextBox.Text += intPC + "\t" + instruction + "\r\n";
                                instruct = new OpcodeObject(temp[0], temp[1], temp[2], temp[3], 5, intPC);
                                list.Add(instruct);
                            }
                        }
                        break;
                    case 5:
                        console.AppendText(" Possible instruction 5: " + instruction + "\r\n");
                        memoryTextBox.Text += intPC + "\t" + instruction + "\r\n";
                        instruct = new OpcodeObject(temp[0], temp[1], temp[2], temp[3], 1, intPC);
                        list.Add(instruct);
                        break;
                    default:
                        console.AppendText(" Confused." + instruction + "\r\n");
                        memoryTextBox.Text += intPC + "\t" + instruction + "\r\n";
                        break;

                }
                intPC++;
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
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox0;
                case "$at":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox1;
                case "$v0":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox2;
                case "$v1":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox3;
                case "$a0":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox4;
                case "$a1":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox5;
                case "$a2":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox6;
                case "$a3":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox7;
                case "$t0":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox8;
                case "$t1":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox9;
                case "$t2":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox10;
                case "$t3":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox11;
                case "$t4":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox12;
                case "$t5":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox13;
                case "$t6":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox14;
                case "$t7":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox15;
                case "$s0":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox16;
                case "$s1":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox17;
                case "$s2":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox18;
                case "$s3":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox19;
                case "$s4":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox20;
                case "$s5":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox21;
                case "$s6":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox22;
                case "$s7":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox23;
                case "$t8":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox24;
                case "$t9":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox25;
                case "$k0":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox26;
                case "$k1":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox27;
                case "$gp":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox28;
                case "$sp":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox29;
                case "$fp":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox30;
                case "$ra":
                    console.AppendText("Recognized register: " + search + "\r\n");
                    return textBox31;
                default:
                    console.AppendText("Did not recognize the register: " + search + "\r\n");
                    return textBox0;
            }

        }

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
            int s1 = Convert.ToInt32(source1, 2);
            int s2 = Convert.ToInt32(source2, 2);
            switch (function)
            {
                //Arrithmetic
                case "add":
                    console.AppendText("Executing Addition: " + s1 + " + " + s2 + "\r\n");
                    int result = s1 + s2;
                    return result;
                case "mult":
                    result = s1 * s2;
                    return result;
                case "div":
                    result = s1 / s2;
                    return result;
                //Logical
                case "and":
                    result = s1 & s2;
                    return result;
                case "or":
                    result = s1 | s2;
                    return result;
                case "xor":
                    result = s1 ^ s2;
                    return result;
                case "nor": //If ~($r | $zero) == not $r
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
            int s1 = Convert.ToInt32(source1, 2);
            int s2 = int.Parse(source2);
            switch (function)
            {
                case "addi":
                    console.AppendText("Executing Addition: " + s1 + " + " + s2 + "\r\n");
                    int result = s1 + s2;
                    return result;

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
                case "j":
                case "jal":
                    foreach (OpcodeObject e in list)
                    {
                        if (e.getOpcode().Contains(destination))
                        {
                            return e.getLocation() + 1;
                        }

                    }
                    console.AppendText("Case j didnt find " + destination + " location \r\n");
                    return 0;
                default:
                    console.AppendText("Could not locate jump destination \r\n");
                    return 0;

            }

        }

        /// <summary> CHECK
        /// executeBranch
        /// Called for Branch instructions
        /// CHECK: Needs review
        /// </summary>
        /// <param name="function"></param>
        /// <param name="destination"></param>
        /// <param name="source1"></param>
        /// <returns></returns>
        private int executeBranch(string function, string destination, string source1)
        {

            int s1 = Convert.ToInt32(destination, 2);
            int s2 = Convert.ToInt32(source1, 2);
            switch (function)
            {
                case "beq":
                    if (s1 == s2)
                    {
                        int result = 1;
                        return result;
                    }
                    else
                    {
                        int result = 0;
                        return result;
                    }
                default:
                    console.AppendText("Defaulted on Form1.executeBranch: " + function + "\r\n");
                    return 0;
            }
        }

        /// <summary> UNIMPLEMENTED
        /// executeSyscall
        /// Depeneding on the value in $v0 will execute System Functions
        /// </summary>
        /// <param name="type"></param>
        private void executeSyscall(int type)
        {


        }

        /// <summary> CHECK
        /// binaryToDecimal
        /// UNUSED HOLD FOR NOW
        /// CHECK: Needs review
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private static int binaryToDecimal(int n)
        {
            int dec_value = 0;

            int base1 = 1;

            int temp = n;
            while (temp > 0)
            {
                int last_digit = temp % 10;
                temp = temp / 10;

                dec_value += last_digit * base1;

                base1 = base1 * 2;
            }

            return dec_value;
        }
    }
}
