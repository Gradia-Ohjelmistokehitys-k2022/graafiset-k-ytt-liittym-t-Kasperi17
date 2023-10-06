namespace Tehtävä_7
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label8 = new Label();
            numerotextBox2 = new TextBox();
            indeksitextBox3 = new TextBox();
            tallennuspaikantextBox4 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(178, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 21);
            label1.TabIndex = 0;
            label1.Text = "Taulokon luonti";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 48);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 1;
            label2.Text = "Taulukon koko";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(166, 45);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(106, 23);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 116);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 15);
            label3.TabIndex = 3;
            label3.Text = "Talletettava numero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 145);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(131, 15);
            label4.TabIndex = 4;
            label4.Text = "Tallennuspaikan indeksi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 212);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(131, 15);
            label5.TabIndex = 5;
            label5.Text = "Tallennuspaikan indeksi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(197, 84);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 6;
            label6.Text = "Tallennus";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(211, 172);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(43, 20);
            label7.TabIndex = 7;
            label7.Text = "Haku";
            // 
            // button1
            // 
            button1.Location = new Point(290, 51);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(78, 20);
            button1.TabIndex = 8;
            button1.Text = "Luo taulukko";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(290, 212);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(78, 20);
            button2.TabIndex = 9;
            button2.Text = "Hae";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(290, 130);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(78, 20);
            button3.TabIndex = 10;
            button3.Text = "Talleta";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(206, 235);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(49, 22);
            label8.TabIndex = 11;
            label8.Text = "label8";
            // 
            // numerotextBox2
            // 
            numerotextBox2.Location = new Point(166, 108);
            numerotextBox2.Name = "numerotextBox2";
            numerotextBox2.Size = new Size(100, 23);
            numerotextBox2.TabIndex = 12;
            numerotextBox2.TextChanged += numerotextBox2_TextChanged;
            // 
            // indeksitextBox3
            // 
            indeksitextBox3.Location = new Point(166, 142);
            indeksitextBox3.Name = "indeksitextBox3";
            indeksitextBox3.Size = new Size(100, 23);
            indeksitextBox3.TabIndex = 13;
            indeksitextBox3.TextChanged += indeksitextBox3_TextChanged;
            // 
            // tallennuspaikantextBox4
            // 
            tallennuspaikantextBox4.Location = new Point(166, 209);
            tallennuspaikantextBox4.Name = "tallennuspaikantextBox4";
            tallennuspaikantextBox4.Size = new Size(100, 23);
            tallennuspaikantextBox4.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(tallennuspaikantextBox4);
            Controls.Add(indeksitextBox3);
            Controls.Add(numerotextBox2);
            Controls.Add(label8);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label8;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox tallennuspaikantextBox4;
        private TextBox numerotextBox2;
        private TextBox indeksitextBox3;
    }
}