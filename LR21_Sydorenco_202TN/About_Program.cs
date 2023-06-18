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
    public partial class About_Program : Form
    {
        public About_Program()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Програма створена для переглябу текстових файлів. За типом це MDI додаток";
        }

        private void About_Program_Load(object sender, EventArgs e)
        {
            button1.Text = "Показати дані";
        }
    }
}
