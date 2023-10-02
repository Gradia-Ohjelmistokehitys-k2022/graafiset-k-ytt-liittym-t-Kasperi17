namespace Tehtävä
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            IDlabel = new Label();
            IDtextBox = new TextBox();
            Nimilabel = new Label();
            Julkaisuvuosilabel = new Label();
            Kestolabel = new Label();
            NimitextBox = new TextBox();
            JulkaisupäivätextBox = new TextBox();
            KestotextBox = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label1 = new Label();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            ArviotextBox = new TextBox();
            menuStrip1 = new MenuStrip();
            tiedostoToolStripMenuItem = new ToolStripMenuItem();
            poistuToolStripMenuItem = new ToolStripMenuItem();
            tietojaToolStripMenuItem = new ToolStripMenuItem();
            testaaTietokantayhteyttäToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(30, 22);
            button1.Name = "button1";
            button1.Size = new Size(241, 52);
            button1.TabIndex = 0;
            button1.Text = "Uusi tietue";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.Location = new Point(30, 89);
            button2.Name = "button2";
            button2.Size = new Size(241, 52);
            button2.TabIndex = 1;
            button2.Text = "Talenna";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Fuchsia;
            button3.Location = new Point(30, 158);
            button3.Name = "button3";
            button3.Size = new Size(241, 52);
            button3.TabIndex = 2;
            button3.Text = "Poista";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Location = new Point(6, 165);
            button4.Name = "button4";
            button4.Size = new Size(133, 53);
            button4.TabIndex = 7;
            button4.Text = "Edellinen";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(172, 165);
            button5.Name = "button5";
            button5.Size = new Size(125, 53);
            button5.TabIndex = 8;
            button5.Text = "Seuraava";
            button5.UseVisualStyleBackColor = true;
            // 
            // IDlabel
            // 
            IDlabel.AutoSize = true;
            IDlabel.Location = new Point(19, 22);
            IDlabel.Name = "IDlabel";
            IDlabel.Size = new Size(21, 15);
            IDlabel.TabIndex = 9;
            IDlabel.Text = "ID:";
            // 
            // IDtextBox
            // 
            IDtextBox.Location = new Point(104, 22);
            IDtextBox.Name = "IDtextBox";
            IDtextBox.ReadOnly = true;
            IDtextBox.Size = new Size(147, 23);
            IDtextBox.TabIndex = 10;
            IDtextBox.TextChanged += IDtextBox_TextChanged;
            IDtextBox.Enter += IDtextBox_Enter;
            // 
            // Nimilabel
            // 
            Nimilabel.AutoSize = true;
            Nimilabel.Location = new Point(19, 55);
            Nimilabel.Name = "Nimilabel";
            Nimilabel.Size = new Size(33, 15);
            Nimilabel.TabIndex = 11;
            Nimilabel.Text = "Nimi";
            // 
            // Julkaisuvuosilabel
            // 
            Julkaisuvuosilabel.AutoSize = true;
            Julkaisuvuosilabel.Location = new Point(19, 87);
            Julkaisuvuosilabel.Name = "Julkaisuvuosilabel";
            Julkaisuvuosilabel.Size = new Size(76, 15);
            Julkaisuvuosilabel.TabIndex = 12;
            Julkaisuvuosilabel.Text = "Julkaisuvuosi";
            // 
            // Kestolabel
            // 
            Kestolabel.AutoSize = true;
            Kestolabel.Location = new Point(19, 124);
            Kestolabel.Name = "Kestolabel";
            Kestolabel.Size = new Size(71, 15);
            Kestolabel.TabIndex = 13;
            Kestolabel.Text = "Kesto (min):";
            // 
            // NimitextBox
            // 
            NimitextBox.Location = new Point(104, 55);
            NimitextBox.Name = "NimitextBox";
            NimitextBox.Size = new Size(193, 23);
            NimitextBox.TabIndex = 14;
            NimitextBox.Enter += NimitextBox_Enter;
            NimitextBox.Leave += NimitextBox_Leave;
            // 
            // JulkaisupäivätextBox
            // 
            JulkaisupäivätextBox.Location = new Point(104, 87);
            JulkaisupäivätextBox.Name = "JulkaisupäivätextBox";
            JulkaisupäivätextBox.Size = new Size(100, 23);
            JulkaisupäivätextBox.TabIndex = 15;
            JulkaisupäivätextBox.TextChanged += JulkaisupäivätextBox_TextChanged;
            JulkaisupäivätextBox.Enter += JulkaisupäivätextBox_Enter;
            JulkaisupäivätextBox.Leave += JulkaisupäivätextBox_Leave;
            // 
            // KestotextBox
            // 
            KestotextBox.Location = new Point(104, 124);
            KestotextBox.Name = "KestotextBox";
            KestotextBox.Size = new Size(100, 23);
            KestotextBox.TabIndex = 16;
            KestotextBox.Enter += KestotextBox_Enter;
            KestotextBox.Leave += KestotextBox_Leave;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(IDtextBox);
            groupBox1.Controls.Add(IDlabel);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(KestotextBox);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(Nimilabel);
            groupBox1.Controls.Add(JulkaisupäivätextBox);
            groupBox1.Controls.Add(Julkaisuvuosilabel);
            groupBox1.Controls.Add(NimitextBox);
            groupBox1.Controls.Add(Kestolabel);
            groupBox1.Location = new Point(11, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(310, 272);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Elokuvan tiedot";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button3);
            groupBox2.Location = new Point(339, 40);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(292, 443);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Toiminallisuus";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(numericUpDown2);
            groupBox3.Controls.Add(numericUpDown1);
            groupBox3.Controls.Add(ArviotextBox);
            groupBox3.Location = new Point(12, 318);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(284, 165);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            groupBox3.Text = "Arvio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 138);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 21;
            label1.Text = "Arvosana";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(162, 135);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(50, 23);
            numericUpDown2.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(86, 135);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(52, 23);
            numericUpDown1.TabIndex = 1;
            // 
            // ArviotextBox
            // 
            ArviotextBox.Location = new Point(12, 22);
            ArviotextBox.Multiline = true;
            ArviotextBox.Name = "ArviotextBox";
            ArviotextBox.Size = new Size(272, 106);
            ArviotextBox.TabIndex = 0;
            ArviotextBox.TextChanged += ArviotextBox_TextChanged;
            ArviotextBox.Enter += ArviotextBox_Enter;
            ArviotextBox.Leave += ArviotextBox_Leave;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tiedostoToolStripMenuItem, tietojaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 21;
            menuStrip1.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            tiedostoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { poistuToolStripMenuItem });
            tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            tiedostoToolStripMenuItem.Size = new Size(64, 20);
            tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // poistuToolStripMenuItem
            // 
            poistuToolStripMenuItem.Name = "poistuToolStripMenuItem";
            poistuToolStripMenuItem.Size = new Size(107, 22);
            poistuToolStripMenuItem.Text = "Poistu";
            poistuToolStripMenuItem.Click += poistuToolStripMenuItem_Click;
            // 
            // tietojaToolStripMenuItem
            // 
            tietojaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { testaaTietokantayhteyttäToolStripMenuItem, infoToolStripMenuItem });
            tietojaToolStripMenuItem.Name = "tietojaToolStripMenuItem";
            tietojaToolStripMenuItem.Size = new Size(54, 20);
            tietojaToolStripMenuItem.Text = "Tietoja";
            // 
            // testaaTietokantayhteyttäToolStripMenuItem
            // 
            testaaTietokantayhteyttäToolStripMenuItem.Name = "testaaTietokantayhteyttäToolStripMenuItem";
            testaaTietokantayhteyttäToolStripMenuItem.Size = new Size(205, 22);
            testaaTietokantayhteyttäToolStripMenuItem.Text = "Testaa tietokantayhteyttä";
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(205, 22);
            infoToolStripMenuItem.Text = "Info";
            infoToolStripMenuItem.Click += infoToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 495);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Elokuvasovellus";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label IDlabel;
        private TextBox IDtextBox;
        private Label Nimilabel;
        private Label Julkaisuvuosilabel;
        private Label Kestolabel;
        private TextBox NimitextBox;
        private TextBox JulkaisupäivätextBox;
        private TextBox KestotextBox;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox ArviotextBox;
        private Label label1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tiedostoToolStripMenuItem;
        private ToolStripMenuItem poistuToolStripMenuItem;
        private ToolStripMenuItem tietojaToolStripMenuItem;
        private ToolStripMenuItem testaaTietokantayhteyttäToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
    }
}