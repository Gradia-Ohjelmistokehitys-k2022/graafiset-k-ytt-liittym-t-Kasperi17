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
            Valintabutton1.Location = new Point(12, 79);
            Valintabutton1.Name = "Valintabutton1";
            Valintabutton1.Size = new Size(150, 41);
            Valintabutton1.TabIndex = 0;
            Valintabutton1.Text = "Valinta 1";
            Valintabutton1.UseVisualStyleBackColor = true;
            Valintabutton1.Click += Valintabutton1_Click;
            // 
            // Valintabutton2
            // 
            Valintabutton2.Location = new Point(12, 141);
            Valintabutton2.Name = "Valintabutton2";
            Valintabutton2.Size = new Size(150, 41);
            Valintabutton2.TabIndex = 1;
            Valintabutton2.Text = "Valinta 2";
            Valintabutton2.UseVisualStyleBackColor = true;
            Valintabutton2.Click += Valintabutton2_Click;
            // 
            // Valintabutton3
            // 
            Valintabutton3.Location = new Point(12, 204);
            Valintabutton3.Name = "Valintabutton3";
            Valintabutton3.Size = new Size(150, 41);
            Valintabutton3.TabIndex = 2;
            Valintabutton3.Text = "Valinta 3";
            Valintabutton3.UseVisualStyleBackColor = true;
            // 
            // Valintabutton4
            // 
            Valintabutton4.Location = new Point(12, 265);
            Valintabutton4.Name = "Valintabutton4";
            Valintabutton4.Size = new Size(150, 41);
            Valintabutton4.TabIndex = 3;
            Valintabutton4.Text = "Valinta 4";
            Valintabutton4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(3, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(796, 31);
            textBox1.TabIndex = 4;
            textBox1.Text = "File";
            // 
            // Form1
            // 
            AccessibleName = "False";
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(Valintabutton4);
            Controls.Add(Valintabutton3);
            Controls.Add(Valintabutton2);
            Controls.Add(Valintabutton1);
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