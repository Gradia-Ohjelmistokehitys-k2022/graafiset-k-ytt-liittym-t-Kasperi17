using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projektipohja
{
    public partial class MainForm : Form
    {
        string directory = AppDomain.CurrentDomain.BaseDirectory;
        string fileName = "Untitled";
        string data;
        public MainForm()
        {
            InitializeComponent();
            richTextBox1.Dock = DockStyle.Fill;
        }
        private void SetFormTitle()
        {
            FileInfo fileInfo = new FileInfo(fileName);
            Text = fileInfo.Name + " - Editor";
        }
        private void MenuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {


        }
        private void SaveFile()
        {
        

            

        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileName == "Untitled")
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                WriteFile();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileName = "Untitled";
            richTextBox1.Clear();
            SetFormTitle();

        }
        private string ReadFile()
        {
            string filePath = Path.Combine(directory, fileName);
            string loadedData = "";
            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                {
                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                        loadedData = streamReader.ReadToEnd();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
            return loadedData;
        }
        private void WriteFile()
        {
            string filePath = Path.Combine(directory, fileName);
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                data = richTextBox1.Text;
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    using (StreamWriter streamWriter = new StreamWriter(fileStream))
                    {
                        streamWriter.Write(data);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.Title = "Open";
            openFileDlg.ShowReadOnly = true;
            openFileDlg.Filter = "Text documents (*.txt)|*.txt|All files|*.*";
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDlg.FileName;
                richTextBox1.Text = ReadFile();
                SetFormTitle();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text documents (*.txt)|*.txt|All files|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;
                WriteFile();
                SetFormTitle();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
