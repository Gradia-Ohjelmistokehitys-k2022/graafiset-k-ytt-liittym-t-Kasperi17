namespace Lopputyö
{
    partial class Pluslasku
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pluslasku));
            this.label1 = new System.Windows.Forms.Label();
            this.lasku = new System.Windows.Forms.Label();
            this.syötalasku1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uusiPeli = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.päävalikkoonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tallennaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ennätys = new System.Windows.Forms.Label();
            this.ResetoiEnnätys = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pluslasku";
            // 
            // lasku
            // 
            this.lasku.AutoSize = true;
            this.lasku.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lasku.Location = new System.Drawing.Point(291, 186);
            this.lasku.Name = "lasku";
            this.lasku.Size = new System.Drawing.Size(63, 26);
            this.lasku.TabIndex = 1;
            this.lasku.Text = "lasku";
            this.lasku.Click += new System.EventHandler(this.laskuClick_1);
            // 
            // syötalasku1
            // 
            this.syötalasku1.Location = new System.Drawing.Point(386, 186);
            this.syötalasku1.Name = "syötalasku1";
            this.syötalasku1.Size = new System.Drawing.Size(61, 26);
            this.syötalasku1.TabIndex = 3;
            this.syötalasku1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Vastaus_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(472, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tulos";
            this.label3.Click += new System.EventHandler(this.UusiPeli_Click);
            // 
            // uusiPeli
            // 
            this.uusiPeli.Location = new System.Drawing.Point(16, 148);
            this.uusiPeli.Name = "uusiPeli";
            this.uusiPeli.Size = new System.Drawing.Size(177, 92);
            this.uusiPeli.TabIndex = 5;
            this.uusiPeli.Text = "Uusi peli\'";
            this.uusiPeli.UseVisualStyleBackColor = true;
            this.uusiPeli.Click += new System.EventHandler(this.uusiPeli_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(665, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "\"napauta lasku kohtaa saadaksesi lasku ja tulos kohtaa laskettuasi 10 kymmenen ky" +
    "symystä\"";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1532, 33);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.päävalikkoonToolStripMenuItem,
            this.tallennaToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.menuToolStripMenuItem.Text = "Menu";
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
            this.tallennaToolStripMenuItem.Click += new System.EventHandler(this.tallennaToolStripMenuItem_Click);
            // 
            // Ennätys
            // 
            this.Ennätys.AutoSize = true;
            this.Ennätys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ennätys.Location = new System.Drawing.Point(18, 265);
            this.Ennätys.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ennätys.Name = "Ennätys";
            this.Ennätys.Size = new System.Drawing.Size(97, 29);
            this.Ennätys.TabIndex = 8;
            this.Ennätys.Text = "Ennätys";
            
            // 
            // ResetoiEnnätys
            // 
            this.ResetoiEnnätys.Location = new System.Drawing.Point(23, 318);
            this.ResetoiEnnätys.Name = "ResetoiEnnätys";
            this.ResetoiEnnätys.Size = new System.Drawing.Size(92, 68);
            this.ResetoiEnnätys.TabIndex = 9;
            this.ResetoiEnnätys.Text = "resetoi ennätys";
            this.ResetoiEnnätys.UseVisualStyleBackColor = true;
            this.ResetoiEnnätys.Click += new System.EventHandler(this.ResetoiEnnätys_Click);
            // 
            // Pluslasku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1532, 1050);
            this.Controls.Add(this.ResetoiEnnätys);
            this.Controls.Add(this.Ennätys);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uusiPeli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.syötalasku1);
            this.Controls.Add(this.lasku);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Pluslasku";
            this.Text = "Form4";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lasku;
        private System.Windows.Forms.TextBox syötalasku1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button uusiPeli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem päävalikkoonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tallennaToolStripMenuItem;
        private System.Windows.Forms.Label Ennätys;
        private System.Windows.Forms.Button ResetoiEnnätys;
    }
}