﻿namespace Week2_HarrisonChristian_Project
{
    partial class frmSummer2023
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(167, 40);
            label1.Name = "label1";
            label1.Size = new Size(271, 41);
            label1.TabIndex = 0;
            label1.Text = "Enter Text Here";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(167, 100);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Size = new Size(467, 228);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 255);
            button1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(27, 356);
            button1.Name = "button1";
            button1.Size = new Size(158, 23);
            button1.TabIndex = 2;
            button1.Text = "Wipe Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(613, 356);
            button2.Name = "button2";
            button2.Size = new Size(158, 23);
            button2.TabIndex = 3;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(414, 356);
            button3.Name = "button3";
            button3.Size = new Size(158, 23);
            button3.TabIndex = 4;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 192, 255);
            button4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(219, 356);
            button4.Name = "button4";
            button4.Size = new Size(158, 23);
            button4.TabIndex = 5;
            button4.Text = "Save";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Location = new Point(426, 11);
            label2.Name = "label2";
            label2.Size = new Size(208, 86);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // frmSummer2023
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "frmSummer2023";
            Text = "Summer 2023";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
    }
}