namespace Lopputyö
{
    partial class Kertolasku
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kertolasku));
            this.label1 = new System.Windows.Forms.Label();
            this.Lasku = new System.Windows.Forms.Label();
            this.Tulos = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Syötälasku = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.päävalikkoonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tallennaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kertolasku";
            // 
            // Lasku
            // 
            this.Lasku.AutoSize = true;
            this.Lasku.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lasku.Location = new System.Drawing.Point(322, 138);
            this.Lasku.Name = "Lasku";
            this.Lasku.Size = new System.Drawing.Size(63, 26);
            this.Lasku.TabIndex = 1;
            this.Lasku.Text = "lasku";
            // 
            // Tulos
            // 
            this.Tulos.AutoSize = true;
            this.Tulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tulos.Location = new System.Drawing.Point(931, 58);
            this.Tulos.Name = "Tulos";
            this.Tulos.Size = new System.Drawing.Size(66, 26);
            this.Tulos.TabIndex = 2;
            this.Tulos.Text = "0 / 10";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 100);
            this.button1.TabIndex = 3;
            this.button1.Text = "Uusi peli";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.UusiPeli_Click);
            // 
            // Syötälasku
            // 
            this.Syötälasku.Location = new System.Drawing.Point(420, 138);
            this.Syötälasku.Name = "Syötälasku";
            this.Syötälasku.Size = new System.Drawing.Size(100, 26);
            this.Syötälasku.TabIndex = 4;
            this.Syötälasku.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Vastaus_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1023, 36);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meniToolStripMenuItem
            // 
            this.meniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.päävalikkoonToolStripMenuItem,
            this.tallennaToolStripMenuItem});
            this.meniToolStripMenuItem.Name = "meniToolStripMenuItem";
            this.meniToolStripMenuItem.Size = new System.Drawing.Size(73, 30);
            this.meniToolStripMenuItem.Text = "Menu";
            // 
            // päävalikkoonToolStripMenuItem
            // 
            this.päävalikkoonToolStripMenuItem.Name = "päävalikkoonToolStripMenuItem";
            this.päävalikkoonToolStripMenuItem.Size = new System.Drawing.Size(217, 34);
            this.päävalikkoonToolStripMenuItem.Text = "Päävalikkoon";
            this.päävalikkoonToolStripMenuItem.Click += new System.EventHandler(this.päävalikkoonToolStripMenuItem_Click);
            // 
            // tallennaToolStripMenuItem
            // 
            this.tallennaToolStripMenuItem.Name = "tallennaToolStripMenuItem";
            this.tallennaToolStripMenuItem.Size = new System.Drawing.Size(217, 34);
            this.tallennaToolStripMenuItem.Text = "Tallenna";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ennätys";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 64);
            this.button2.TabIndex = 10;
            this.button2.Text = "resetoi ennätys";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ResetoiTulos_Click);
            // 
            // Kertolasku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1023, 528);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Syötälasku);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tulos);
            this.Controls.Add(this.Lasku);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Kertolasku";
            this.Text = "Kertolasku";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lasku;
        private System.Windows.Forms.Label Tulos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Syötälasku;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem päävalikkoonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tallennaToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}