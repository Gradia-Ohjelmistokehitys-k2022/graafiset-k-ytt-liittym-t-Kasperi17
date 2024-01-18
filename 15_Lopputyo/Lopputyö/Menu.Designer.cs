namespace Lopputyö
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.miinusbutton1 = new System.Windows.Forms.Button();
            this.kertobutton2 = new System.Windows.Forms.Button();
            this.plusbutton3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tallennaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musiikkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musiikki1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musiikka2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Vahvista = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // miinusbutton1
            // 
            this.miinusbutton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.miinusbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miinusbutton1.Location = new System.Drawing.Point(21, 205);
            this.miinusbutton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.miinusbutton1.Name = "miinusbutton1";
            this.miinusbutton1.Size = new System.Drawing.Size(203, 110);
            this.miinusbutton1.TabIndex = 0;
            this.miinusbutton1.Text = "Miinuslasku";
            this.miinusbutton1.UseVisualStyleBackColor = false;
            this.miinusbutton1.Click += new System.EventHandler(this.miinusbutton1_Click);
            // 
            // kertobutton2
            // 
            this.kertobutton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.kertobutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kertobutton2.Location = new System.Drawing.Point(235, 205);
            this.kertobutton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kertobutton2.Name = "kertobutton2";
            this.kertobutton2.Size = new System.Drawing.Size(203, 110);
            this.kertobutton2.TabIndex = 1;
            this.kertobutton2.Text = "Kertolasku";
            this.kertobutton2.UseVisualStyleBackColor = false;
            this.kertobutton2.Click += new System.EventHandler(this.kertobutton2_Click);
            // 
            // plusbutton3
            // 
            this.plusbutton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.plusbutton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusbutton3.Location = new System.Drawing.Point(453, 205);
            this.plusbutton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.plusbutton3.Name = "plusbutton3";
            this.plusbutton3.Size = new System.Drawing.Size(202, 110);
            this.plusbutton3.TabIndex = 2;
            this.plusbutton3.Text = "Pluslasku";
            this.plusbutton3.UseVisualStyleBackColor = false;
            this.plusbutton3.Click += new System.EventHandler(this.plusbutton3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(673, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tallennaToolStripMenuItem,
            this.musiikkiToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 22);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // tallennaToolStripMenuItem
            // 
            this.tallennaToolStripMenuItem.Name = "tallennaToolStripMenuItem";
            this.tallennaToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.tallennaToolStripMenuItem.Text = "Close";
            this.tallennaToolStripMenuItem.Click += new System.EventHandler(this.tallennaToolStripMenuItem_Click);
            // 
            // musiikkiToolStripMenuItem
            // 
            this.musiikkiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musiikki1ToolStripMenuItem,
            this.musiikka2ToolStripMenuItem});
            this.musiikkiToolStripMenuItem.Name = "musiikkiToolStripMenuItem";
            this.musiikkiToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.musiikkiToolStripMenuItem.Text = "Musiikki";
            // 
            // musiikki1ToolStripMenuItem
            // 
            this.musiikki1ToolStripMenuItem.Name = "musiikki1ToolStripMenuItem";
            this.musiikki1ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.musiikki1ToolStripMenuItem.Text = "Musiikki 1";
            
            // 
            // musiikka2ToolStripMenuItem
            // 
            this.musiikka2ToolStripMenuItem.Name = "musiikka2ToolStripMenuItem";
            this.musiikka2ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.musiikka2ToolStripMenuItem.Text = "Musiikka 2";
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "Matikkapeli";
            // 
            // Vahvista
            // 
            this.Vahvista.Location = new System.Drawing.Point(17, 111);
            this.Vahvista.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Vahvista.Name = "Vahvista";
            this.Vahvista.Size = new System.Drawing.Size(113, 28);
            this.Vahvista.TabIndex = 6;
            this.Vahvista.Text = "Kirjaudu/Rekisteröidy";
            this.Vahvista.UseVisualStyleBackColor = true;
            this.Vahvista.Click += new System.EventHandler(this.Vahvista_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 78);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 20);
            this.textBox1.TabIndex = 7;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(673, 682);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Vahvista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.plusbutton3);
            this.Controls.Add(this.kertobutton2);
            this.Controls.Add(this.miinusbutton1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Menu";
            this.Text = "Matikkapeli";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button miinusbutton1;
        private System.Windows.Forms.Button kertobutton2;
        private System.Windows.Forms.Button plusbutton3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tallennaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem musiikkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musiikki1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musiikka2ToolStripMenuItem;
        private System.Windows.Forms.Button Vahvista;
        private System.Windows.Forms.TextBox textBox1;
    }
}

