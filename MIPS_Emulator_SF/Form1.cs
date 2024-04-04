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

        private void Form1_Load(object sender, EventArgs e)
        {
            //textBox1.Text = Register.Rzero().ToString();
            //textBox2.Text = Register.Rat().ToString();
            //textBox3.Text = Register.Rv0().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String instruction = "00000001000000000100000000100000";
            Decoder.EncodeType(instruction);

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = "0";
                }
            }
        }

        private void R1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void pcButton_Click(object sender, EventArgs e)
        {
            if (setPCTextBox != null)
            {
                PC.Text = setPCTextBox.Text;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
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
                        textBox4.Text = fileContents;
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
