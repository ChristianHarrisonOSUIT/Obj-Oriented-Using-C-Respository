namespace Week10Application
{
    partial class frmRadioStar
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
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            checkBox1 = new CheckBox();
            button8 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(261, 395);
            button1.Name = "button1";
            button1.Size = new Size(134, 43);
            button1.TabIndex = 0;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(424, 395);
            button2.Name = "button2";
            button2.Size = new Size(134, 43);
            button2.TabIndex = 1;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Khaki;
            textBox1.Location = new Point(139, 43);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(256, 106);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Khaki;
            textBox2.Location = new Point(415, 43);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(256, 106);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(226, 25);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 4;
            label1.Text = "Left Operand";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(495, 25);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 5;
            label2.Text = "Right Operand";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(296, 349);
            label3.Name = "label3";
            label3.Size = new Size(197, 32);
            label3.TabIndex = 6;
            label3.Text = "Information Here";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(179, 276);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(458, 70);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Math Operations Available";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button7
            // 
            button7.Location = new Point(349, 33);
            button7.Name = "button7";
            button7.Size = new Size(109, 31);
            button7.TabIndex = 12;
            button7.Text = "Modulus";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(236, 33);
            button6.Name = "button6";
            button6.Size = new Size(109, 31);
            button6.TabIndex = 11;
            button6.Text = "Divide";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(121, 33);
            button5.Name = "button5";
            button5.Size = new Size(109, 31);
            button5.TabIndex = 10;
            button5.Text = "Multiply";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(6, 33);
            button4.Name = "button4";
            button4.Size = new Size(109, 31);
            button4.TabIndex = 9;
            button4.Text = "Subtract";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(358, 239);
            button3.Name = "button3";
            button3.Size = new Size(109, 31);
            button3.TabIndex = 8;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(576, 349);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(169, 19);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Turn On/Off Verbose Mode";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            button8.Location = new Point(296, 174);
            button8.Name = "button8";
            button8.Size = new Size(233, 31);
            button8.TabIndex = 10;
            button8.Text = "Calculate";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // frmRadioStar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(button8);
            Controls.Add(checkBox1);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "frmRadioStar";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Button button4;
        private Button button3;
        private Button button5;
        private Button button7;
        private Button button6;
        private CheckBox checkBox1;
        private Button button8;
    }
}