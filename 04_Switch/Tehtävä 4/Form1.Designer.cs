namespace Tehtävä_4
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
            Valintabutton1 = new Button();
            Valintabutton2 = new Button();
            Valintabutton3 = new Button();
            Valintabutton4 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // Valintabutton1
            // 
            Valintabutton1.Location = new Point(8, 47);
            Valintabutton1.Margin = new Padding(2);
            Valintabutton1.Name = "Valintabutton1";
            Valintabutton1.Size = new Size(105, 25);
            Valintabutton1.TabIndex = 0;
            Valintabutton1.Text = "Valinta 1";
            Valintabutton1.UseVisualStyleBackColor = true;
            Valintabutton1.Click += Valintabutton1_Click;
            // 
            // Valintabutton2
            // 
            Valintabutton2.Location = new Point(8, 85);
            Valintabutton2.Margin = new Padding(2);
            Valintabutton2.Name = "Valintabutton2";
            Valintabutton2.Size = new Size(105, 25);
            Valintabutton2.TabIndex = 1;
            Valintabutton2.Text = "Valinta 2";
            Valintabutton2.UseVisualStyleBackColor = true;
            Valintabutton2.Click += Valintabutton1_Click;
            // 
            // Valintabutton3
            // 
            Valintabutton3.Location = new Point(8, 122);
            Valintabutton3.Margin = new Padding(2);
            Valintabutton3.Name = "Valintabutton3";
            Valintabutton3.Size = new Size(105, 25);
            Valintabutton3.TabIndex = 2;
            Valintabutton3.Text = "Valinta 3";
            Valintabutton3.UseVisualStyleBackColor = true;
            Valintabutton3.Click += Valintabutton1_Click;
            // 
            // Valintabutton4
            // 
            Valintabutton4.Location = new Point(8, 159);
            Valintabutton4.Margin = new Padding(2);
            Valintabutton4.Name = "Valintabutton4";
            Valintabutton4.Size = new Size(105, 25);
            Valintabutton4.TabIndex = 3;
            Valintabutton4.Text = "Valinta 4";
            Valintabutton4.UseVisualStyleBackColor = true;
            Valintabutton4.Click += Valintabutton1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(2, 13);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(558, 23);
            textBox1.TabIndex = 4;
            textBox1.Text = "File";
            // 
            // Form1
            // 
            AccessibleName = "False";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(textBox1);
            Controls.Add(Valintabutton4);
            Controls.Add(Valintabutton3);
            Controls.Add(Valintabutton2);
            Controls.Add(Valintabutton1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Pääformi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Valintabutton1;
        private Button Valintabutton2;
        private Button Valintabutton3;
        private Button Valintabutton4;
        private TextBox textBox1;
    }
}