namespace Lopputyö
{
    partial class Miinuslasku
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Miinuslasku));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Lasku = new System.Windows.Forms.Label();
            this.Tulos = new System.Windows.Forms.Label();
            this.UusiPeli = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.suljeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takaisinPäävalikkoonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tallennaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ennätys = new System.Windows.Forms.Label();
            this.ResetoiEnnätys = new System.Windows.Forms.Button();
            this.Vaikeustaso = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Miinuslasku";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(421, 261);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // Lasku
            // 
            this.Lasku.AutoSize = true;
            this.Lasku.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lasku.Location = new System.Drawing.Point(346, 266);
            this.Lasku.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lasku.Name = "Lasku";
            this.Lasku.Size = new System.Drawing.Size(43, 18);
            this.Lasku.TabIndex = 2;
            this.Lasku.Text = "lasku";
            
            // 
            // Tulos
            // 
            this.Tulos.AutoSize = true;
            this.Tulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tulos.Location = new System.Drawing.Point(493, 53);
            this.Tulos.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Tulos.Name = "Tulos";
            this.Tulos.Size = new System.Drawing.Size(44, 18);
            this.Tulos.TabIndex = 3;
            this.Tulos.Text = "0 / 10";
            // 
            // UusiPeli
            // 
            this.UusiPeli.Location = new System.Drawing.Point(354, 337);
            this.UusiPeli.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.UusiPeli.Name = "UusiPeli";
            this.UusiPeli.Size = new System.Drawing.Size(134, 51);
            this.UusiPeli.TabIndex = 4;
            this.UusiPeli.Text = "Uusi peli";
            this.UusiPeli.UseVisualStyleBackColor = true;
            this.UusiPeli.Click += new System.EventHandler(this.UusiPeli_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suljeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(565, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // suljeToolStripMenuItem
            // 
            this.suljeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.takaisinPäävalikkoonToolStripMenuItem,
            this.tallennaToolStripMenuItem});
            this.suljeToolStripMenuItem.Name = "suljeToolStripMenuItem";
            this.suljeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.suljeToolStripMenuItem.Text = "Menu";
            // 
            // takaisinPäävalikkoonToolStripMenuItem
            // 
            this.takaisinPäävalikkoonToolStripMenuItem.Name = "takaisinPäävalikkoonToolStripMenuItem";
            this.takaisinPäävalikkoonToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.takaisinPäävalikkoonToolStripMenuItem.Text = "Päävalikkoon";
            this.takaisinPäävalikkoonToolStripMenuItem.Click += new System.EventHandler(this.takaisinPäävalikkoonToolStripMenuItem_Click);
            // 
            // tallennaToolStripMenuItem
            // 
            this.tallennaToolStripMenuItem.Name = "tallennaToolStripMenuItem";
            this.tallennaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.tallennaToolStripMenuItem.Text = "Tallenna";
            // 
            // Ennätys
            // 
            this.Ennätys.AutoSize = true;
            this.Ennätys.Location = new System.Drawing.Point(20, 169);
            this.Ennätys.Name = "Ennätys";
            this.Ennätys.Size = new System.Drawing.Size(67, 20);
            this.Ennätys.TabIndex = 9;
            this.Ennätys.Text = "Ennätys";
            // 
            // ResetoiEnnätys
            // 
            this.ResetoiEnnätys.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetoiEnnätys.Location = new System.Drawing.Point(15, 218);
            this.ResetoiEnnätys.Name = "ResetoiEnnätys";
            this.ResetoiEnnätys.Size = new System.Drawing.Size(102, 69);
            this.ResetoiEnnätys.TabIndex = 10;
            this.ResetoiEnnätys.Text = "resetoi ennätys";
            this.ResetoiEnnätys.UseVisualStyleBackColor = true;
            this.ResetoiEnnätys.Click += new System.EventHandler(this.ResetoiEnnätys_Click);
            // 
            // Vaikeustaso
            // 
            this.Vaikeustaso.FormattingEnabled = true;
            this.Vaikeustaso.Items.AddRange(new object[] {
            "Helppo",
            "Vaikea"});
            this.Vaikeustaso.Location = new System.Drawing.Point(162, 48);
            this.Vaikeustaso.Name = "Vaikeustaso";
            this.Vaikeustaso.Size = new System.Drawing.Size(71, 28);
            this.Vaikeustaso.TabIndex = 11;
            this.Vaikeustaso.SelectedIndexChanged += new System.EventHandler(this.Vaikeustaso_SelectedIndexChanged);
            // 
            // Miinuslasku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(565, 466);
            this.Controls.Add(this.Vaikeustaso);
            this.Controls.Add(this.ResetoiEnnätys);
            this.Controls.Add(this.Ennätys);
            this.Controls.Add(this.UusiPeli);
            this.Controls.Add(this.Tulos);
            this.Controls.Add(this.Lasku);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Miinuslasku";
            this.Text = "Miinuslasku";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Lasku;
        private System.Windows.Forms.Label Tulos;
        private System.Windows.Forms.Button UusiPeli;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem suljeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takaisinPäävalikkoonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tallennaToolStripMenuItem;
        private System.Windows.Forms.Label Ennätys;
        private System.Windows.Forms.Button ResetoiEnnätys;
        private System.Windows.Forms.ComboBox Vaikeustaso;
    }
}