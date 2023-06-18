using System;
using LR21_Sydorenco_202TN.Properties;
using System.IO;
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
    public partial class New_Tab : Form
    {
        public New_Tab()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*|RTF Files (*.rtf)|*.rtf"; ;
            // встановлюємо фільтр файлів по розширенню
        }

        private void New_Tab_Load(object sender, EventArgs e)
        {

        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            //Якщо при відкритті натиснемо кнопку ЗАКРИТИ то повернемось назад
            File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            MessageBox.Show($" Файл був збережений в {saveFileDialog1.FileName} ");
            // зчитуємо текст з richTextBox1.Text в saveFileDialog1.FileName і виводимо повідомлення
        }

        private void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            //Якщо при відкритті натиснемо кнопку ЗАКРИТИ то повернемось назад

            richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            MessageBox.Show($" Файл був розпакований з {openFileDialog1.FileName} ");
            // зчитуємо текст зі змінної hewr в richTextBox1 і виводимо повідомлення
        }

        private void скопіюватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void вставитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Paste();
            }
        }

        private void вирізатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void виділитиВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.SelectAll();
            }
        }

        private void змінитиШрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
            richTextBox1.AppendText("[Параметри шришта змінено]");
            // запускаємо метод fontDialog1.ShowDialog() там встановлюємо переметри полів та присвоюємо ці значення полю richTextBox1.Font
        }

        private void змінитиФонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
            richTextBox1.AppendText("[Колір фону змінено]");
            // запускаємо метод colorDialog1.ShowDialog() там встановлюємо переметри полів та присвоюємо ці значення полю richTextBox1.BackColor
        }

        
    }
}
