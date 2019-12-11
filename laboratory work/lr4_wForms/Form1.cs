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
using lr5_ClassLib;

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
            string searchingWord = this.searchWord.Text.Trim(); //получаем текст

            if(WordList.Count > 0 && !string.IsNullOrWhiteSpace(searchingWord))
            {
                if(this.checkBox1.Checked == true) // Если стоит галочка (Задание ЛР5)
                {
                    string originStr = this.searchWord.Text.Trim();
                    int maxDist = int.Parse(this.textBox4.Text.Trim());
                    int digit = 1000; // условно 1000 (не может же быть слова из 1000 букв :) )
                    int i = 0, j = 0;
                    Stopwatch time = new Stopwatch();
                    time.Start();

                    foreach (string str in WordList)
                    {
                        int digitTemp = LevDistance.Distance(originStr, str);
                        if (digitTemp < digit)
                        {
                            digit = digitTemp;
                            i = j; //запонимаем индекс слова в списке, имеющего на данный момент наименьшее расстоятние Л.
                        }
                        j++;
                    }

                    time.Stop();
                    this.textBoxExactTime.Text = time.Elapsed.ToString();

                    this.listBoxResult.BeginUpdate();

                    this.listBoxResult.Items.Clear();


                    if (digit == -1)
                        this.listBoxResult.Items.Add("Пустые строки... Введите слово (текст)");
                    else if (maxDist != 0) // Если пользователь ввел интересующее его расстояние Левенштейна
                    {
                        if (digit <= maxDist)
                        {
                            this.listBoxResult.Items.Add("Найденое слово: " + WordList[i]);
                            this.listBoxResult.Items.Add("Слова можно считать совпадающими");
                            this.listBoxResult.Items.Add("Расстояние Левенштейна: " + digit + " <= " + maxDist);
                        }
                        if (digit > maxDist)
                        {
                            this.listBoxResult.Items.Add("Слово '" + originStr + "' в тексте не найдено");
                            this.listBoxResult.Items.Add("Не одно слово из текста не совпало с искомым");
                            this.listBoxResult.Items.Add("Расстояние Левенштейна: " + digit + " > " + maxDist);
                        }
                    }
                    else // если растояние Левенштейна пользователем не указано ( находим слово с наименьшим расстоянием Левенштейна )
                    {
                        this.listBoxResult.Items.Add("Найденое слово: " + WordList[i]);
                        this.listBoxResult.Items.Add("Расстояние Левенштейна: " + digit);
                    }

                    this.listBoxResult.EndUpdate();

                }
                else // если галочка не стоит (Задание ЛР4)
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
                        this.listBoxResult.Items.Add(massege + str);
                    }
                    this.listBoxResult.EndUpdate();

                    if (tempList.Count == 0)
                    {
                        string massege = ":/ искомого слова в тексте нет :/";
                        this.listBoxResult.Items.Add(massege);
                    }
                    
                }
                
            }
            else
            {
                MessageBox.Show("Необходимо выбрать файл и ввести слово для поиска");
            }


        }

        private void textButton_Click(object sender, EventArgs e)
        {
            if (text != null)
            {
                MessageBox.Show(
                  text,
                  "Текст из файла"
                );
            }
            else
            {
                
                MessageBox.Show(
                  "Вы не выбрали файл",
                  "Текст из файла"
                );
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
