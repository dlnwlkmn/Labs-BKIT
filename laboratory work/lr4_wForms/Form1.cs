//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.IO;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;

namespace lr4_wForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> WordList = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileOverview = new OpenFileDialog();
            fileOverview.Filter = "текстовые файлы|*.txt";

            if (fileOverview.ShowDialog() == DialogResult.OK)
            {
                Stopwatch time = new Stopwatch();
                time.Start();

                //читаем текст из выбранного файла в строку
                string text = File.ReadAllText(fileOverview.FileName);

                //разделители слов в тексте
                char[] separators = new char[] { ' ', '.', ',', '!', '?', '/', '\t', '\n' };

                string[] wordArray = text.Split(separators);

                foreach (string strTemp in wordArray)
                {
                    string str = strTemp.Trim();
                    //добавляем слово в список WordList, если его там нет
                    if (!WordList.Contains(str)) WordList.Add(str);
                }

                time.Stop();
                this.textBoxFileReadTime.Text = time.Elapsed.ToString();
                this.textBoxFileReadCount.Text = WordList.Count.ToString();
            }
            else
            {
                MessageBox.Show("Файл не выбран");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
