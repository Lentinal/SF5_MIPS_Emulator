using System.Collections;
using System.Diagnostics;

namespace MIPS_Emulator_SF
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Global Variables
        /// </summary>
        private static ArrayList instructionsArray = new ArrayList();
        private static int intPC = 0;
        private static int stepCount = 0;

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
        private static String convertToBinary(int number)
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
            //Decoder call
            //String[] tempRaw = Decoder.EncodeType(setPCTextBox.Text); //Debug and testing

            //Assembly decode call
            try
            {
                String[] getFetch = AssemblyDecoder.Fetch(instructionsArray[intPC].ToString());
                console.Text += getFetch[9];//Spits out message on console
                if (!getFetch[6].Equals("1"))
                {
                    String[] getDecode = AssemblyDecoder.Decode(instructionsArray[intPC].ToString());
                    String[] getExecute = AssemblyDecoder.Execute(getDecode);
                    String[] getMemory = AssemblyDecoder.MemoryAccess(getExecute);
                    String[] write = AssemblyDecoder.Writeback(getMemory);
                    console.Text += "Completed one step: " + getDecode[9] + "\r\n";
                }

                //Decoder debugging
                //textBox33.Text += tempRaw[0] + "\r\n"; //Checks opcode
                //textBox33.Text += tempRaw[9] + "\r\n";    //Displays to console
                //Assembly debugging
                console.Text += string.Join(" | ", getFetch) + "\r\n"; //Splits returned array
                //textBox33.Text += instructionsList[0].ToString()+ "\r\n"; //Checks if the instruction list made it to the ArrayList

                //Advances memory/PC
                PC.Text = convertToBinary(intPC);
                intPC++;
            }
            catch (Exception ex)
            {
                console.Text += "Memory is possibly empty or end of instruction set:  (stepButtonClick) " + ex.Message + "\r\n";
            }


        }

        /// <summary> UNIMPLEMENTED
        /// microStepButton
        /// Takes one line and goes thru each part of the pipeline
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void microStepButton(Object sender, EventArgs e)
        {

        }

        /// <summary> FINISHED
        /// clearButton_Click
        /// Calls clear()
        /// </summary>
        private void clearButton_Click(object sender, EventArgs e)
        {
            clear();
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
            instructionsArray.Clear();
            foreach (Control control in registerPanel.Controls)
            {
                if (control is TextBox text && text.Name.StartsWith("textBox"))
                {
                    text.Text = "0000000000000000000000000000000";
                }
            }
        }

        /// <summary> CHECK
        /// pcButton_Click
        /// Sets PC value to what is in the setPCTextBox
        /// CHECK: Needs to account for if in binary or decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pcButton_Click(object sender, EventArgs e)
        {
            if (setPCTextBox != null)
            {
                PC.Text = setPCTextBox.Text;
            }
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

                        foreach (string line in instructions)
                        {
                            if (line.Length > 1)
                            {
                                instructionsArray.Add(line);
                                memoryTextBox.Text += intPC + "\t" + line + "\r\n";
                                intPC++;
                            }
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

    }

}
