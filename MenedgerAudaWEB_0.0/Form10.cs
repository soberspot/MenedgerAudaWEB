using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenedgerAudaWEB_0._0
{
    public partial class Form10 : Form


     {
         private string pathToTemplate { get { return pathTextBox.Text; } }


         // ПУТЬ К ВРЕМЕННОМУ ФАЙЛУ ДЛЯ ВСТАВКИ в Word
         private string pathToInsertingDoc { get { return Application.StartupPath + "\\tempWordDoc.doc"; } }
        public Form10()
        {
            InitializeComponent();

            nweprotector_textBox.Text = "8";

            pathTextBox.Text = @"C:\AUDATEX\offinout\Формулы_с.dotm";
           
        }
        string dl, dt, minp;

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            switch (comboBox1.Text)
            {
                   
                case "Легковые автомобили, страной происхождения которых является Российская Федерация":
                    {
                    dl = "0,0028";
                    dt = "0,055";
                    minp = "1,6";
                    }

                    break;

                case "Грузовые бортовые автомобили, страной происхождения которых является Российская Федерация":
                    {
                        dl = "0,0024";
                        dt = "0,08";
                        minp = "1,0";
                    }

                    break;

                case "Автомобили-тягачи, страной происхождения которых является Российская Федерация":
                    {
                        dl = "0,0016";
                        dt = "0,072";
                        minp = "1,0";
                    }

                    break;

                case "Автомобили-самосвалы, страной происхождения которых является Российская Федерация":
                    {
                        dl = "0,002";
                        dt = "0,12";
                        minp = "1,0";
                    }

                    break;

                case "Специализированные автомобили, страной происхождения которых является Российская Федерация":
                    {
                        dl = "0,0016";
                        dt = "0,11";
                        minp = "1,0";
                    }

                    break;

                case "Автобусы, страной происхождения которых является Российская Федерация":
                    {
                        dl = "0,0008";
                        dt = "0,122";
                        minp = "2,0";
                    }

                    break;

                case "Легковые автомобили, странами происхождения которых являются государства Европы, включая Турцию":
                    {
                        dl = "0,002";
                        dt = "0,04";
                        minp = "1,6";
                    }

                    break;

                case "Легковые автомобили, странами происхождения которых являются государства Северной Америки и Южной Америки":
                    {
                        dl = "0,0024";
                        dt = "0,044";
                        minp = "1,6";
                    }

                    break;

                case "Легковые автомобили, странами происхождения которых являются государства Азии (кроме Японии)":
                    {
                        dl = "0,0026";
                        dt = "0,05";
                        minp = "1,6";
                    }

                    break;

                case "Легковые автомобили, страной происхождения которых является Япония":
                    {
                        dl = "0,0016";
                        dt = "0,036";
                        minp = "1,6";
                    }

                    break;

                case "Грузовые автомобили иностранного производства":
                    {
                        dl = "0,0017";
                        dt = "0,072";
                        minp = "1,0";
                    }

                    break;

                case "Автобусы иностранного производства":
                    {
                        dl = "0,0008";
                        dt = "0,096";
                        minp = "2,0";
                    }

                    break;

                case "Прицепы и полуприцепы, страной происхождения которых является Российская Федерация, для грузовых автомобилей":
                    {
                        dl = "0,00";
                        dt = "0,096";
                        minp = "1,0";
                    }

                    break;

                case "Прицепы и полуприцепы иностранного производства для грузовых автомобилей":
                    {
                        dl = "0,00";
                        dt = "0,08";
                        minp = "1,0";
                    }

                    break;


                case "Прицепы для легковых автомобилей и жилых автомобилей (типа автомобиль-дача)":
                    {
                        dl = "0,00";
                        dt = "0,048";
                        minp = "1,0";
                    }

                    break;

                case "Мотоциклы, страной происхождения которых является Российская Федерация":
                    {
                        dl = "0,00";
                        dt = "0,095";
                        minp = "0,8";
                    }

                    break;

                case "Мотоциклы иностранного производства":
                    {
                        dl = "0,00";
                        dt = "0,055";
                        minp = "0,8";
                    }

                    break;

                case "Сельскохозяйственные тракторы, страной происхождения которых является Российская Федерация":
                    {
                        dl = "0,00";
                        dt = "0,16";
                        minp = "1,0";
                    }

                    break;

                case "Сельскохозяйственные тракторы (80 - 100 л.с.) иностранного производства":
                    {
                        dl = "0,00";
                        dt = "0,055";
                        minp = "1,0";
                    }

                    break;

                case "Прочие тракторы иностранного производства":
                    {
                        dl = "0,00";
                        dt = "0,088";
                        minp = "1,0";
                    }

                    break;

                case "Прочая самоходная сельскохозяйственная техника и машины":
                    {
                        dl = "0,00";
                        dt = "0,12";
                        minp = "1,0";
                    }

                    break;

                case "Автогрейдеры":
                    {
                        dl = "0,00";
                        dt = "0,126";
                        minp = "1,0";
                    }

                    break;

                case "Погрузчики фронтальные одноковшовые":
                    {
                        dl = "0,00";
                        dt = "0,124";
                        minp = "1,0";
                    }

                    break;

                case "Экскаваторы одноковшовые":
                    {
                        dl = "0,00";
                        dt = "0,08";
                        minp = "1,0";
                    }

                    break;

                case "Катки дорожные":
                    {
                        dl = "0,00";
                        dt = "0,085";
                        minp = "1,0";
                    }

                    break;

                case "Прочая самоходная дорожно-строительная техника и машины":
                    {
                        dl = "0,00";
                        dt = "0,11";
                        minp = "1,0";
                    }

                    break;


                case "Аэродромная самоходная техника и машины":
                    {
                        dl = "0,00";
                        dt = "0,1";
                        minp = "1,0";
                    }

                    break;

                case "Землеройная самоходная техника и машины":
                    {
                        dl = "0,00";
                        dt = "0,08";
                        minp = "1,0";
                    }

                    break;

                case "Коммунальная самоходная техника и машины":
                    {
                        dl = "0,00";
                        dt = "0,13";
                        minp = "1,0";
                    }

                    break;

                case "Лесозаготовительная самоходная техника и машины":
                    {
                        dl = "0,00";
                        dt = "0,11";
                        minp = "1,0";
                    }

                    break;

                case "Пожарная самоходная техника и машины":
                    {
                        dl = "0,00";
                        dt = "0,15";
                        minp = "1,0";
                    }

                    break;

                case "Строительная самоходная техника и машины":
                    {
                        dl = "0,00";
                        dt = "0,06";
                        minp = "1,0";
                    }

                    break;

                case "Самоходная техника и машины для нефтедобычи нефтепереработки":
                    {
                        dl = "0,00";
                        dt = "0,18";
                        minp = "1,0";
                    }

                    break;

            

        }
        }


        private void button1_Click(object sender, EventArgs e)

        {

            double _age = TimePurser._ВозрастТС(dataprod_textBox.Text, datadtp_textBox.Text);

            oldkuzovtextBox.Text = _age.ToString();
            
            iznosKuzov_textBox.Text = Iznos.ИзносКузова(oldkuzovtextBox.Text, garanti_textBox.Text);

            iznosPlastic_textBox.Text = Iznos.ИзносПластика(oldkuzovtextBox.Text);

            iznosDet_textBox.Text = Iznos.ИзносДеталей(dt, oldkuzovtextBox.Text, dl, probeg_textBox.Text);

            iznosshin_textBox.Text = Iznos.ИзносШин(higprotektor_textBox.Text, nweprotector_textBox.Text, minp);

            iznosAk_textBox.Text = Iznos.ИзносАКБ(oldAKB_textBox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
         

            WordDocument wordDoc = null;
            try
            {
                wordDoc = new WordDocument(pathToTemplate);

                wordDoc.ReplaceAllStrings("{@@DT}", dt);
                wordDoc.ReplaceAllStrings("{@@DL}", dl);
                wordDoc.ReplaceAllStrings("{@@HDOP}", minp);
                wordDoc.ReplaceAllStrings("{@@TK}", oldkuzovtextBox.Text);
                wordDoc.ReplaceAllStrings("{@@TCK}", garanti_textBox.Text);
                wordDoc.ReplaceAllStrings("{@@TAK}", oldAKB_textBox.Text);
                wordDoc.ReplaceAllStrings("{@@HH}", nweprotector_textBox.Text);
                wordDoc.ReplaceAllStrings("{@@TKI}", oldkuzovtextBox.Text);
                wordDoc.ReplaceAllStrings("{@@LKI}", probeg_textBox.Text);
                wordDoc.ReplaceAllStrings("{@@HF}", higprotektor_textBox.Text);
               

                wordDoc.ReplaceAllStrings("{@@TPL}", oldkuzovtextBox.Text);

                wordDoc.ReplaceAllStrings("{@@ИК}", iznosKuzov_textBox.Text);
                wordDoc.ReplaceAllStrings("{@@ПЛ}", iznosPlastic_textBox.Text);
                wordDoc.ReplaceAllStrings("{@@КИ}", iznosDet_textBox.Text);
                wordDoc.ReplaceAllStrings("{@@ИШ}", iznosshin_textBox.Text);
                wordDoc.ReplaceAllStrings("{@@ИАК}", iznosAk_textBox.Text);

                wordDoc.ReplaceAllStrings("{@@КАТ}", comboBox1.Text);

            }

            catch (Exception error)
            {
                if (wordDoc != null) { wordDoc.Close(); }
                MessageBox.Show("Ошибка при замене текста на метке в документе  Word. Подробности " + error.Message);
                return;
            }
            wordDoc.Visible = true;

        }

        private void oldkuzovtextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pathTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nweprotector_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void iznosAk_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void iznosshin_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void iznosKuzov_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void iznosPlastic_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void iznosDet_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void datadtp_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void garanti_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void oldAKB_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void higprotektor_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void probeg_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
