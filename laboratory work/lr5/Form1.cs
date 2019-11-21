using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace lr5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string originStr = this.textBox1.Text.Trim();
            string targetStr = this.textBox2.Text.Trim();
            int maxDist = int.Parse(this.textBox4.Text.Trim());

            Stopwatch time = new Stopwatch();
            time.Start();

            int digit = LevDist.Distance(originStr, targetStr);

            time.Stop();
            this.textBox3.Text = time.Elapsed.ToString();

            this.listBox1.BeginUpdate();

            this.listBox1.Items.Clear();

            if (digit == -1)
                this.listBox1.Items.Add("Пустые строки... Введите слово (текст)");
            else if (maxDist != 0)
            {
                if(digit <= maxDist)
                {
                    this.listBox1.Items.Add("Строки можно считать совпадающими");
                    this.listBox1.Items.Add("Расстояние Левенштейна: " + digit + " <= " + maxDist);
                }
                if (digit > maxDist)
                {
                    this.listBox1.Items.Add("Строки можно считать несовпадающими...");
                    this.listBox1.Items.Add("Расстояние Левенштейна: " + digit + " > " + maxDist);
                }
            }
            else
                this.listBox1.Items.Add("Расстояние Левенштейна: " + digit);

            this.listBox1.EndUpdate();

        }

    }
}

