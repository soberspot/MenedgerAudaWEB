using System;
using System.Windows.Forms;

namespace MenedgerAudaWEB_0._0
{
    public partial class Form11 : Form
    {
          
         private string pathToTemplate { get { return pathTextBox.Text; } }

    
         // ПУТЬ К ВРЕМЕННОМУ ФАЙЛУ ДЛЯ ВСТАВКИ в Word
         private string pathToInsertingDoc { get { return Application.StartupPath + "\\tempWordDoc.doc"; } }
    
        public Form11()
        {
           InitializeComponent();

            nweprotector_textBox.Text = "8";

            pathTextBox.Text = @"C:\AUDATEX\offinout\ИзносЦБРФ.docm";
        }
         string dl, dt, minp;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox1.Text)
            {

                case "ВАЗ(Lada), ГАЗ, ЗАЗ,ТагАЗ, УАЗ":
                    {
                        textBox2.Text = dl = "0,003";
                        textBox3.Text = dt = "0,057";
                        textBox4.Text = minp = "1,6";
                    }

                    break;

                case "Brilliance, BYD, Chery, Derways, FAW, Geely, Great Wall, Hafei, Haima, Lifan, Luxgen, Xin Kai":
                    {
                        textBox2.Text = dl = "0,0029";
                        textBox3.Text = dt = "0,057";
                        textBox4.Text = minp = "1,6";
                    }

                    break;

                case "Aston Martin, Bentley, Bugatti, Ferrari, Jaguar, Maserati, Porsche Audi, BMW, Mercedes-Benz":
                    {
                        textBox2.Text = dl = "0,0023";
                        textBox3.Text = dt = "0,042";
                        textBox4.Text = minp = "1,6";
                    }

                    break;

                case "Mini, Rover Alfa Romeo, Citroen, Fiat,Ford, Opel, Peugeot, Renault, Saab, SEAT, Skoda,Volkswagen, Volvo":
                    {
                        textBox2.Text = dl = "0,0023";
                        textBox3.Text = dt = "0,042";
                        textBox4.Text = minp = "1,6";
                    }

                    break;

                case "Acura¸ Buick, Cadillac, Chevrolet, Chrysler, Dodge, Hummer":
                    {
                        textBox2.Text = dl = "0,0024";
                        textBox3.Text = dt = "0,045";
                        textBox4.Text = minp = "1,6";
                    }

                    break;

                case "Infiniti, Jeep, Lexus, Lincoln, Mercury, Pontiac":
                    {
                        textBox2.Text = dl = "0,0024";
                        textBox3.Text = dt = "0,045";
                        textBox4.Text = minp = "1,6";
                    }

                    break;

                case "Hyundai, Kia, Ssang Yong, Daewoo":
                    {
                        textBox2.Text = dl = "0,0026";
                        textBox3.Text = dt = "0,052";
                        textBox4.Text = minp = "1,6";
                    }

                    break;

                case "Daihatsu, Honda, Isuzu, Mazda, Mitsubishi, Nissan, Subaru, Suzuki, Toyota":
                    {
                        textBox2.Text = dl = "0,0025";
                        textBox3.Text = dt = "0,049";
                        textBox4.Text = minp = "1,6";
                    }

                    break;

                case "Грузовые автомобили– грузовые бортовые автомобили,":
                    {
                        textBox2.Text = dl = "0,0023";
                        textBox3.Text = dt = "0,077";
                        textBox4.Text = minp = "1,0";
                    }

                    break;

                case "Грузовые автомобили-фургоны, автомобили-самосвалы, автомобили-тягачи":
                    {
                        textBox2.Text = dl = "0,0023";
                        textBox3.Text = dt = "0,077";
                        textBox4.Text = minp = "1,0";
                    }

                    break;

                case "Автобусы":
                    {
                        textBox2.Text = dl = "0,0008";
                        textBox3.Text = dt = "0,113";
                        textBox4.Text = minp = "2,0";
                    }

                    break;

                case "Троллейбусы и вагоны трамваев":
                    {
                        textBox2.Text = dl = "0,0008";
                        textBox3.Text = dt = "0,098";
                        textBox4.Text = minp = "2,0";
                    }

                    break;

                case "Прицепы и полуприцепы для грузовых  автомобилей":
                    {
                        textBox2.Text = dl = "0,00";
                        textBox3.Text = dt = "0,09";
                        textBox4.Text = minp = "1,0";
                    }

                    break;

                case "Прицепы для легковых автомобилей и жилых автомобилей (типа автомобиль-дача)":
                    {
                        textBox2.Text = dl = "0,00";
                        textBox3.Text = dt = "0,06";
                        textBox4.Text = minp = "1,0";
                    }

                    break;


                case "Мотоциклы":
                    {
                        textBox2.Text = dl = "0,00";
                        textBox3.Text = dt = "0,07";
                        textBox4.Text = minp = "0,8";
                    }

                    break;

                case "Скутеры, мопеды, мотороллеры":
                    {
                        textBox2.Text = dl = "0,00";
                        textBox3.Text = dt = "0,09";
                        textBox4.Text = minp = "0,8";
                    }

                    break;

                case "Сельскохозяйственные тракторы, самоходная сельскохозяйственная, пожарная, коммунальная, погрузочная,":
                    {
                        textBox2.Text = dl = "0,00";
                        textBox3.Text = dt = "0,15";
                        textBox4.Text = minp = "1,0";
                    }

                    break;

                case "Строительная, дорожная, землеройная техника и иная техника на базе автомобилей и иных самоходных база":
                    {
                        textBox2.Text = dl = "0,00";
                        textBox3.Text = dt = "0,15";
                        textBox4.Text = minp = "1,0";
                    }

                    break;

                case "Велосипеды ":
                    {
                        textBox2.Text = dl = "0,00";
                        textBox3.Text = dt = "0,04";
                        textBox4.Text = minp = "0,8";
                    }

                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          double _age = TimePurser.ВозрастТС(dataprod_textBox.Text, datadtp_textBox.Text);

            oldkuzovtextBox.Text = _age.ToString();

           // oldkuzovtextBox.Text = Math.Round(Convert.ToDouble(_age)).ToString();

            iznosDet_textBox.Text = Iznos.ИзносДеталей_ЦБ(dt, oldkuzovtextBox.Text, dl, probeg_textBox.Text);

            iznosshin_textBox.Text = Iznos.ИзносШин_ЦБ(higprotektor_textBox.Text, nweprotector_textBox.Text, minp, nweprotector_textBox.Text);

            // iznosAk_textBox.Text = Iznos.ИзносАКБ(oldAKB_textBox.Text);
            

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
                //wordDoc.ReplaceAllStrings("{@@TK}", Math.Round(Convert.ToDouble(oldkuzovtextBox.Text),0).ToString());
               // wordDoc.ReplaceAllStrings("{@@TCK}", garanti_textBox.Text);
              //  wordDoc.ReplaceAllStrings("{@@TAK}", oldAKB_textBox.Text);
                wordDoc.ReplaceAllStrings("{@@HH}", nweprotector_textBox.Text);
                wordDoc.ReplaceAllStrings("{@@TKI}", Math.Round(Convert.ToDouble(oldkuzovtextBox.Text), 0).ToString());
                wordDoc.ReplaceAllStrings("{@@LKI}", Convert.ToString(Math.Round((Convert.ToDouble(probeg_textBox.Text) / 1000), 0) * 1000));
                wordDoc.ReplaceAllStrings("{@@HF}", higprotektor_textBox.Text);

                wordDoc.ReplaceAllStrings("{@@TSH}  ", textBox1.Text);

                wordDoc.ReplaceAllStrings("{@@TPL}", oldkuzovtextBox.Text);

               
                //wordDoc.ReplaceAllStrings("{@@ПЛ}", iznosPlastic_textBox.Text);
                wordDoc.ReplaceAllStrings("{@@КИ}", iznosDet_textBox.Text);
                wordDoc.ReplaceAllStrings("{@@ИШ}", iznosshin_textBox.Text);
                //wordDoc.ReplaceAllStrings("{@@ИАК}", iznosAk_textBox.Text);

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void probeg_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
