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
            runButton = new Button();
            saveButton = new Button();
            pcButton = new Button();
            setPCTextBox = new TextBox();
            radioPanel = new Panel();
            dataLabel = new Label();
            radioDecimal = new RadioButton();
            radioHex = new RadioButton();
            radioBinary = new RadioButton();
            clearButton = new Button();
            saveStateButton = new Button();
            registerPanel = new Panel();
            textBox24 = new TextBox();
            LO = new TextBox();
            textBox23 = new TextBox();
            HI = new TextBox();
            textBox22 = new TextBox();
            PC = new TextBox();
            textBox21 = new TextBox();
            textBox32 = new TextBox();
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
            r1TextBox = new TextBox();
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
            label35 = new Label();
            label24 = new Label();
            label34 = new Label();
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
            radioPanel.SuspendLayout();
            registerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // stepButton
            // 
            stepButton.AccessibleDescription = "";
            stepButton.AccessibleName = "";
            stepButton.Location = new Point(12, 420);
            stepButton.Name = "stepButton";
            stepButton.Size = new Size(87, 45);
            stepButton.TabIndex = 0;
            stepButton.Text = "Step 1";
            stepButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            stepButton.UseVisualStyleBackColor = true;
            stepButton.Click += button1_Click;
            // 
            // microButton
            // 
            microButton.Location = new Point(105, 420);
            microButton.Name = "microButton";
            microButton.Size = new Size(87, 45);
            microButton.TabIndex = 1;
            microButton.Text = "Micro Step 1";
            microButton.UseVisualStyleBackColor = true;
            // 
            // runButton
            // 
            runButton.Location = new Point(198, 420);
            runButton.Name = "runButton";
            runButton.Size = new Size(87, 45);
            runButton.TabIndex = 2;
            runButton.Text = "Run until stop";
            runButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(12, 471);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(87, 45);
            saveButton.TabIndex = 3;
            saveButton.Text = "Save current values";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // pcButton
            // 
            pcButton.Location = new Point(12, 522);
            pcButton.Name = "pcButton";
            pcButton.Size = new Size(87, 26);
            pcButton.TabIndex = 4;
            pcButton.Text = "Set PC Value";
            pcButton.UseVisualStyleBackColor = true;
            pcButton.Click += pcButton_Click;
            // 
            // setPCTextBox
            // 
            setPCTextBox.Location = new Point(105, 525);
            setPCTextBox.Name = "setPCTextBox";
            setPCTextBox.Size = new Size(180, 23);
            setPCTextBox.TabIndex = 5;
            setPCTextBox.TextChanged += textBox1_TextChanged;
            // 
            // radioPanel
            // 
            radioPanel.BackColor = SystemColors.ButtonHighlight;
            radioPanel.Controls.Add(dataLabel);
            radioPanel.Controls.Add(radioDecimal);
            radioPanel.Controls.Add(radioHex);
            radioPanel.Controls.Add(radioBinary);
            radioPanel.Location = new Point(291, 420);
            radioPanel.Name = "radioPanel";
            radioPanel.Size = new Size(116, 128);
            radioPanel.TabIndex = 6;
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.BackColor = SystemColors.ButtonHighlight;
            dataLabel.Font = new Font("Segoe UI", 12F);
            dataLabel.Location = new Point(10, 10);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new Size(76, 21);
            dataLabel.TabIndex = 7;
            dataLabel.Text = "Data type";
            // 
            // radioDecimal
            // 
            radioDecimal.AutoSize = true;
            radioDecimal.Location = new Point(10, 86);
            radioDecimal.Name = "radioDecimal";
            radioDecimal.Size = new Size(68, 19);
            radioDecimal.TabIndex = 2;
            radioDecimal.TabStop = true;
            radioDecimal.Text = "Decimal";
            radioDecimal.UseVisualStyleBackColor = true;
            radioDecimal.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioHex
            // 
            radioHex.AutoSize = true;
            radioHex.Location = new Point(10, 61);
            radioHex.Name = "radioHex";
            radioHex.Size = new Size(46, 19);
            radioHex.TabIndex = 1;
            radioHex.TabStop = true;
            radioHex.Text = "Hex";
            radioHex.UseVisualStyleBackColor = true;
            // 
            // radioBinary
            // 
            radioBinary.AutoSize = true;
            radioBinary.Location = new Point(10, 36);
            radioBinary.Name = "radioBinary";
            radioBinary.Size = new Size(58, 19);
            radioBinary.TabIndex = 0;
            radioBinary.TabStop = true;
            radioBinary.Text = "Binary";
            radioBinary.UseVisualStyleBackColor = true;
            radioBinary.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(105, 471);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(87, 45);
            clearButton.TabIndex = 7;
            clearButton.Text = "Clear cache";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += button6_Click;
            // 
            // saveStateButton
            // 
            saveStateButton.Location = new Point(198, 471);
            saveStateButton.Name = "saveStateButton";
            saveStateButton.Size = new Size(87, 45);
            saveStateButton.TabIndex = 8;
            saveStateButton.Text = "Save state";
            saveStateButton.UseVisualStyleBackColor = true;
            // 
            // registerPanel
            // 
            registerPanel.Controls.Add(textBox24);
            registerPanel.Controls.Add(LO);
            registerPanel.Controls.Add(textBox23);
            registerPanel.Controls.Add(HI);
            registerPanel.Controls.Add(textBox22);
            registerPanel.Controls.Add(PC);
            registerPanel.Controls.Add(textBox21);
            registerPanel.Controls.Add(textBox32);
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
            registerPanel.Controls.Add(r1TextBox);
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
            registerPanel.Controls.Add(label35);
            registerPanel.Controls.Add(label24);
            registerPanel.Controls.Add(label34);
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
            registerPanel.Location = new Point(12, 12);
            registerPanel.Name = "registerPanel";
            registerPanel.Size = new Size(850, 402);
            registerPanel.TabIndex = 9;
            // 
            // textBox24
            // 
            textBox24.Location = new Point(312, 356);
            textBox24.Name = "textBox24";
            textBox24.Size = new Size(240, 23);
            textBox24.TabIndex = 14;
            textBox24.TextChanged += textBox13_TextChanged;
            // 
            // LO
            // 
            LO.Location = new Point(594, 356);
            LO.Name = "LO";
            LO.Size = new Size(240, 23);
            LO.TabIndex = 14;
            LO.TextChanged += textBox13_TextChanged;
            // 
            // textBox23
            // 
            textBox23.Location = new Point(312, 327);
            textBox23.Name = "textBox23";
            textBox23.Size = new Size(240, 23);
            textBox23.TabIndex = 14;
            textBox23.TextChanged += textBox13_TextChanged;
            // 
            // HI
            // 
            HI.Location = new Point(594, 327);
            HI.Name = "HI";
            HI.Size = new Size(240, 23);
            HI.TabIndex = 14;
            HI.TextChanged += textBox13_TextChanged;
            // 
            // textBox22
            // 
            textBox22.Location = new Point(312, 298);
            textBox22.Name = "textBox22";
            textBox22.Size = new Size(240, 23);
            textBox22.TabIndex = 14;
            textBox22.TextChanged += textBox13_TextChanged;
            // 
            // PC
            // 
            PC.Location = new Point(594, 298);
            PC.Name = "PC";
            PC.Size = new Size(240, 23);
            PC.TabIndex = 14;
            PC.TextChanged += textBox13_TextChanged;
            // 
            // textBox21
            // 
            textBox21.Location = new Point(312, 269);
            textBox21.Name = "textBox21";
            textBox21.Size = new Size(240, 23);
            textBox21.TabIndex = 14;
            textBox21.TextChanged += textBox13_TextChanged;
            // 
            // textBox32
            // 
            textBox32.Location = new Point(594, 240);
            textBox32.Name = "textBox32";
            textBox32.Size = new Size(240, 23);
            textBox32.TabIndex = 14;
            textBox32.TextChanged += textBox13_TextChanged;
            // 
            // textBox20
            // 
            textBox20.Location = new Point(312, 240);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(240, 23);
            textBox20.TabIndex = 14;
            textBox20.TextChanged += textBox13_TextChanged;
            // 
            // textBox31
            // 
            textBox31.Location = new Point(594, 211);
            textBox31.Name = "textBox31";
            textBox31.Size = new Size(240, 23);
            textBox31.TabIndex = 14;
            textBox31.TextChanged += textBox13_TextChanged;
            // 
            // textBox19
            // 
            textBox19.Location = new Point(312, 211);
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(240, 23);
            textBox19.TabIndex = 14;
            textBox19.TextChanged += textBox13_TextChanged;
            // 
            // textBox30
            // 
            textBox30.Location = new Point(594, 182);
            textBox30.Name = "textBox30";
            textBox30.Size = new Size(240, 23);
            textBox30.TabIndex = 14;
            textBox30.TextChanged += textBox13_TextChanged;
            // 
            // textBox18
            // 
            textBox18.Location = new Point(312, 182);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(240, 23);
            textBox18.TabIndex = 14;
            textBox18.TextChanged += textBox13_TextChanged;
            // 
            // textBox29
            // 
            textBox29.Location = new Point(594, 153);
            textBox29.Name = "textBox29";
            textBox29.Size = new Size(240, 23);
            textBox29.TabIndex = 14;
            textBox29.TextChanged += textBox13_TextChanged;
            // 
            // textBox17
            // 
            textBox17.Location = new Point(312, 153);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(240, 23);
            textBox17.TabIndex = 14;
            textBox17.TextChanged += textBox13_TextChanged;
            // 
            // textBox28
            // 
            textBox28.Location = new Point(594, 124);
            textBox28.Name = "textBox28";
            textBox28.Size = new Size(240, 23);
            textBox28.TabIndex = 14;
            textBox28.TextChanged += textBox13_TextChanged;
            // 
            // textBox27
            // 
            textBox27.Location = new Point(594, 95);
            textBox27.Name = "textBox27";
            textBox27.Size = new Size(240, 23);
            textBox27.TabIndex = 14;
            textBox27.TextChanged += textBox13_TextChanged;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(312, 124);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(240, 23);
            textBox16.TabIndex = 14;
            textBox16.TextChanged += textBox13_TextChanged;
            // 
            // textBox26
            // 
            textBox26.Location = new Point(594, 66);
            textBox26.Name = "textBox26";
            textBox26.Size = new Size(240, 23);
            textBox26.TabIndex = 14;
            textBox26.TextChanged += textBox13_TextChanged;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(312, 95);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(240, 23);
            textBox15.TabIndex = 14;
            textBox15.TextChanged += textBox13_TextChanged;
            // 
            // textBox25
            // 
            textBox25.Location = new Point(594, 37);
            textBox25.Name = "textBox25";
            textBox25.Size = new Size(240, 23);
            textBox25.TabIndex = 14;
            textBox25.TextChanged += textBox13_TextChanged;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(312, 66);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(240, 23);
            textBox14.TabIndex = 14;
            textBox14.TextChanged += textBox13_TextChanged;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(312, 37);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(240, 23);
            textBox13.TabIndex = 14;
            textBox13.TextChanged += textBox13_TextChanged;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(33, 356);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(240, 23);
            textBox12.TabIndex = 13;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(33, 327);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(240, 23);
            textBox11.TabIndex = 12;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(33, 298);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(240, 23);
            textBox10.TabIndex = 11;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(33, 269);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(240, 23);
            textBox9.TabIndex = 10;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(33, 240);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(240, 23);
            textBox8.TabIndex = 9;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(33, 211);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(240, 23);
            textBox7.TabIndex = 8;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(33, 182);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(240, 23);
            textBox6.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(33, 153);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(240, 23);
            textBox5.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(33, 124);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(240, 23);
            textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(33, 95);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(240, 23);
            textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(33, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(240, 23);
            textBox2.TabIndex = 3;
            // 
            // r1TextBox
            // 
            r1TextBox.Location = new Point(33, 37);
            r1TextBox.Name = "r1TextBox";
            r1TextBox.Size = new Size(240, 23);
            r1TextBox.TabIndex = 2;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(14, 359);
            label13.Name = "label13";
            label13.Size = new Size(19, 15);
            label13.TabIndex = 1;
            label13.Text = "12";
            label13.Click += label2_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(14, 330);
            label12.Name = "label12";
            label12.Size = new Size(19, 15);
            label12.TabIndex = 1;
            label12.Text = "11";
            label12.Click += label2_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(14, 301);
            label11.Name = "label11";
            label11.Size = new Size(19, 15);
            label11.TabIndex = 1;
            label11.Text = "10";
            label11.Click += label2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 272);
            label10.Name = "label10";
            label10.Size = new Size(13, 15);
            label10.TabIndex = 1;
            label10.Text = "9";
            label10.Click += label2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 243);
            label9.Name = "label9";
            label9.Size = new Size(13, 15);
            label9.TabIndex = 1;
            label9.Text = "8";
            label9.Click += label2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 214);
            label8.Name = "label8";
            label8.Size = new Size(13, 15);
            label8.TabIndex = 1;
            label8.Text = "7";
            label8.Click += label2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 185);
            label7.Name = "label7";
            label7.Size = new Size(13, 15);
            label7.TabIndex = 1;
            label7.Text = "6";
            label7.Click += label2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 156);
            label6.Name = "label6";
            label6.Size = new Size(13, 15);
            label6.TabIndex = 1;
            label6.Text = "5";
            label6.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 127);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 1;
            label5.Text = "4";
            label5.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 98);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 1;
            label4.Text = "3";
            label4.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 69);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 1;
            label3.Text = "2";
            label3.Click += label2_Click;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(575, 359);
            label35.Name = "label35";
            label35.Size = new Size(22, 15);
            label35.TabIndex = 1;
            label35.Text = "LO";
            label35.Click += label2_Click;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(293, 359);
            label24.Name = "label24";
            label24.Size = new Size(19, 15);
            label24.TabIndex = 1;
            label24.Text = "24";
            label24.Click += label2_Click;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(575, 330);
            label34.Name = "label34";
            label34.Size = new Size(19, 15);
            label34.TabIndex = 1;
            label34.Text = "HI";
            label34.Click += label2_Click;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(293, 330);
            label23.Name = "label23";
            label23.Size = new Size(19, 15);
            label23.TabIndex = 1;
            label23.Text = "23";
            label23.Click += label2_Click;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(575, 301);
            label33.Name = "label33";
            label33.Size = new Size(22, 15);
            label33.TabIndex = 1;
            label33.Text = "PC";
            label33.Click += label2_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(293, 301);
            label22.Name = "label22";
            label22.Size = new Size(19, 15);
            label22.TabIndex = 1;
            label22.Text = "22";
            label22.Click += label2_Click;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(575, 243);
            label32.Name = "label32";
            label32.Size = new Size(19, 15);
            label32.TabIndex = 1;
            label32.Text = "32";
            label32.Click += label2_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(293, 272);
            label21.Name = "label21";
            label21.Size = new Size(19, 15);
            label21.TabIndex = 1;
            label21.Text = "21";
            label21.Click += label2_Click;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(575, 214);
            label31.Name = "label31";
            label31.Size = new Size(19, 15);
            label31.TabIndex = 1;
            label31.Text = "31";
            label31.Click += label2_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(293, 243);
            label20.Name = "label20";
            label20.Size = new Size(19, 15);
            label20.TabIndex = 1;
            label20.Text = "20";
            label20.Click += label2_Click;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(575, 185);
            label30.Name = "label30";
            label30.Size = new Size(19, 15);
            label30.TabIndex = 1;
            label30.Text = "30";
            label30.Click += label2_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(293, 214);
            label19.Name = "label19";
            label19.Size = new Size(19, 15);
            label19.TabIndex = 1;
            label19.Text = "19";
            label19.Click += label2_Click;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(575, 156);
            label29.Name = "label29";
            label29.Size = new Size(19, 15);
            label29.TabIndex = 1;
            label29.Text = "29";
            label29.Click += label2_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(293, 185);
            label18.Name = "label18";
            label18.Size = new Size(19, 15);
            label18.TabIndex = 1;
            label18.Text = "18";
            label18.Click += label2_Click;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(575, 127);
            label28.Name = "label28";
            label28.Size = new Size(19, 15);
            label28.TabIndex = 1;
            label28.Text = "28";
            label28.Click += label2_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(293, 156);
            label17.Name = "label17";
            label17.Size = new Size(19, 15);
            label17.TabIndex = 1;
            label17.Text = "17";
            label17.Click += label2_Click;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(575, 98);
            label27.Name = "label27";
            label27.Size = new Size(19, 15);
            label27.TabIndex = 1;
            label27.Text = "27";
            label27.Click += label2_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(293, 127);
            label16.Name = "label16";
            label16.Size = new Size(19, 15);
            label16.TabIndex = 1;
            label16.Text = "16";
            label16.Click += label2_Click;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(575, 69);
            label26.Name = "label26";
            label26.Size = new Size(19, 15);
            label26.TabIndex = 1;
            label26.Text = "26";
            label26.Click += label2_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(293, 98);
            label15.Name = "label15";
            label15.Size = new Size(19, 15);
            label15.TabIndex = 1;
            label15.Text = "15";
            label15.Click += label2_Click;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(575, 40);
            label25.Name = "label25";
            label25.Size = new Size(19, 15);
            label25.TabIndex = 1;
            label25.Text = "25";
            label25.Click += label2_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(293, 69);
            label14.Name = "label14";
            label14.Size = new Size(19, 15);
            label14.TabIndex = 1;
            label14.Text = "14";
            label14.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(293, 40);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 1;
            label1.Text = "13";
            label1.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 40);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 1;
            label2.Text = "1";
            label2.Click += label2_Click;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Font = new Font("Segoe UI", 12F);
            registerLabel.Location = new Point(14, 9);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(74, 21);
            registerLabel.TabIndex = 0;
            registerLabel.Text = "Registers";
            registerLabel.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(734, 492);
            button1.Name = "button1";
            button1.Size = new Size(128, 50);
            button1.TabIndex = 10;
            button1.Text = "Select File";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 554);
            Controls.Add(button1);
            Controls.Add(registerPanel);
            Controls.Add(saveStateButton);
            Controls.Add(clearButton);
            Controls.Add(radioPanel);
            Controls.Add(setPCTextBox);
            Controls.Add(pcButton);
            Controls.Add(saveButton);
            Controls.Add(runButton);
            Controls.Add(microButton);
            Controls.Add(stepButton);
            Name = "Form1";
            Text = "Spirit Fireball MIPS Emulator";
            Load += Form1_Load;
            radioPanel.ResumeLayout(false);
            radioPanel.PerformLayout();
            registerPanel.ResumeLayout(false);
            registerPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button stepButton;
        private Button microButton;
        private Button runButton;
        private Button saveButton;
        private Button pcButton;
        private TextBox setPCTextBox;
        private Panel radioPanel;
        private RadioButton radioDecimal;
        private RadioButton radioHex;
        private RadioButton radioBinary;
        private Label dataLabel;
        private Button clearButton;
        private Button saveStateButton;
        private Panel registerPanel;
        private Label registerLabel;
        private Label label2;
        private Button button1;
        private TextBox textBox13;
        private TextBox textBox12;
        private TextBox textBox11;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox r1TextBox;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox24;
        private TextBox LO;
        private TextBox textBox23;
        private TextBox HI;
        private TextBox textBox22;
        private TextBox PC;
        private TextBox textBox21;
        private TextBox textBox32;
        private TextBox textBox20;
        private TextBox textBox31;
        private TextBox textBox19;
        private TextBox textBox30;
        private TextBox textBox18;
        private TextBox textBox29;
        private TextBox textBox17;
        private TextBox textBox28;
        private TextBox textBox27;
        private TextBox textBox16;
        private TextBox textBox26;
        private TextBox textBox15;
        private TextBox textBox25;
        private TextBox textBox14;
        private Label label35;
        private Label label24;
        private Label label34;
        private Label label23;
        private Label label33;
        private Label label22;
        private Label label32;
        private Label label21;
        private Label label31;
        private Label label20;
        private Label label30;
        private Label label19;
        private Label label29;
        private Label label18;
        private Label label28;
        private Label label17;
        private Label label27;
        private Label label16;
        private Label label26;
        private Label label15;
        private Label label25;
        private Label label14;
        private Label label1;
    }
}
