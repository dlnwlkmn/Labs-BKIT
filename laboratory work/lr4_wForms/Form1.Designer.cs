namespace lr4_wForms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.loadupFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFileReadTime = new System.Windows.Forms.TextBox();
            this.textBoxFileReadCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchWord = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxExactTime = new System.Windows.Forms.TextBox();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.textButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxLevDist = new System.Windows.Forms.CheckBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MaxDistField = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TreadsQuant = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ParallelSearchButton = new System.Windows.Forms.Button();
            this.FoundTreads = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TimeOfParallelSearch = new System.Windows.Forms.TextBox();
            this.SaveReport = new System.Windows.Forms.Button();
            this.checkBoxHtml = new System.Windows.Forms.CheckBox();
            this.checkBoxTxt = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadupFileButton
            // 
            this.loadupFileButton.Location = new System.Drawing.Point(417, 33);
            this.loadupFileButton.Margin = new System.Windows.Forms.Padding(4);
            this.loadupFileButton.Name = "loadupFileButton";
            this.loadupFileButton.Size = new System.Drawing.Size(108, 46);
            this.loadupFileButton.TabIndex = 0;
            this.loadupFileButton.Text = "Обзор";
            this.loadupFileButton.UseVisualStyleBackColor = true;
            this.loadupFileButton.Click += new System.EventHandler(this.loadupFileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите файл для чтения";
            // 
            // textBoxFileReadTime
            // 
            this.textBoxFileReadTime.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxFileReadTime.Location = new System.Drawing.Point(420, 95);
            this.textBoxFileReadTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFileReadTime.Name = "textBoxFileReadTime";
            this.textBoxFileReadTime.Size = new System.Drawing.Size(678, 31);
            this.textBoxFileReadTime.TabIndex = 2;
            // 
            // textBoxFileReadCount
            // 
            this.textBoxFileReadCount.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxFileReadCount.Location = new System.Drawing.Point(420, 141);
            this.textBoxFileReadCount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFileReadCount.Name = "textBoxFileReadCount";
            this.textBoxFileReadCount.Size = new System.Drawing.Size(516, 31);
            this.textBoxFileReadCount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Время чтения файла:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Зафиксировано уникальных слов:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(32, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Введите искомое слово:";
            // 
            // searchWord
            // 
            this.searchWord.Location = new System.Drawing.Point(420, 214);
            this.searchWord.Margin = new System.Windows.Forms.Padding(6);
            this.searchWord.Name = "searchWord";
            this.searchWord.Size = new System.Drawing.Size(678, 31);
            this.searchWord.TabIndex = 7;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(829, 381);
            this.searchButton.Margin = new System.Windows.Forms.Padding(6);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(253, 44);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 268);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Время поиска слова:";
            // 
            // textBoxExactTime
            // 
            this.textBoxExactTime.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxExactTime.Location = new System.Drawing.Point(420, 262);
            this.textBoxExactTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxExactTime.Name = "textBoxExactTime";
            this.textBoxExactTime.Size = new System.Drawing.Size(678, 31);
            this.textBoxExactTime.TabIndex = 9;
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 25;
            this.listBoxResult.Location = new System.Drawing.Point(37, 628);
            this.listBoxResult.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(1060, 254);
            this.listBoxResult.TabIndex = 11;
            // 
            // textButton
            // 
            this.textButton.Location = new System.Drawing.Point(948, 137);
            this.textButton.Margin = new System.Windows.Forms.Padding(6);
            this.textButton.Name = "textButton";
            this.textButton.Size = new System.Drawing.Size(150, 44);
            this.textButton.TabIndex = 12;
            this.textButton.Text = "Текст";
            this.textButton.UseVisualStyleBackColor = true;
            this.textButton.Click += new System.EventHandler(this.textButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Location = new System.Drawing.Point(32, 311);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Модификация";
            // 
            // checkBoxLevDist
            // 
            this.checkBoxLevDist.AutoSize = true;
            this.checkBoxLevDist.Location = new System.Drawing.Point(38, 351);
            this.checkBoxLevDist.Name = "checkBoxLevDist";
            this.checkBoxLevDist.Size = new System.Drawing.Size(416, 29);
            this.checkBoxLevDist.TabIndex = 14;
            this.checkBoxLevDist.Text = "Вычислить расстояние Левенштейна";
            this.checkBoxLevDist.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(576, 389);
            this.textBox4.Name = "textBox4";
            this.textBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox4.Size = new System.Drawing.Size(189, 31);
            this.textBox4.TabIndex = 16;
            this.textBox4.Text = "0";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(526, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Максимальное расстояние (необязательное поле):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label8.Location = new System.Drawing.Point(32, 437);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Паралельный поиск";
            // 
            // MaxDistField
            // 
            this.MaxDistField.Location = new System.Drawing.Point(576, 470);
            this.MaxDistField.Name = "MaxDistField";
            this.MaxDistField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MaxDistField.Size = new System.Drawing.Size(189, 31);
            this.MaxDistField.TabIndex = 19;
            this.MaxDistField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 476);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(502, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Максимальное расстояние (обязательное поле):";
            // 
            // TreadsQuant
            // 
            this.TreadsQuant.Location = new System.Drawing.Point(270, 526);
            this.TreadsQuant.Name = "TreadsQuant";
            this.TreadsQuant.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TreadsQuant.Size = new System.Drawing.Size(104, 31);
            this.TreadsQuant.TabIndex = 21;
            this.TreadsQuant.Text = "10";
            this.TreadsQuant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 529);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(221, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "Количество потоков:";
            // 
            // ParallelSearchButton
            // 
            this.ParallelSearchButton.Location = new System.Drawing.Point(829, 463);
            this.ParallelSearchButton.Margin = new System.Windows.Forms.Padding(6);
            this.ParallelSearchButton.Name = "ParallelSearchButton";
            this.ParallelSearchButton.Size = new System.Drawing.Size(253, 44);
            this.ParallelSearchButton.TabIndex = 22;
            this.ParallelSearchButton.Text = "Параллельный поиск";
            this.ParallelSearchButton.UseVisualStyleBackColor = true;
            this.ParallelSearchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // FoundTreads
            // 
            this.FoundTreads.BackColor = System.Drawing.SystemColors.Info;
            this.FoundTreads.Location = new System.Drawing.Point(780, 526);
            this.FoundTreads.Name = "FoundTreads";
            this.FoundTreads.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FoundTreads.Size = new System.Drawing.Size(317, 31);
            this.FoundTreads.TabIndex = 24;
            this.FoundTreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(439, 529);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(335, 25);
            this.label11.TabIndex = 23;
            this.label11.Text = "Найденное количество потоков:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 581);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(315, 25);
            this.label12.TabIndex = 26;
            this.label12.Text = "Время параллельного поиска:";
            // 
            // TimeOfParallelSearch
            // 
            this.TimeOfParallelSearch.BackColor = System.Drawing.SystemColors.Info;
            this.TimeOfParallelSearch.Location = new System.Drawing.Point(421, 575);
            this.TimeOfParallelSearch.Margin = new System.Windows.Forms.Padding(4);
            this.TimeOfParallelSearch.Name = "TimeOfParallelSearch";
            this.TimeOfParallelSearch.Size = new System.Drawing.Size(678, 31);
            this.TimeOfParallelSearch.TabIndex = 25;
            // 
            // SaveReport
            // 
            this.SaveReport.Location = new System.Drawing.Point(846, 900);
            this.SaveReport.Margin = new System.Windows.Forms.Padding(6);
            this.SaveReport.Name = "SaveReport";
            this.SaveReport.Size = new System.Drawing.Size(253, 44);
            this.SaveReport.TabIndex = 27;
            this.SaveReport.Text = "Сохранить отчет";
            this.SaveReport.UseVisualStyleBackColor = true;
            this.SaveReport.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBoxHtml
            // 
            this.checkBoxHtml.AutoSize = true;
            this.checkBoxHtml.Location = new System.Drawing.Point(747, 907);
            this.checkBoxHtml.Name = "checkBoxHtml";
            this.checkBoxHtml.Size = new System.Drawing.Size(90, 29);
            this.checkBoxHtml.TabIndex = 29;
            this.checkBoxHtml.Text = ".html";
            this.checkBoxHtml.UseVisualStyleBackColor = true;
            // 
            // checkBoxTxt
            // 
            this.checkBoxTxt.AutoSize = true;
            this.checkBoxTxt.Location = new System.Drawing.Point(663, 907);
            this.checkBoxTxt.Name = "checkBoxTxt";
            this.checkBoxTxt.Size = new System.Drawing.Size(73, 29);
            this.checkBoxTxt.TabIndex = 30;
            this.checkBoxTxt.Text = ".txt";
            this.checkBoxTxt.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(393, 907);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(247, 25);
            this.label13.TabIndex = 31;
            this.label13.Text = "Выбирите расширение:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1138, 959);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.checkBoxTxt);
            this.Controls.Add(this.checkBoxHtml);
            this.Controls.Add(this.SaveReport);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TimeOfParallelSearch);
            this.Controls.Add(this.FoundTreads);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ParallelSearchButton);
            this.Controls.Add(this.TreadsQuant);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.MaxDistField);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBoxLevDist);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textButton);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxExactTime);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchWord);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFileReadCount);
            this.Controls.Add(this.textBoxFileReadTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadupFileButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1164, 1000);
            this.Name = "Form1";
            this.Text = "Чтение файла, поиск слов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadupFileButton;
        private System.Windows.Forms.TextBox textBoxFileReadTime;
        private System.Windows.Forms.TextBox textBoxFileReadCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searchWord;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxExactTime;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Button textButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxLevDist;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MaxDistField;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TreadsQuant;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ParallelSearchButton;
        private System.Windows.Forms.TextBox FoundTreads;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TimeOfParallelSearch;
        private System.Windows.Forms.Button SaveReport;
        private System.Windows.Forms.CheckBox checkBoxHtml;
        private System.Windows.Forms.CheckBox checkBoxTxt;
        private System.Windows.Forms.Label label13;
    }
}

