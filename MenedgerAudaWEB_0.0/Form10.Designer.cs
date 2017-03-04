namespace MenedgerAudaWEB_0._0
{
    partial class Form10
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.oldkuzovtextBox = new System.Windows.Forms.TextBox();
            this.probeg_textBox = new System.Windows.Forms.TextBox();
            this.higprotektor_textBox = new System.Windows.Forms.TextBox();
            this.oldAKB_textBox = new System.Windows.Forms.TextBox();
            this.garanti_textBox = new System.Windows.Forms.TextBox();
            this.iznosAk_textBox = new System.Windows.Forms.TextBox();
            this.iznosshin_textBox = new System.Windows.Forms.TextBox();
            this.iznosKuzov_textBox = new System.Windows.Forms.TextBox();
            this.iznosPlastic_textBox = new System.Windows.Forms.TextBox();
            this.iznosDet_textBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.nweprotector_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataprod_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.datadtp_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Рассчитать износ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(527, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Экспорт в Word";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Возраст ТС";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Врзраст АКБ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Высота протектора  шин";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Пробег";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Категория ТС";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Легковые автомобили, страной происхождения которых является Российская Федерация",
            "Грузовые бортовые автомобили, страной происхождения которых является Российская Ф" +
                "едерация",
            "Автомобили-тягачи, страной происхождения которых является Российская Федерация",
            "Автомобили-самосвалы, страной происхождения которых является Российская Федерация" +
                "",
            "Специализированные автомобили, страной происхождения которых является Российская " +
                "Федерация",
            "Автобусы, страной происхождения которых является Российская Федерация",
            "Легковые автомобили, странами происхождения которых являются государства Европы, " +
                "включая Турцию",
            "Легковые автомобили, странами происхождения которых являются государства Северной" +
                " Америки и Южной Америки",
            "Легковые автомобили, странами происхождения которых являются государства Азии (кр" +
                "оме Японии)",
            "Легковые автомобили, страной происхождения которых является Япония",
            "Грузовые автомобили иностранного производства",
            "Автобусы иностранного производства",
            "Прицепы и полуприцепы, страной происхождения которых является Российская Федераци" +
                "я, для грузовых автомобилей",
            "Прицепы и полуприцепы иностранного производства для грузовых автомобилей",
            "Прицепы для легковых автомобилей и жилых автомобилей (типа автомобиль-дача)",
            "Мотоциклы, страной происхождения которых является Российская Федерация",
            "Мотоциклы иностранного производства",
            "Сельскохозяйственные тракторы, страной происхождения которых является Российская " +
                "Федерация",
            "Сельскохозяйственные тракторы (80 - 100 л.с.) иностранного производства",
            "Прочие тракторы иностранного производства",
            "Прочая самоходная сельскохозяйственная техника и машины",
            "Автогрейдеры",
            "Погрузчики фронтальные одноковшовые",
            "Экскаваторы одноковшовые",
            "Катки дорожные",
            "Прочая самоходная дорожно-строительная техника и машины",
            "Аэродромная самоходная техника и машины",
            "Землеройная самоходная техника и машины",
            "Коммунальная самоходная техника и машины",
            "Лесозаготовительная самоходная техника и машины",
            "Пожарная самоходная техника и машины",
            "Строительная самоходная техника и машины",
            "Самоходная техника и машины для нефтедобычи и нефтепереработки"});
            this.comboBox1.Location = new System.Drawing.Point(179, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(468, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Гарантия от сквозной коррозии";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // oldkuzovtextBox
            // 
            this.oldkuzovtextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.oldkuzovtextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.oldkuzovtextBox.Location = new System.Drawing.Point(547, 53);
            this.oldkuzovtextBox.Name = "oldkuzovtextBox";
            this.oldkuzovtextBox.Size = new System.Drawing.Size(100, 20);
            this.oldkuzovtextBox.TabIndex = 9;
            this.oldkuzovtextBox.TextChanged += new System.EventHandler(this.oldkuzovtextBox_TextChanged);
            // 
            // probeg_textBox
            // 
            this.probeg_textBox.Location = new System.Drawing.Point(180, 111);
            this.probeg_textBox.Name = "probeg_textBox";
            this.probeg_textBox.Size = new System.Drawing.Size(100, 20);
            this.probeg_textBox.TabIndex = 10;
            this.probeg_textBox.TextChanged += new System.EventHandler(this.probeg_textBox_TextChanged);
            // 
            // higprotektor_textBox
            // 
            this.higprotektor_textBox.Location = new System.Drawing.Point(225, 141);
            this.higprotektor_textBox.Name = "higprotektor_textBox";
            this.higprotektor_textBox.Size = new System.Drawing.Size(55, 20);
            this.higprotektor_textBox.TabIndex = 11;
            this.higprotektor_textBox.TextChanged += new System.EventHandler(this.higprotektor_textBox_TextChanged);
            // 
            // oldAKB_textBox
            // 
            this.oldAKB_textBox.Location = new System.Drawing.Point(180, 205);
            this.oldAKB_textBox.Name = "oldAKB_textBox";
            this.oldAKB_textBox.Size = new System.Drawing.Size(100, 20);
            this.oldAKB_textBox.TabIndex = 12;
            this.oldAKB_textBox.TextChanged += new System.EventHandler(this.oldAKB_textBox_TextChanged);
            // 
            // garanti_textBox
            // 
            this.garanti_textBox.Location = new System.Drawing.Point(225, 237);
            this.garanti_textBox.Name = "garanti_textBox";
            this.garanti_textBox.Size = new System.Drawing.Size(54, 20);
            this.garanti_textBox.TabIndex = 13;
            this.garanti_textBox.TextChanged += new System.EventHandler(this.garanti_textBox_TextChanged);
            // 
            // iznosAk_textBox
            // 
            this.iznosAk_textBox.Location = new System.Drawing.Point(587, 198);
            this.iznosAk_textBox.Name = "iznosAk_textBox";
            this.iznosAk_textBox.Size = new System.Drawing.Size(61, 20);
            this.iznosAk_textBox.TabIndex = 58;
            this.iznosAk_textBox.TextChanged += new System.EventHandler(this.iznosAk_textBox_TextChanged);
            // 
            // iznosshin_textBox
            // 
            this.iznosshin_textBox.Location = new System.Drawing.Point(587, 169);
            this.iznosshin_textBox.Name = "iznosshin_textBox";
            this.iznosshin_textBox.Size = new System.Drawing.Size(61, 20);
            this.iznosshin_textBox.TabIndex = 57;
            this.iznosshin_textBox.TextChanged += new System.EventHandler(this.iznosshin_textBox_TextChanged);
            // 
            // iznosKuzov_textBox
            // 
            this.iznosKuzov_textBox.Location = new System.Drawing.Point(587, 140);
            this.iznosKuzov_textBox.Name = "iznosKuzov_textBox";
            this.iznosKuzov_textBox.Size = new System.Drawing.Size(61, 20);
            this.iznosKuzov_textBox.TabIndex = 56;
            this.iznosKuzov_textBox.TextChanged += new System.EventHandler(this.iznosKuzov_textBox_TextChanged);
            // 
            // iznosPlastic_textBox
            // 
            this.iznosPlastic_textBox.Location = new System.Drawing.Point(587, 111);
            this.iznosPlastic_textBox.Name = "iznosPlastic_textBox";
            this.iznosPlastic_textBox.Size = new System.Drawing.Size(61, 20);
            this.iznosPlastic_textBox.TabIndex = 55;
            this.iznosPlastic_textBox.TextChanged += new System.EventHandler(this.iznosPlastic_textBox_TextChanged);
            // 
            // iznosDet_textBox
            // 
            this.iznosDet_textBox.Location = new System.Drawing.Point(587, 81);
            this.iznosDet_textBox.Name = "iznosDet_textBox";
            this.iznosDet_textBox.Size = new System.Drawing.Size(61, 20);
            this.iznosDet_textBox.TabIndex = 54;
            this.iznosDet_textBox.TextChanged += new System.EventHandler(this.iznosDet_textBox_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(405, 140);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(162, 13);
            this.label21.TabIndex = 53;
            this.label21.Text = "Износ кузовных элементов, %";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(405, 169);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 13);
            this.label20.TabIndex = 52;
            this.label20.Text = "Износ шин, %";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(405, 205);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(127, 13);
            this.label18.TabIndex = 51;
            this.label18.Text = "Износ аккумулятора, %";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(405, 114);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(162, 13);
            this.label17.TabIndex = 50;
            this.label17.Text = "Износ деталей из пластика, %";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(405, 84);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(138, 13);
            this.label16.TabIndex = 49;
            this.label16.Text = "Износ комплектующих, %";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // nweprotector_textBox
            // 
            this.nweprotector_textBox.Location = new System.Drawing.Point(225, 173);
            this.nweprotector_textBox.Name = "nweprotector_textBox";
            this.nweprotector_textBox.Size = new System.Drawing.Size(59, 20);
            this.nweprotector_textBox.TabIndex = 60;
            this.nweprotector_textBox.TextChanged += new System.EventHandler(this.nweprotector_textBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "Высота нового  протектора";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(444, 284);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(241, 20);
            this.pathTextBox.TabIndex = 61;
            this.pathTextBox.TextChanged += new System.EventHandler(this.pathTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 62;
            this.label8.Text = "Дата выпуска";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dataprod_textBox
            // 
            this.dataprod_textBox.Location = new System.Drawing.Point(179, 53);
            this.dataprod_textBox.Name = "dataprod_textBox";
            this.dataprod_textBox.Size = new System.Drawing.Size(100, 20);
            this.dataprod_textBox.TabIndex = 63;
            this.dataprod_textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 64;
            this.label9.Text = "Дата повреждения";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // datadtp_textBox
            // 
            this.datadtp_textBox.Location = new System.Drawing.Point(179, 84);
            this.datadtp_textBox.Name = "datadtp_textBox";
            this.datadtp_textBox.Size = new System.Drawing.Size(100, 20);
            this.datadtp_textBox.TabIndex = 65;
            this.datadtp_textBox.TextChanged += new System.EventHandler(this.datadtp_textBox_TextChanged);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 348);
            this.Controls.Add(this.datadtp_textBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataprod_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.nweprotector_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.iznosAk_textBox);
            this.Controls.Add(this.iznosshin_textBox);
            this.Controls.Add(this.iznosKuzov_textBox);
            this.Controls.Add(this.iznosPlastic_textBox);
            this.Controls.Add(this.iznosDet_textBox);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.garanti_textBox);
            this.Controls.Add(this.oldAKB_textBox);
            this.Controls.Add(this.higprotektor_textBox);
            this.Controls.Add(this.probeg_textBox);
            this.Controls.Add(this.oldkuzovtextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form10";
            this.Text = "Простой расчет  износа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox oldkuzovtextBox;
        private System.Windows.Forms.TextBox probeg_textBox;
        private System.Windows.Forms.TextBox higprotektor_textBox;
        private System.Windows.Forms.TextBox oldAKB_textBox;
        private System.Windows.Forms.TextBox garanti_textBox;
        private System.Windows.Forms.TextBox iznosAk_textBox;
        private System.Windows.Forms.TextBox iznosshin_textBox;
        private System.Windows.Forms.TextBox iznosKuzov_textBox;
        private System.Windows.Forms.TextBox iznosPlastic_textBox;
        private System.Windows.Forms.TextBox iznosDet_textBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox nweprotector_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox dataprod_textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox datadtp_textBox;
    }
}