using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR21_Sydorenco_202TN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();             
        }
        New_Tab fer;        
        About_Program ret;        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fer = new New_Tab();
            fer.MdiParent = this;
            fer.Show();
        }      

        private void проНасToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ret = new About_Program();            
            ret.Show();
        }
    }
}
