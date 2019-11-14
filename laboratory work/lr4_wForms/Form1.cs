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
        string text;
        private void loadupFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileOverview = new OpenFileDialog();
            fileOverview.Filter = "текстовые файлы|*.txt";

            if (fileOverview.ShowDialog() == DialogResult.OK)
            {
                Stopwatch time = new Stopwatch();
                time.Start();

                // читаем текст из выбранного файла в строку
                text = File.ReadAllText(fileOverview.FileName);

                // разделители слов в тексте
                char[] separators = new char[] { ' ', '.', ',', '!', '?', '/', '\t', '\n' };

                string[] wordArray = text.Split(separators);

                foreach (string strTemp in wordArray)
                {
                    string str = strTemp.Trim();
                    // добавляем слово в список WordList, если его там нет
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchingWord = this.searchWord.Text.Trim();

            if(WordList.Count > 0 && !string.IsNullOrWhiteSpace(searchingWord))
            {
                // для поиска в верхнем регистре
                string wordUpper = searchingWord.ToUpper();

                // временные результаты поиска
                List<string> tempList = new List<string>();

                Stopwatch time = new Stopwatch();
                time.Start();

                foreach (string str in WordList)
                {
                    if (str.ToUpper().Contains(wordUpper))
                    {
                        tempList.Add(str);
                    }
                }

                time.Stop();
                this.textBoxExactTime.Text = time.Elapsed.ToString();

                this.listBoxResult.BeginUpdate();

                // отчистка listBox
                this.listBoxResult.Items.Clear();

                // вывод найденного слова 
                foreach (string str in tempList)
                {
                    string massege = "Найденное слово: ";
                    this.listBoxResult.Items.Add(massege+str);
                }
                this.listBoxResult.EndUpdate();
                
                if(tempList.Count == 0)
                {
                    string massege = ":/ искомого слова в тексте нет :/";
                    this.listBoxResult.Items.Add(massege);
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать файл и ввести слово для поиска");
            }

        }

        private void textButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                text,
                "Текст из файла"
            );
        }
    }
}
