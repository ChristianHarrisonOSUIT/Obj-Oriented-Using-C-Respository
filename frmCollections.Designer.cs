namespace Week8App
{
    partial class frmCollections
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
            textBox2 = new TextBox();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(184, 513);
            button1.Margin = new Padding(6, 4, 6, 4);
            button1.Name = "button1";
            button1.Size = new Size(212, 71);
            button1.TabIndex = 0;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(408, 513);
            button2.Margin = new Padding(6, 4, 6, 4);
            button2.Name = "button2";
            button2.Size = new Size(212, 71);
            button2.TabIndex = 1;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 134);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 450);
            textBox2.TabIndex = 3;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 109);
            label1.Name = "label1";
            label1.Size = new Size(112, 22);
            label1.TabIndex = 4;
            label1.Text = "Collection";
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(184, 211);
            button3.Margin = new Padding(6, 4, 6, 4);
            button3.Name = "button3";
            button3.Size = new Size(212, 71);
            button3.TabIndex = 5;
            button3.Text = "Add Number";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(421, 211);
            button4.Margin = new Padding(6, 4, 6, 4);
            button4.Name = "button4";
            button4.Size = new Size(212, 71);
            button4.TabIndex = 6;
            button4.Text = "Show Statistics";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(183, 303);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(437, 184);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(651, 134);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 450);
            textBox1.TabIndex = 8;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(682, 109);
            label2.Name = "label2";
            label2.Size = new Size(105, 22);
            label2.TabIndex = 9;
            label2.Text = "Statistics";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(212, 52);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(408, 142);
            textBox3.TabIndex = 10;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(337, 27);
            label3.Name = "label3";
            label3.Size = new Size(151, 22);
            label3.TabIndex = 11;
            label3.Text = "Enter Number";
            label3.Click += label3_Click;
            // 
            // frmCollections
            // 
            AutoScaleDimensions = new SizeF(13F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(845, 607);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Sequel Sans Black Body", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6, 4, 6, 4);
            Name = "frmCollections";
            Text = "Statistics and Collections";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private Label label1;
        private Button button3;
        private Button button4;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
    }
}