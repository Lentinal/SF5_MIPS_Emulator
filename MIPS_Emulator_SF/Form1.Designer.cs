namespace MIPS_Emulator_SF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            stepButton = new Button();
            microButton = new Button();
            saveButton = new Button();
            pcButton = new Button();
            setPCTextBox = new TextBox();
            radioPanel = new Panel();
            dataLabel = new Label();
            radioDecimal = new RadioButton();
            radioHex = new RadioButton();
            radioBinary = new RadioButton();
            clearButton = new Button();
            clearConsoleButton = new Button();
            registerPanel = new Panel();
            textBox24 = new TextBox();
            textBox23 = new TextBox();
            textBox22 = new TextBox();
            PC = new TextBox();
            textBox21 = new TextBox();
            textBox0 = new TextBox();
            textBox20 = new TextBox();
            textBox31 = new TextBox();
            textBox19 = new TextBox();
            textBox30 = new TextBox();
            textBox18 = new TextBox();
            textBox29 = new TextBox();
            textBox17 = new TextBox();
            textBox28 = new TextBox();
            textBox27 = new TextBox();
            textBox16 = new TextBox();
            textBox26 = new TextBox();
            textBox15 = new TextBox();
            textBox25 = new TextBox();
            textBox14 = new TextBox();
            textBox13 = new TextBox();
            textBox12 = new TextBox();
            textBox11 = new TextBox();
            textBox10 = new TextBox();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label24 = new Label();
            label23 = new Label();
            label33 = new Label();
            label22 = new Label();
            label32 = new Label();
            label21 = new Label();
            label31 = new Label();
            label20 = new Label();
            label30 = new Label();
            label19 = new Label();
            label29 = new Label();
            label18 = new Label();
            label28 = new Label();
            label17 = new Label();
            label27 = new Label();
            label16 = new Label();
            label26 = new Label();
            label15 = new Label();
            label25 = new Label();
            label14 = new Label();
            label1 = new Label();
            label2 = new Label();
            registerLabel = new Label();
            button1 = new Button();
            instructionTextBox = new TextBox();
            label36 = new Label();
            panel1 = new Panel();
            label35 = new Label();
            label34 = new Label();
            console = new TextBox();
            label37 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label38 = new Label();
            label39 = new Label();
            memoryTextBox = new TextBox();
            label40 = new Label();
            runButton = new Button();
            radioPanel.SuspendLayout();
            registerPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // stepButton
            // 
            stepButton.AccessibleDescription = "";
            stepButton.AccessibleName = "";
            stepButton.Location = new Point(1136, 928);
            stepButton.Margin = new Padding(3, 4, 3, 4);
            stepButton.Name = "stepButton";
            stepButton.Size = new Size(99, 60);
            stepButton.TabIndex = 0;
            stepButton.Text = "Step 1";
            stepButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            stepButton.UseVisualStyleBackColor = true;
            stepButton.Click += stepButtonClick;
            // 
            // microButton
            // 
            microButton.ForeColor = Color.FromArgb(64, 64, 0);
            microButton.Location = new Point(1255, 928);
            microButton.Margin = new Padding(3, 4, 3, 4);
            microButton.Name = "microButton";
            microButton.Size = new Size(99, 60);
            microButton.TabIndex = 1;
            microButton.Text = "Micro Step 1";
            microButton.UseVisualStyleBackColor = true;
            microButton.Click += microButton_Click;
            // 
            // saveButton
            // 
            saveButton.ForeColor = Color.Red;
            saveButton.Location = new Point(1255, 996);
            saveButton.Margin = new Padding(3, 4, 3, 4);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(99, 60);
            saveButton.TabIndex = 3;
            saveButton.Text = "Save current values";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // pcButton
            // 
            pcButton.Location = new Point(1136, 1064);
            pcButton.Margin = new Padding(3, 4, 3, 4);
            pcButton.Name = "pcButton";
            pcButton.Size = new Size(99, 35);
            pcButton.TabIndex = 4;
            pcButton.Text = "Set PC Value";
            pcButton.UseVisualStyleBackColor = true;
            pcButton.Click += pcButton_Click;
            // 
            // setPCTextBox
            // 
            setPCTextBox.Location = new Point(1242, 1064);
            setPCTextBox.Margin = new Padding(3, 4, 3, 4);
            setPCTextBox.Name = "setPCTextBox";
            setPCTextBox.Size = new Size(302, 27);
            setPCTextBox.TabIndex = 5;
            // 
            // radioPanel
            // 
            radioPanel.BackColor = SystemColors.ButtonHighlight;
            radioPanel.Controls.Add(dataLabel);
            radioPanel.Controls.Add(radioDecimal);
            radioPanel.Controls.Add(radioHex);
            radioPanel.Controls.Add(radioBinary);
            radioPanel.Location = new Point(1729, 944);
            radioPanel.Margin = new Padding(3, 4, 3, 4);
            radioPanel.Name = "radioPanel";
            radioPanel.Size = new Size(133, 171);
            radioPanel.TabIndex = 6;
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.BackColor = SystemColors.ButtonHighlight;
            dataLabel.Font = new Font("Segoe UI", 12F);
            dataLabel.Location = new Point(11, 13);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new Size(97, 28);
            dataLabel.TabIndex = 7;
            dataLabel.Text = "Data type";
            // 
            // radioDecimal
            // 
            radioDecimal.AutoSize = true;
            radioDecimal.Location = new Point(11, 81);
            radioDecimal.Margin = new Padding(3, 4, 3, 4);
            radioDecimal.Name = "radioDecimal";
            radioDecimal.Size = new Size(85, 24);
            radioDecimal.TabIndex = 2;
            radioDecimal.TabStop = true;
            radioDecimal.Text = "Decimal";
            radioDecimal.UseVisualStyleBackColor = true;
            radioDecimal.CheckedChanged += radioDecimal_CheckedChanged;
            // 
            // radioHex
            // 
            radioHex.AutoSize = true;
            radioHex.ForeColor = Color.Red;
            radioHex.Location = new Point(11, 115);
            radioHex.Margin = new Padding(3, 4, 3, 4);
            radioHex.Name = "radioHex";
            radioHex.Size = new Size(56, 24);
            radioHex.TabIndex = 1;
            radioHex.TabStop = true;
            radioHex.Text = "Hex";
            radioHex.UseVisualStyleBackColor = true;
            // 
            // radioBinary
            // 
            radioBinary.AutoSize = true;
            radioBinary.Location = new Point(11, 48);
            radioBinary.Margin = new Padding(3, 4, 3, 4);
            radioBinary.Name = "radioBinary";
            radioBinary.Size = new Size(71, 24);
            radioBinary.TabIndex = 0;
            radioBinary.TabStop = true;
            radioBinary.Text = "Binary";
            radioBinary.UseVisualStyleBackColor = true;
            radioBinary.CheckedChanged += radioBinary_CheckedChanged;
            // 
            // clearButton
            // 
            clearButton.ForeColor = Color.Red;
            clearButton.Location = new Point(1361, 996);
            clearButton.Margin = new Padding(3, 4, 3, 4);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(99, 60);
            clearButton.TabIndex = 7;
            clearButton.Text = "Clear cache";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // clearConsoleButton
            // 
            clearConsoleButton.Location = new Point(1136, 996);
            clearConsoleButton.Margin = new Padding(3, 4, 3, 4);
            clearConsoleButton.Name = "clearConsoleButton";
            clearConsoleButton.Size = new Size(99, 60);
            clearConsoleButton.TabIndex = 8;
            clearConsoleButton.Text = "Clear Console";
            clearConsoleButton.UseVisualStyleBackColor = true;
            clearConsoleButton.Click += clearConsole_Click;
            // 
            // registerPanel
            // 
            registerPanel.Controls.Add(textBox24);
            registerPanel.Controls.Add(textBox23);
            registerPanel.Controls.Add(textBox22);
            registerPanel.Controls.Add(PC);
            registerPanel.Controls.Add(textBox21);
            registerPanel.Controls.Add(textBox0);
            registerPanel.Controls.Add(textBox20);
            registerPanel.Controls.Add(textBox31);
            registerPanel.Controls.Add(textBox19);
            registerPanel.Controls.Add(textBox30);
            registerPanel.Controls.Add(textBox18);
            registerPanel.Controls.Add(textBox29);
            registerPanel.Controls.Add(textBox17);
            registerPanel.Controls.Add(textBox28);
            registerPanel.Controls.Add(textBox27);
            registerPanel.Controls.Add(textBox16);
            registerPanel.Controls.Add(textBox26);
            registerPanel.Controls.Add(textBox15);
            registerPanel.Controls.Add(textBox25);
            registerPanel.Controls.Add(textBox14);
            registerPanel.Controls.Add(textBox13);
            registerPanel.Controls.Add(textBox12);
            registerPanel.Controls.Add(textBox11);
            registerPanel.Controls.Add(textBox10);
            registerPanel.Controls.Add(textBox9);
            registerPanel.Controls.Add(textBox8);
            registerPanel.Controls.Add(textBox7);
            registerPanel.Controls.Add(textBox6);
            registerPanel.Controls.Add(textBox5);
            registerPanel.Controls.Add(textBox4);
            registerPanel.Controls.Add(textBox3);
            registerPanel.Controls.Add(textBox2);
            registerPanel.Controls.Add(textBox1);
            registerPanel.Controls.Add(label13);
            registerPanel.Controls.Add(label12);
            registerPanel.Controls.Add(label11);
            registerPanel.Controls.Add(label10);
            registerPanel.Controls.Add(label9);
            registerPanel.Controls.Add(label8);
            registerPanel.Controls.Add(label7);
            registerPanel.Controls.Add(label6);
            registerPanel.Controls.Add(label5);
            registerPanel.Controls.Add(label4);
            registerPanel.Controls.Add(label3);
            registerPanel.Controls.Add(label24);
            registerPanel.Controls.Add(label23);
            registerPanel.Controls.Add(label33);
            registerPanel.Controls.Add(label22);
            registerPanel.Controls.Add(label32);
            registerPanel.Controls.Add(label21);
            registerPanel.Controls.Add(label31);
            registerPanel.Controls.Add(label20);
            registerPanel.Controls.Add(label30);
            registerPanel.Controls.Add(label19);
            registerPanel.Controls.Add(label29);
            registerPanel.Controls.Add(label18);
            registerPanel.Controls.Add(label28);
            registerPanel.Controls.Add(label17);
            registerPanel.Controls.Add(label27);
            registerPanel.Controls.Add(label16);
            registerPanel.Controls.Add(label26);
            registerPanel.Controls.Add(label15);
            registerPanel.Controls.Add(label25);
            registerPanel.Controls.Add(label14);
            registerPanel.Controls.Add(label1);
            registerPanel.Controls.Add(label2);
            registerPanel.Controls.Add(registerLabel);
            registerPanel.Location = new Point(14, 16);
            registerPanel.Margin = new Padding(3, 4, 3, 4);
            registerPanel.Name = "registerPanel";
            registerPanel.Size = new Size(1115, 688);
            registerPanel.TabIndex = 9;
            // 
            // textBox24
            // 
            textBox24.Location = new Point(456, 359);
            textBox24.Margin = new Padding(3, 4, 3, 4);
            textBox24.Name = "textBox24";
            textBox24.ReadOnly = true;
            textBox24.Size = new Size(274, 27);
            textBox24.TabIndex = 14;
            // 
            // textBox23
            // 
            textBox23.Location = new Point(456, 320);
            textBox23.Margin = new Padding(3, 4, 3, 4);
            textBox23.Name = "textBox23";
            textBox23.ReadOnly = true;
            textBox23.Size = new Size(274, 27);
            textBox23.TabIndex = 14;
            // 
            // textBox22
            // 
            textBox22.Location = new Point(456, 281);
            textBox22.Margin = new Padding(3, 4, 3, 4);
            textBox22.Name = "textBox22";
            textBox22.ReadOnly = true;
            textBox22.Size = new Size(274, 27);
            textBox22.TabIndex = 14;
            // 
            // PC
            // 
            PC.Location = new Point(819, 52);
            PC.Margin = new Padding(3, 4, 3, 4);
            PC.Name = "PC";
            PC.ReadOnly = true;
            PC.Size = new Size(274, 27);
            PC.TabIndex = 14;
            // 
            // textBox21
            // 
            textBox21.Location = new Point(456, 243);
            textBox21.Margin = new Padding(3, 4, 3, 4);
            textBox21.Name = "textBox21";
            textBox21.ReadOnly = true;
            textBox21.Size = new Size(274, 27);
            textBox21.TabIndex = 14;
            // 
            // textBox0
            // 
            textBox0.Location = new Point(77, 49);
            textBox0.Margin = new Padding(3, 4, 3, 4);
            textBox0.Name = "textBox0";
            textBox0.ReadOnly = true;
            textBox0.Size = new Size(274, 27);
            textBox0.TabIndex = 14;
            // 
            // textBox20
            // 
            textBox20.Location = new Point(456, 204);
            textBox20.Margin = new Padding(3, 4, 3, 4);
            textBox20.Name = "textBox20";
            textBox20.ReadOnly = true;
            textBox20.Size = new Size(274, 27);
            textBox20.TabIndex = 14;
            // 
            // textBox31
            // 
            textBox31.Location = new Point(456, 629);
            textBox31.Margin = new Padding(3, 4, 3, 4);
            textBox31.Name = "textBox31";
            textBox31.ReadOnly = true;
            textBox31.Size = new Size(274, 27);
            textBox31.TabIndex = 14;
            // 
            // textBox19
            // 
            textBox19.Location = new Point(456, 165);
            textBox19.Margin = new Padding(3, 4, 3, 4);
            textBox19.Name = "textBox19";
            textBox19.ReadOnly = true;
            textBox19.Size = new Size(274, 27);
            textBox19.TabIndex = 14;
            // 
            // textBox30
            // 
            textBox30.Location = new Point(456, 591);
            textBox30.Margin = new Padding(3, 4, 3, 4);
            textBox30.Name = "textBox30";
            textBox30.ReadOnly = true;
            textBox30.Size = new Size(274, 27);
            textBox30.TabIndex = 14;
            // 
            // textBox18
            // 
            textBox18.Location = new Point(456, 127);
            textBox18.Margin = new Padding(3, 4, 3, 4);
            textBox18.Name = "textBox18";
            textBox18.ReadOnly = true;
            textBox18.Size = new Size(274, 27);
            textBox18.TabIndex = 14;
            // 
            // textBox29
            // 
            textBox29.Location = new Point(456, 552);
            textBox29.Margin = new Padding(3, 4, 3, 4);
            textBox29.Name = "textBox29";
            textBox29.ReadOnly = true;
            textBox29.Size = new Size(274, 27);
            textBox29.TabIndex = 14;
            // 
            // textBox17
            // 
            textBox17.Location = new Point(456, 88);
            textBox17.Margin = new Padding(3, 4, 3, 4);
            textBox17.Name = "textBox17";
            textBox17.ReadOnly = true;
            textBox17.Size = new Size(274, 27);
            textBox17.TabIndex = 14;
            // 
            // textBox28
            // 
            textBox28.Location = new Point(456, 513);
            textBox28.Margin = new Padding(3, 4, 3, 4);
            textBox28.Name = "textBox28";
            textBox28.ReadOnly = true;
            textBox28.Size = new Size(274, 27);
            textBox28.TabIndex = 14;
            // 
            // textBox27
            // 
            textBox27.Location = new Point(456, 475);
            textBox27.Margin = new Padding(3, 4, 3, 4);
            textBox27.Name = "textBox27";
            textBox27.ReadOnly = true;
            textBox27.Size = new Size(274, 27);
            textBox27.TabIndex = 14;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(456, 49);
            textBox16.Margin = new Padding(3, 4, 3, 4);
            textBox16.Name = "textBox16";
            textBox16.ReadOnly = true;
            textBox16.Size = new Size(274, 27);
            textBox16.TabIndex = 14;
            // 
            // textBox26
            // 
            textBox26.Location = new Point(456, 436);
            textBox26.Margin = new Padding(3, 4, 3, 4);
            textBox26.Name = "textBox26";
            textBox26.ReadOnly = true;
            textBox26.Size = new Size(274, 27);
            textBox26.TabIndex = 14;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(77, 629);
            textBox15.Margin = new Padding(3, 4, 3, 4);
            textBox15.Name = "textBox15";
            textBox15.ReadOnly = true;
            textBox15.Size = new Size(274, 27);
            textBox15.TabIndex = 14;
            // 
            // textBox25
            // 
            textBox25.Location = new Point(456, 397);
            textBox25.Margin = new Padding(3, 4, 3, 4);
            textBox25.Name = "textBox25";
            textBox25.ReadOnly = true;
            textBox25.Size = new Size(274, 27);
            textBox25.TabIndex = 14;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(77, 591);
            textBox14.Margin = new Padding(3, 4, 3, 4);
            textBox14.Name = "textBox14";
            textBox14.ReadOnly = true;
            textBox14.Size = new Size(274, 27);
            textBox14.TabIndex = 14;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(77, 552);
            textBox13.Margin = new Padding(3, 4, 3, 4);
            textBox13.Name = "textBox13";
            textBox13.ReadOnly = true;
            textBox13.Size = new Size(274, 27);
            textBox13.TabIndex = 14;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(77, 513);
            textBox12.Margin = new Padding(3, 4, 3, 4);
            textBox12.Name = "textBox12";
            textBox12.ReadOnly = true;
            textBox12.Size = new Size(274, 27);
            textBox12.TabIndex = 13;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(77, 475);
            textBox11.Margin = new Padding(3, 4, 3, 4);
            textBox11.Name = "textBox11";
            textBox11.ReadOnly = true;
            textBox11.Size = new Size(274, 27);
            textBox11.TabIndex = 12;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(77, 436);
            textBox10.Margin = new Padding(3, 4, 3, 4);
            textBox10.Name = "textBox10";
            textBox10.ReadOnly = true;
            textBox10.Size = new Size(274, 27);
            textBox10.TabIndex = 11;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(77, 397);
            textBox9.Margin = new Padding(3, 4, 3, 4);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(274, 27);
            textBox9.TabIndex = 10;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(77, 359);
            textBox8.Margin = new Padding(3, 4, 3, 4);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(274, 27);
            textBox8.TabIndex = 9;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(77, 320);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(274, 27);
            textBox7.TabIndex = 8;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(77, 281);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(274, 27);
            textBox6.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(77, 243);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(274, 27);
            textBox5.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(77, 204);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(274, 27);
            textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(77, 165);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(274, 27);
            textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(77, 127);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(274, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(77, 88);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(274, 27);
            textBox1.TabIndex = 2;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(16, 479);
            label13.Name = "label13";
            label13.Size = new Size(53, 20);
            label13.TabIndex = 1;
            label13.Text = "11: $t3";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(16, 440);
            label12.Name = "label12";
            label12.Size = new Size(53, 20);
            label12.TabIndex = 1;
            label12.Text = "10: $t2";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(16, 401);
            label11.Name = "label11";
            label11.Size = new Size(45, 20);
            label11.TabIndex = 1;
            label11.Text = "9: $t1";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 363);
            label10.Name = "label10";
            label10.Size = new Size(45, 20);
            label10.TabIndex = 1;
            label10.Text = "8: $t0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 324);
            label9.Name = "label9";
            label9.Size = new Size(48, 20);
            label9.TabIndex = 1;
            label9.Text = "7: $a3";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 285);
            label8.Name = "label8";
            label8.Size = new Size(48, 20);
            label8.TabIndex = 1;
            label8.Text = "6: $a2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 247);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 1;
            label7.Text = "5: $a1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 208);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 1;
            label6.Text = "4: $a0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 169);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 1;
            label5.Text = "3: $v1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 131);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 1;
            label4.Text = "2: $v0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 92);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 1;
            label3.Text = "1: $at";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(401, 324);
            label24.Name = "label24";
            label24.Size = new Size(54, 20);
            label24.TabIndex = 1;
            label24.Text = "23: $s7";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(401, 285);
            label23.Name = "label23";
            label23.Size = new Size(54, 20);
            label23.TabIndex = 1;
            label23.Text = "22: $s6";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(787, 56);
            label33.Name = "label33";
            label33.Size = new Size(26, 20);
            label33.TabIndex = 1;
            label33.Text = "PC";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(401, 247);
            label22.Name = "label22";
            label22.Size = new Size(54, 20);
            label22.TabIndex = 1;
            label22.Text = "21: $s5";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(401, 633);
            label32.Name = "label32";
            label32.Size = new Size(53, 20);
            label32.TabIndex = 1;
            label32.Text = "31: $ra";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(401, 208);
            label21.Name = "label21";
            label21.Size = new Size(54, 20);
            label21.TabIndex = 1;
            label21.Text = "20: $s4";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(401, 595);
            label31.Name = "label31";
            label31.Size = new Size(54, 20);
            label31.TabIndex = 1;
            label31.Text = "30: $fp";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(401, 169);
            label20.Name = "label20";
            label20.Size = new Size(54, 20);
            label20.TabIndex = 1;
            label20.Text = "19: $s3";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(401, 556);
            label30.Name = "label30";
            label30.Size = new Size(55, 20);
            label30.TabIndex = 1;
            label30.Text = "29: $sp";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(401, 131);
            label19.Name = "label19";
            label19.Size = new Size(54, 20);
            label19.TabIndex = 1;
            label19.Text = "18: $s2";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(401, 517);
            label29.Name = "label29";
            label29.Size = new Size(58, 20);
            label29.TabIndex = 1;
            label29.Text = "28: $gp";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(401, 92);
            label18.Name = "label18";
            label18.Size = new Size(54, 20);
            label18.TabIndex = 1;
            label18.Text = "17: $s1";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(401, 479);
            label28.Name = "label28";
            label28.Size = new Size(55, 20);
            label28.TabIndex = 1;
            label28.Text = "27: $k1";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(401, 53);
            label17.Name = "label17";
            label17.Size = new Size(54, 20);
            label17.TabIndex = 1;
            label17.Text = "16: $s0";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(401, 440);
            label27.Name = "label27";
            label27.Size = new Size(55, 20);
            label27.TabIndex = 1;
            label27.Text = "26: $k0";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(16, 633);
            label16.Name = "label16";
            label16.Size = new Size(53, 20);
            label16.TabIndex = 1;
            label16.Text = "15: $t7";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(401, 401);
            label26.Name = "label26";
            label26.Size = new Size(53, 20);
            label26.TabIndex = 1;
            label26.Text = "25: $t9";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(16, 595);
            label15.Name = "label15";
            label15.Size = new Size(53, 20);
            label15.TabIndex = 1;
            label15.Text = "14: $t6";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(401, 363);
            label25.Name = "label25";
            label25.Size = new Size(53, 20);
            label25.TabIndex = 1;
            label25.Text = "24: $t8";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(16, 556);
            label14.Name = "label14";
            label14.Size = new Size(53, 20);
            label14.TabIndex = 1;
            label14.Text = "13: $t5";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 517);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 1;
            label1.Text = "12: $t4";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 53);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 1;
            label2.Text = "0: $zero";
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Font = new Font("Segoe UI", 12F);
            registerLabel.Location = new Point(16, 12);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(90, 28);
            registerLabel.TabIndex = 0;
            registerLabel.Text = "Registers";
            // 
            // button1
            // 
            button1.AllowDrop = true;
            button1.Location = new Point(1869, 1048);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(146, 67);
            button1.TabIndex = 10;
            button1.Text = "Select File";
            button1.UseVisualStyleBackColor = true;
            button1.Click += fileButton_Click;
            // 
            // instructionTextBox
            // 
            instructionTextBox.Font = new Font("Segoe UI", 12F);
            instructionTextBox.Location = new Point(3, 88);
            instructionTextBox.Margin = new Padding(3, 4, 3, 4);
            instructionTextBox.Multiline = true;
            instructionTextBox.Name = "instructionTextBox";
            instructionTextBox.ReadOnly = true;
            instructionTextBox.RightToLeft = RightToLeft.No;
            instructionTextBox.ScrollBars = ScrollBars.Both;
            instructionTextBox.Size = new Size(430, 811);
            instructionTextBox.TabIndex = 11;
            instructionTextBox.WordWrap = false;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Segoe UI", 12F);
            label36.Location = new Point(3, 24);
            label36.Name = "label36";
            label36.Size = new Size(109, 28);
            label36.TabIndex = 12;
            label36.Text = "Instruction:";
            // 
            // panel1
            // 
            panel1.Controls.Add(label35);
            panel1.Controls.Add(label34);
            panel1.Controls.Add(instructionTextBox);
            panel1.Controls.Add(label36);
            panel1.Location = new Point(1136, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(438, 904);
            panel1.TabIndex = 13;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(106, 64);
            label35.Name = "label35";
            label35.Size = new Size(78, 20);
            label35.TabIndex = 14;
            label35.Text = "Instruction";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(3, 64);
            label34.Name = "label34";
            label34.Size = new Size(66, 20);
            label34.TabIndex = 13;
            label34.Text = "Location";
            // 
            // console
            // 
            console.Location = new Point(16, 49);
            console.Margin = new Padding(3, 4, 3, 4);
            console.Multiline = true;
            console.Name = "console";
            console.ReadOnly = true;
            console.ScrollBars = ScrollBars.Vertical;
            console.Size = new Size(1095, 344);
            console.TabIndex = 14;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Segoe UI", 12F);
            label37.Location = new Point(21, 17);
            label37.Name = "label37";
            label37.Size = new Size(86, 28);
            label37.TabIndex = 15;
            label37.Text = "Console:";
            // 
            // panel2
            // 
            panel2.Controls.Add(label37);
            panel2.Controls.Add(console);
            panel2.Location = new Point(14, 712);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1115, 399);
            panel2.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.Controls.Add(label38);
            panel3.Controls.Add(label39);
            panel3.Controls.Add(memoryTextBox);
            panel3.Controls.Add(label40);
            panel3.Location = new Point(1581, 16);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(438, 904);
            panel3.TabIndex = 17;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(106, 64);
            label38.Name = "label38";
            label38.Size = new Size(67, 20);
            label38.TabIndex = 14;
            label38.Text = "Contents";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(3, 64);
            label39.Name = "label39";
            label39.Size = new Size(66, 20);
            label39.TabIndex = 13;
            label39.Text = "Location";
            // 
            // memoryTextBox
            // 
            memoryTextBox.Font = new Font("Segoe UI", 12F);
            memoryTextBox.Location = new Point(3, 88);
            memoryTextBox.Margin = new Padding(3, 4, 3, 4);
            memoryTextBox.Multiline = true;
            memoryTextBox.Name = "memoryTextBox";
            memoryTextBox.ReadOnly = true;
            memoryTextBox.RightToLeft = RightToLeft.No;
            memoryTextBox.ScrollBars = ScrollBars.Both;
            memoryTextBox.Size = new Size(430, 811);
            memoryTextBox.TabIndex = 11;
            memoryTextBox.WordWrap = false;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Segoe UI", 12F);
            label40.Location = new Point(3, 24);
            label40.Name = "label40";
            label40.Size = new Size(90, 28);
            label40.TabIndex = 12;
            label40.Text = "Memory:";
            // 
            // runButton
            // 
            runButton.AccessibleDescription = "";
            runButton.AccessibleName = "";
            runButton.Location = new Point(1361, 928);
            runButton.Margin = new Padding(3, 4, 3, 4);
            runButton.Name = "runButton";
            runButton.Size = new Size(99, 60);
            runButton.TabIndex = 18;
            runButton.Text = "Run";
            runButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            runButton.UseVisualStyleBackColor = true;
            runButton.Click += runButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(runButton);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(registerPanel);
            Controls.Add(clearConsoleButton);
            Controls.Add(clearButton);
            Controls.Add(radioPanel);
            Controls.Add(setPCTextBox);
            Controls.Add(pcButton);
            Controls.Add(saveButton);
            Controls.Add(microButton);
            Controls.Add(stepButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Spirit Fireball MIPS Emulator";
            Load += Form1_Load;
            radioPanel.ResumeLayout(false);
            radioPanel.PerformLayout();
            registerPanel.ResumeLayout(false);
            registerPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        //Buttons
        private Button stepButton;
        private Button microButton;
        private Button saveButton;
        private Button pcButton;
        private Button button1;
        private Button clearButton;
        private Button clearConsoleButton;
      
        //RadioButtons
        private Panel radioPanel;
        private Label dataLabel;
        private RadioButton radioDecimal;
        private RadioButton radioHex;
        private RadioButton radioBinary;
      
        //TextBoxes
        private TextBox setPCTextBox;
        
        //Register Panel
        private Panel registerPanel;
        private Label registerLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label36;
        private TextBox PC;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox14;
        private TextBox textBox15;
        private TextBox textBox16;
        private TextBox textBox17;
        private TextBox textBox18;
        private TextBox textBox19;
        private TextBox textBox20;
        private TextBox textBox21;
        private TextBox textBox22;
        private TextBox textBox23;
        private TextBox textBox24;
        private TextBox textBox25;
        private TextBox textBox26;
        private TextBox textBox27;
        private TextBox textBox28;
        private TextBox textBox29;
        private TextBox textBox30;
        private TextBox textBox31;
        private TextBox textBox0;

        //Memory panel
        private Panel panel1;
        private TextBox instructionTextBox;

        //Console
        private Label label37;
        private Panel panel2;
        private TextBox console;
        private Label label35;
        private Label label34;
        private Panel panel3;
        private Label label38;
        private Label label39;
        private TextBox memoryTextBox;
        private Label label40;
        private Button runButton;
    }
}
