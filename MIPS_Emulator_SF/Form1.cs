using System.Diagnostics;
using System.Numerics;
using System.Windows.Forms.Design;

namespace MIPS_Emulator_SF
{
    public partial class Form1 : Form
    {
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
        private void Form1_Load(object sender, EventArgs e) //Delanie was here
        {

        }

        //Binary Convert
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


        //BinaryRadio
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

        //DecimalRadio
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

        //Step button
        private void stepButtonClick(object sender, EventArgs e)
        {
            String[] tempRaw = Decoder.EncodeType(setPCTextBox.Text); //Debug and testing
            textBox33.Text = tempRaw[0];
            textBox33.Text += tempRaw[9];
            String[] temp =  AssemblyDecoder.Fetch("addi $a0, $zero, 7");
            textBox33.Text += temp[9];//Spits out message on console

        }

        //Clear Button
        private void clearButton_Click(object sender, EventArgs e)
        {

        }

        //Set PC button
        private void pcButton_Click(object sender, EventArgs e)
        {
            if (setPCTextBox != null)
            {
                PC.Text = setPCTextBox.Text;
            }
        }

        //Run button
        private void runButton_Click(object sender, EventArgs e)
        {

        }

        //Save button
        private void saveButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "10";
        }

        //File button
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
                        string filePath = openFileDialog.FileName;
                        string fileContents = File.ReadAllText(filePath);

                        // Display the file contents in the r1TextBox
                        memoryTextBox.Text = fileContents;
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
