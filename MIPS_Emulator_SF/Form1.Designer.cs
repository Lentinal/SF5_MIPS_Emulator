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
            radioPanel.SuspendLayout();
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
            registerPanel.Location = new Point(12, 12);
            registerPanel.Name = "registerPanel";
            registerPanel.Size = new Size(755, 402);
            registerPanel.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 554);
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
    }
}
