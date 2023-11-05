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
            this.Lasku = new System.Windows.Forms.Label();
            this.Syötalasku1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uusiPeli = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pluslasku";
            // 
            // Lasku
            // 
            this.Lasku.AutoSize = true;
            this.Lasku.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lasku.Location = new System.Drawing.Point(251, 138);
            this.Lasku.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lasku.Name = "Lasku";
            this.Lasku.Size = new System.Drawing.Size(43, 18);
            this.Lasku.TabIndex = 1;
            this.Lasku.Text = "lasku";
            
            // 
            // Syötalasku1
            // 
            this.Syötalasku1.Location = new System.Drawing.Point(315, 139);
            this.Syötalasku1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Syötalasku1.Name = "Syötalasku1";
            this.Syötalasku1.Size = new System.Drawing.Size(42, 20);
            this.Syötalasku1.TabIndex = 3;
            this.Syötalasku1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Vastaus_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(626, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "0 / 10";
            // 
            // uusiPeli
            // 
            this.uusiPeli.Location = new System.Drawing.Point(254, 172);
            this.uusiPeli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uusiPeli.Name = "uusiPeli";
            this.uusiPeli.Size = new System.Drawing.Size(118, 60);
            this.uusiPeli.TabIndex = 5;
            this.uusiPeli.Text = "Uusi peli\'";
            this.uusiPeli.UseVisualStyleBackColor = true;
            this.uusiPeli.Click += new System.EventHandler(this.uusiPeli_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip2.Size = new System.Drawing.Size(673, 24);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.päävalikkoonToolStripMenuItem,
            this.tallennaToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 22);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // päävalikkoonToolStripMenuItem
            // 
            this.päävalikkoonToolStripMenuItem.Name = "päävalikkoonToolStripMenuItem";
            this.päävalikkoonToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.päävalikkoonToolStripMenuItem.Text = "Päävalikkoon";
            this.päävalikkoonToolStripMenuItem.Click += new System.EventHandler(this.päävalikkoonToolStripMenuItem_Click);
            // 
            // tallennaToolStripMenuItem
            // 
            this.tallennaToolStripMenuItem.Name = "tallennaToolStripMenuItem";
            this.tallennaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.tallennaToolStripMenuItem.Text = "Tallenna";
            this.tallennaToolStripMenuItem.Click += new System.EventHandler(this.tallennaToolStripMenuItem_Click);
            // 
            // Ennätys
            // 
            this.Ennätys.AutoSize = true;
            this.Ennätys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ennätys.Location = new System.Drawing.Point(12, 101);
            this.Ennätys.Name = "Ennätys";
            this.Ennätys.Size = new System.Drawing.Size(67, 20);
            this.Ennätys.TabIndex = 8;
            this.Ennätys.Text = "Ennätys";
            // 
            // ResetoiEnnätys
            // 
            this.ResetoiEnnätys.Location = new System.Drawing.Point(15, 125);
            this.ResetoiEnnätys.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ResetoiEnnätys.Name = "ResetoiEnnätys";
            this.ResetoiEnnätys.Size = new System.Drawing.Size(61, 44);
            this.ResetoiEnnätys.TabIndex = 9;
            this.ResetoiEnnätys.Text = "resetoi ennätys";
            this.ResetoiEnnätys.UseVisualStyleBackColor = true;
            this.ResetoiEnnätys.Click += new System.EventHandler(this.ResetoiEnnätys_Click);
            // 
            // Pluslasku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(673, 682);
            this.Controls.Add(this.ResetoiEnnätys);
            this.Controls.Add(this.Ennätys);
            this.Controls.Add(this.uusiPeli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Syötalasku1);
            this.Controls.Add(this.Lasku);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Pluslasku";
            this.Text = "Pluslasku";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lasku;
        private System.Windows.Forms.TextBox Syötalasku1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button uusiPeli;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem päävalikkoonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tallennaToolStripMenuItem;
        private System.Windows.Forms.Label Ennätys;
        private System.Windows.Forms.Button ResetoiEnnätys;
    }
}