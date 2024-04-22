using System.Collections;
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
            int neededZeros = 32 - length;
            if (length != 32)
            {
                binaryString = binaryString.PadLeft(neededZeros, '0'); // I want to add zeros until the length is 32 bits
            }
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
                console.Text += "Fetched: " + temp.getOpcode() + "\r\n";
                switch (temp.getMisc())
                {
                    case "0":
                        advancePC();
                        break;
                    case "1":
                        console.Text += "Fetching registers \r\n";
                        String destin = getRegisterTextBox(temp.getDestination());
                        String source1 = getRegisterTextBox(temp.getSource1());
                        String source2 = getRegisterTextBox(temp.getSource2());

                        String write = execute(temp.getOpcode(), source1, source2);
                        console.Text += write + "\r\n";

                        advancePC();
                        break;
                    case "2":
                        console.Text += "Fetched Jump: (UNIMPLEMENT)" + "\r\n";
                        advancePC();
                        break;
                    default:
                        console.Text += "Defaulted on Form1.stepButton: " + temp.ToString() + "\r\n";
                        advancePC();
                        break;
                }
            }
            catch (Exception ex)
            {
                console.Text += "Memory is possibly empty or PC points to nowhere: " + ex.Message + "\r\n";
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
            console.Text += "Set PC to : " + intPC + "\r\n";
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
                            FileHandler(instructions[i]);
                        }

                        intPC = 0; //Resets counter
                        console.Text += "Loaded in: " + filePath + "\r\n";
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
            char[] charsToTrim = { ' ', '#', '\n', '\r', '\t' };
            string commentcut = (instruction.Substring(0, instruction.LastIndexOf("#") + 1)).ToLower();
            commentcut = commentcut.TrimEnd(charsToTrim);
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

                console.Text += string.Join(" | ", temp);
                switch (temp.Length)
                {
                    case 0:
                        console.Text += "Empty line \r\n";
                        break;
                    case 1:
                        console.Text += "Possible label: " + instruction + "\r\n";
                        memoryTextBox.Text += intPC + "\t" + instruction + "\r\n";
                        OpcodeObject instruct = new OpcodeObject(instruction, "", "", "", "0", intPC.ToString());
                        list.Add(instruct);
                        break;
                    case 2:
                        console.Text += " Possible Jump: " + instruction + "\r\n";
                        memoryTextBox.Text += intPC + "\t" + instruction + "\r\n";
                        instruct = new OpcodeObject(temp[0], temp[1], "", "", "2", intPC.ToString());
                        list.Add(instruct);
                        break;
                    case 3:
                        console.Text += " Possible instruction: " + instruction + "\r\n";
                        memoryTextBox.Text += intPC + "\t" + instruction + "\r\n";
                        instruct = new OpcodeObject(temp[0], temp[1], temp[2], "", "1", intPC.ToString());
                        list.Add(instruct);
                        break;
                    case 4:
                        console.Text += " Possible instruction: " + instruction + "\r\n";
                        memoryTextBox.Text += intPC + "\t" + instruction + "\r\n";
                        instruct = new OpcodeObject(temp[0], temp[1], temp[2], temp[3], "1", intPC.ToString());
                        list.Add(instruct);
                        break;
                    case 5:
                        console.Text += " Possible instruction: " + instruction + "\r\n";
                        memoryTextBox.Text += intPC + "\t" + instruction + "\r\n";
                        instruct = new OpcodeObject(temp[0], temp[1], temp[2], temp[3], "1", intPC.ToString());
                        list.Add(instruct);
                        break;
                    default:
                        console.Text += " Confused." + instruction + "\r\n";
                        memoryTextBox.Text += intPC + "\t" + instruction + "\r\n";
                        break;

                }
                intPC++;


            }



        }

        private string getRegisterTextBox(string search)
        {
            switch (search)
            {
                case "$zero":
                    console.Text += "Recognized register: " + search + "\r\n";
                    return textBox0.Text;
                case "$at":
                    console.Text += "Recognized register: " + search + "\r\n";
                    return textBox1.Text;
                case "$v0":
                    console.Text += "Recognized register: " + search + "\r\n";
                    return textBox2.Text;
                case "$v1":
                    console.Text += "Recognized register: " + search + "\r\n";
                    return textBox3.Text;
                case "$a0":
                    console.Text += "Recognized register: " + search + "\r\n";
                    return textBox4.Text;
                case "$a1":
                    console.Text += "Recognized register: " + search + "\r\n";
                    return textBox5.Text;
                case "$a2":
                    console.Text += "Recognized register: " + search + "\r\n";
                    return textBox6.Text;
                case "$a3":
                    console.Text += "Recognized register: " + search + "\r\n";
                    return textBox7.Text;
                case "$t0":
                    console.Text += "Recognized register: " + search + "\r\n";
                    return textBox8.Text;
                case "$t1":
                    console.Text += "Recognized register: " + search + "\r\n";
                    return textBox9.Text;
                case "$t2":
                    console.Text += "Recognized register: " + search + "\r\n";
                    return textBox10.Text;
                case "$t3":
                    console.Text += "Recognized register: " + search + "\r\n";
                    return textBox11.Text;
                case "$t4":
                    console.Text += "Recognized register: " + search + "\r\n";
                    return textBox12.Text;
                case "$t5":
                    console.Text += "Recognized register: " + search + "\r\n";
                    return textBox13.Text;
                case "$t6":
                    console.Text += "Recognized register: " + search + "\r\n";
                    return textBox14.Text;
                case "$t7":
                    console.Text += "Recognized register: " + search + "\r\n";
                    return textBox15.Text;
                case "$s0":
                    console.Text += "Recognized register: " + search + "\r\n";
                    return textBox16.Text;
                case "$s1":
                    console.Text += "Recognized register: " + search + "\r\n";
                    return textBox17.Text;
                case "$s2":
                    console.Text += "Recognized register: " + search + "\r\n";
                    return textBox18.Text;
                case "$s3":
                    console.Text += "Recognized register: " + search + "\r\n";
                    return textBox19.Text;
                case "$s4":
                    console.Text += "Recognized register: " + search + "\r\n";
                    return textBox20.Text;
                case "$s5":
                    console.Text += "Recognized register: " + search + "\r\n";
                    return textBox21.Text;
                case "$s6":
                    console.Text += "Recognized register: " + search + "\r\n";
                    return textBox22.Text;
                case "$s7":
                    console.Text += "Recognized register: " + search + "\r\n";
                    return textBox23.Text;
                case "$t8":
                    console.Text += "Recognized register: " + search + "\r\n";
                    return textBox24.Text;
                case "$t9":
                    console.Text += "Recognized register: " + search + "\r\n";
                    return textBox25.Text;
                case "$k0":
                    console.Text += "Recognized register: " + search + "\r\n";
                    return textBox26.Text;
                case "$k1":
                    console.Text += "Recognized register: " + search + "\r\n";
                    return textBox27.Text;
                case "$gp":
                    console.Text += "Recognized register: " + search + "\r\n";
                    return textBox28.Text;
                case "$sp":
                    console.Text += "Recognized register: " + search + "\r\n";
                    return textBox29.Text;
                case "$fp":
                    console.Text += "Recognized register: " + search + "\r\n";
                    return textBox30.Text;
                case "$ra":
                    console.Text += "Recognized register: " + search + "\r\n";
                    return textBox31.Text;
                default:
                    console.Text += "Did not recognize the register: " + search + "\r\n";
                    return search;
            }

        }

        private string execute(string function, string source1, string source2)
        {
            switch (function)
            {
                case "add":
                case "addi":
                    console.Text += "Executing Add/Addi: " + source1 + " + " + source2 + "\r\n";
                    int result = int.Parse(source1) + int.Parse(source2);
                    return result.ToString();
                case "mul":

                    return "";
                default:
                    console.Text += "Defaulted on Form1.execute: " + function + "\r\n";
                    return "";
            }

        }

    }

}
