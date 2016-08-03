using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_DragAndDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //this lets you drag files into the form.
        private void panel1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
        //This brings up a message box showing the path to the file.
        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
          string[] files = e.Data.GetData(DataFormats.FileDrop) as String[];
            foreach (string s in files)
                MessageBox.Show(s);
        }
    }
}
