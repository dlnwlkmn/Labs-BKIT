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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadupFileButton
            // 
            this.loadupFileButton.Location = new System.Drawing.Point(324, 33);
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
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите файл для чтения";
            // 
            // textBoxFileReadTime
            // 
            this.textBoxFileReadTime.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxFileReadTime.Location = new System.Drawing.Point(420, 127);
            this.textBoxFileReadTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFileReadTime.Name = "textBoxFileReadTime";
            this.textBoxFileReadTime.Size = new System.Drawing.Size(678, 31);
            this.textBoxFileReadTime.TabIndex = 2;
            // 
            // textBoxFileReadCount
            // 
            this.textBoxFileReadCount.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxFileReadCount.Location = new System.Drawing.Point(420, 173);
            this.textBoxFileReadCount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFileReadCount.Name = "textBoxFileReadCount";
            this.textBoxFileReadCount.Size = new System.Drawing.Size(516, 31);
            this.textBoxFileReadCount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Время чтения файла:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Зафиксировано уникальных слов:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Введите искомое слово:";
            // 
            // searchWord
            // 
            this.searchWord.Location = new System.Drawing.Point(420, 246);
            this.searchWord.Margin = new System.Windows.Forms.Padding(6);
            this.searchWord.Name = "searchWord";
            this.searchWord.Size = new System.Drawing.Size(516, 31);
            this.searchWord.TabIndex = 7;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(948, 240);
            this.searchButton.Margin = new System.Windows.Forms.Padding(6);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(150, 44);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 300);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Время поиска слова:";
            // 
            // textBoxExactTime
            // 
            this.textBoxExactTime.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxExactTime.Location = new System.Drawing.Point(420, 294);
            this.textBoxExactTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxExactTime.Name = "textBoxExactTime";
            this.textBoxExactTime.Size = new System.Drawing.Size(678, 31);
            this.textBoxExactTime.TabIndex = 9;
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 25;
            this.listBoxResult.Location = new System.Drawing.Point(38, 475);
            this.listBoxResult.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(1060, 254);
            this.listBoxResult.TabIndex = 11;
            // 
            // textButton
            // 
            this.textButton.Location = new System.Drawing.Point(948, 169);
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
            this.label6.Location = new System.Drawing.Point(32, 343);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Модификация";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(38, 383);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(378, 29);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Искать расстояние Левенштейна";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(576, 421);
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
            this.label7.Location = new System.Drawing.Point(32, 427);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(526, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Максимальное расстояние (необязательное поле):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1138, 764);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox1);
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
            this.Name = "Form1";
            this.Text = "Чтение файла, поиск слов";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
    }
}

