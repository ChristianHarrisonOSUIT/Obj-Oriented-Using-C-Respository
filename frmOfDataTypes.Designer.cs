namespace Module4Project
{
    partial class frmOfDataTypes
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
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(102, 69);
            button1.Name = "button1";
            button1.Size = new Size(109, 34);
            button1.TabIndex = 0;
            button1.Text = "byte";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(102, 152);
            button2.Name = "button2";
            button2.Size = new Size(109, 34);
            button2.TabIndex = 1;
            button2.Text = "short";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(102, 240);
            button3.Name = "button3";
            button3.Size = new Size(109, 34);
            button3.TabIndex = 2;
            button3.Text = "int";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(102, 324);
            button4.Name = "button4";
            button4.Size = new Size(109, 34);
            button4.TabIndex = 3;
            button4.Text = "long";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(539, 69);
            button5.Name = "button5";
            button5.Size = new Size(109, 34);
            button5.TabIndex = 4;
            button5.Text = "float";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(539, 152);
            button6.Name = "button6";
            button6.Size = new Size(109, 34);
            button6.TabIndex = 5;
            button6.Text = "double";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(539, 240);
            button7.Name = "button7";
            button7.Size = new Size(109, 34);
            button7.TabIndex = 6;
            button7.Text = "decimal";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(539, 324);
            button8.Name = "button8";
            button8.Size = new Size(109, 34);
            button8.TabIndex = 7;
            button8.Text = "float";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(327, 152);
            button9.Name = "button9";
            button9.Size = new Size(109, 34);
            button9.TabIndex = 8;
            button9.Text = "pow";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(327, 240);
            button10.Name = "button10";
            button10.Size = new Size(109, 34);
            button10.TabIndex = 9;
            button10.Text = "round";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(327, 324);
            button11.Name = "button11";
            button11.Size = new Size(109, 34);
            button11.TabIndex = 10;
            button11.Text = "sqrt";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.BackColor = Color.Brown;
            button12.Location = new Point(244, 404);
            button12.Name = "button12";
            button12.Size = new Size(109, 34);
            button12.TabIndex = 11;
            button12.Text = "clear";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.Brown;
            button13.Location = new Point(403, 404);
            button13.Name = "button13";
            button13.Size = new Size(109, 34);
            button13.TabIndex = 12;
            button13.Text = "exit";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(273, 20);
            label1.Name = "label1";
            label1.Size = new Size(239, 47);
            label1.TabIndex = 13;
            label1.Text = "Click A Button";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(360, 83);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 14;
            label2.Text = "Blank";
            label2.Click += label2_Click;
            // 
            // frmOfDataTypes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "frmOfDataTypes";
            Text = "Week 4 - Data Types";
            Load += frmOfDataTypes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Label label1;
        private Label label2;
    }
}