namespace LabNumber2
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
            button1 = new Button();
            button4 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            label2 = new Label();
            button7 = new Button();
            button8 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("TerminaW05-Bold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(21, 29);
            button1.Name = "button1";
            button1.Size = new Size(208, 38);
            button1.TabIndex = 0;
            button1.Text = "Show Modulus";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Font = new Font("TerminaW05-Bold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(277, 29);
            button4.Name = "button4";
            button4.Size = new Size(208, 38);
            button4.TabIndex = 3;
            button4.Text = "Show Factorial";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Font = new Font("TerminaW05-Bold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(535, 29);
            button2.Name = "button2";
            button2.Size = new Size(208, 38);
            button2.TabIndex = 4;
            button2.Text = "Show Fibonacci";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("TerminaW05-Bold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(21, 161);
            button3.Name = "button3";
            button3.Size = new Size(208, 38);
            button3.TabIndex = 5;
            button3.Text = "Do Modulus";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Font = new Font("TerminaW05-Bold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(277, 161);
            button5.Name = "button5";
            button5.Size = new Size(208, 38);
            button5.TabIndex = 6;
            button5.Text = "Do Factorial";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("TerminaW05-Bold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(535, 161);
            button6.Name = "button6";
            button6.Size = new Size(208, 38);
            button6.TabIndex = 7;
            button6.Text = "Do Fibonacci";
            button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("TerminaW05-Bold", 17.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(311, 244);
            label1.Name = "label1";
            label1.Size = new Size(130, 36);
            label1.TabIndex = 8;
            label1.Text = "Results";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("TerminaW05-Bold", 17.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(254, 280);
            label2.Name = "label2";
            label2.Size = new Size(252, 36);
            label2.TabIndex = 9;
            label2.Text = "Calculated here";
            label2.Click += label2_Click_1;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.AppWorkspace;
            button7.Font = new Font("TerminaW05-Bold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ControlText;
            button7.Location = new Point(149, 508);
            button7.Name = "button7";
            button7.Size = new Size(208, 38);
            button7.TabIndex = 10;
            button7.Text = "Clear";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.AppWorkspace;
            button8.Font = new Font("TerminaW05-Bold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = SystemColors.ControlText;
            button8.Location = new Point(392, 508);
            button8.Name = "button8";
            button8.Size = new Size(208, 38);
            button8.TabIndex = 11;
            button8.Text = "Exit";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 23);
            textBox1.TabIndex = 12;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(277, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(208, 23);
            textBox2.TabIndex = 13;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(535, 102);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(208, 23);
            textBox3.TabIndex = 14;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(778, 599);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button4;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button6;
        private Label label1;
        private Label label2;
        private Button button7;
        private Button button8;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}