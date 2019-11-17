using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIApplication
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm child = new ChildForm();
            child.MdiParent = this;
            child.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, 
            EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, 
            EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, 
            EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

      

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        //this button makes use of the savefiledialog in order to save text 
        //files to a computer
        private void button2_Click(object sender, EventArgs e)
        {
            //setting properties from code 
            saveFileDialog1.InitialDirectory= "C:";
            saveFileDialog1.Title = "Save Text File";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Text Files|*.txt";

            if(saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, 
                    RichTextBoxStreamType.PlainText);
            }
        }

        //simple button that closes the program! 
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
