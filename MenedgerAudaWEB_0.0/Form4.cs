using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MenedgerAudaWEB_0._0
{
    public partial class Form4 : Form

        
    {

        // ПУТЬ К ШАБЛОНУ Word
     //было:   private string pathToTemplate { get { return Application.StartupPath + "\\" + pathTextBox.Text; } }
        private string pathToTemplate { get { return  pathTextBox.Text; } }


        // ПУТЬ К ВРЕМЕННОМУ ФАЙЛУ ДЛЯ ВСТАВКИ в Word
        private string pathToInsertingDoc { get { return Application.StartupPath + "\\tempWordDoc.doc"; } }
 




        public Form4()
        {
            InitializeComponent();

            // Путь к шаблону Word формулы по  умолчанию
            pathTextBox.Text = @"C:\AUDATEX\offinout\Формулы.dotm";

            //только для теста: явное значение возраста
         olddetal_textBox.Text =  oldplastic_textBox.Text =  oldkuzovtextBox.Text = "4";

        

         nweprotector_textBox.Text = "9,5";
            garanti_textBox.Text = "8";

        }
            

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "базаавтоDataSet.База_ИП". При необходимости она может быть перемещена или удалена.
            this.база_ИПTableAdapter.Fill(this.базаавтоDataSet.База_ИП);
            this.dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            
            заполнитьTextBoxs_из_dataGridView1();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            заполнитьTextBoxs_из_dataGridView1();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            заполнитьTextBoxs_из_dataGridView1();

        }
        private void заполнитьTextBoxs_из_dataGridView1()
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();


            // textBox7.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString(); // Марка
            probeg_textBox.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString(); // Пробег
            dataprod_textBox.Text = "01" + "." + "01" + "." + dataGridView1.CurrentRow.Cells[6].Value.ToString();  // дата выпуска
            datadtp_textBox.Text = dataGridView1.CurrentRow.Cells[33].Value.ToString(); // дата дтп

            ПересчетВозраста();
        }

        private void ПересчетВозраста()
        {
            double _age = TimePurser.ВозрастТС(dataprod_textBox.Text, datadtp_textBox.Text);

            oldAKB_textBox.Text = olddetal_textBox.Text = oldplastic_textBox.Text = oldkuzovtextBox.Text = _age.ToString();
        }

           
        
        // Сохранить изменения в базе авто
        private void button1_Click(object sender, EventArgs e)
        {
           
            this.база_ИПTableAdapter.Update(this.базаавтоDataSet.База_ИП);
        }


        private void LoadDataAudaweb(object sender, EventArgs e)
        {
           
            string t = TimePurser.TimePursers(datadtp_textBox.Text);

            string tx = LoadDataXML.MakeTask(textBox1.Text, textBox3.Text, t, textBox2.Text, dataGridView1.CurrentRow.Cells[14].Value.ToString(), "", dataGridView1.CurrentRow.Cells[15].Value.ToString()).ToString();

            textBox6.Text = DataClass.UploadTask(tx);


        }

        
         private void OpenInBrouser(object sender, EventArgs e)
        {
            XDocument ответAudatexXML = XDocument.Parse(textBox6.Text);
            string val = DataClass.GetTaskID(ответAudatexXML);
            try
            {
                System.Diagnostics.Process.Start("https://www.audatex.ru/aurora/caseData.do?id=" + val);

            }
            catch (Exception ee)
            {

                MessageBox.Show("Ошибка!  Пустой код запроса " + ee.Source);
            }


        }


        // Сохранить изменения в базе авто
        private void СохранитьToolStripButtonClick(object sender, EventArgs e)
        {
            this.база_ИПTableAdapter.Update(this.базаавтоDataSet.База_ИП);
           
        }

        // Отправляем в шаблон акта осмотра данные о ТС
        private void goto_aktosmotra_Click(object sender, EventArgs e)
        {
            AcktOsm.fillAcktOsm(dataGridView1.CurrentRow.Cells[2].Value.ToString(),              //a
                                dataGridView1.CurrentRow.Cells[4].Value.ToString(),              //b     
                                 dataGridView1.CurrentRow.Cells[10].Value.ToString(),            //c 
                                  dataGridView1.CurrentRow.Cells[12].Value.ToString(),           //d
                                   dataGridView1.CurrentRow.Cells[30].Value.ToString(),          //e
                                    dataGridView1.CurrentRow.Cells[15].Value.ToString(),          //f
                                     dataGridView1.CurrentRow.Cells[16].Value.ToString(),         //g
                                      dataGridView1.CurrentRow.Cells[33].Value.ToString(),        //h
                                       dataGridView1.CurrentRow.Cells[5].Value.ToString(),       //k
                                        dataGridView1.CurrentRow.Cells[3].Value.ToString(),      //l
                                         dataGridView1.CurrentRow.Cells[7].Value.ToString(),     //m
                                          dataGridView1.CurrentRow.Cells[6].Value.ToString(),    //n
                                           dataGridView1.CurrentRow.Cells[14].Value.ToString(),   //p
                               " ");               //r
        }
        
        // Задаем значения DL, DT и минимальную высоту протектора для установленных типов ТС
        private void car_type_SelectedChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {

                case "Легковые автомобили, страной происхождения которых является Российская Федерация":
                    {
                        dl_textBox.Text = "0,0028";
                    dttextBox.Text = "0,055";
                    minprotector_textBox.Text = "1,6";
                    }

                    break;

                case "Грузовые бортовые автомобили, страной происхождения которых является Российская Федерация":
                    {
                        dl_textBox.Text = "0,0024";
                        dttextBox.Text = "0,08";
                        minprotector_textBox.Text = "1,0";
                    }

                    break;

                case "Автомобили-тягачи, страной происхождения которых является Российская Федерация":
                    {
                        dl_textBox.Text = "0,0016";
                        dttextBox.Text = "0,072";
                        minprotector_textBox.Text = "1,0";
                    }

                    break;

                case "Автомобили-самосвалы, страной происхождения которых является Российская Федерация":
                    {
                        dl_textBox.Text = "0,002";
                        dttextBox.Text = "0,12";
                        minprotector_textBox.Text = "1,0";
                    }

                    break;

                case "Специализированные автомобили, страной происхождения которых является Российская Федерация":
                    {
                        dl_textBox.Text = "0,0016";
                        dttextBox.Text = "0,11";
                        minprotector_textBox.Text = "1,0";
                    }

                    break;

                case "Автобусы, страной происхождения которых является Российская Федерация":
                    {
                        dl_textBox.Text = "0,0008";
                        dttextBox.Text = "0,122";
                        minprotector_textBox.Text = "2,0";
                    }

                    break;

                case "Легковые автомобили, странами происхождения которых являются государства Европы, включая Турцию":
                    {
                        dl_textBox.Text = "0,002";
                        dttextBox.Text = "0,04";
                        minprotector_textBox.Text = "1,6";
                    }

                    break;

                case "Легковые автомобили, странами происхождения которых являются государства Северной Америки и Южной Америки":
                    {
                        dl_textBox.Text = "0,0024";
                        dttextBox.Text = "0,044";
                        minprotector_textBox.Text = "1,6";
                    }

                    break;

                case "Легковые автомобили, странами происхождения которых являются государства Азии (кроме Японии)":
                    {
                        dl_textBox.Text = "0,0026";
                        dttextBox.Text = "0,05";
                        minprotector_textBox.Text = "1,6";
                    }

                    break;

                case "Легковые автомобили, страной происхождения которых является Япония":
                    {
                        dl_textBox.Text = "0,0016";
                        dttextBox.Text = "0,036";
                        minprotector_textBox.Text = "1,6";
                    }

                    break;

                case "Грузовые автомобили иностранного производства":
                    {
                        dl_textBox.Text = "0,0017";
                        dttextBox.Text = "0,072";
                        minprotector_textBox.Text = "1,0";
                    }

                    break;

                case "Автобусы иностранного производства":
                    {
                        dl_textBox.Text = "0,0008";
                        dttextBox.Text = "0,096";
                        minprotector_textBox.Text = "2,0";
                    }

                    break;

                case "Прицепы и полуприцепы, страной происхождения которых является Российская Федерация, для грузовых автомобилей":
                    {
                        dl_textBox.Text = "0,00";
                        dttextBox.Text = "0,096";
                        minprotector_textBox.Text = "1,0";
                    }

                    break;

                case "Прицепы и полуприцепы иностранного производства для грузовых автомобилей":
                    {
                        dl_textBox.Text = "0,00";
                        dttextBox.Text = "0,08";
                        minprotector_textBox.Text = "1,0";
                    }

                    break;


                case "Прицепы для легковых автомобилей и жилых автомобилей (типа автомобиль-дача)":
                    {
                        dl_textBox.Text = "0,00";
                        dttextBox.Text = "0,048";
                        minprotector_textBox.Text = "1,0";
                    }

                    break;

                case "Мотоциклы, страной происхождения которых является Российская Федерация":
                    {
                        dl_textBox.Text = "0,00";
                        dttextBox.Text = "0,095";
                        minprotector_textBox.Text = "0,8";
                    }

                    break;

                case "Мотоциклы иностранного производства":
                    {
                        dl_textBox.Text = "0,00";
                        dttextBox.Text = "0,055";
                        minprotector_textBox.Text = "0,8";
                    }

                    break;

                case "Сельскохозяйственные тракторы, страной происхождения которых является Российская Федерация":
                    {
                        dl_textBox.Text = "0,00";
                        dttextBox.Text = "0,16";
                        minprotector_textBox.Text = "1,0";
                    }

                    break;

                case "Сельскохозяйственные тракторы (80 - 100 л.с.) иностранного производства":
                    {
                        dl_textBox.Text = "0,00";
                        dttextBox.Text = "0,055";
                        minprotector_textBox.Text = "1,0";
                    }

                    break;

                case "Прочие тракторы иностранного производства":
                    {
                        dl_textBox.Text = "0,00";
                        dttextBox.Text = "0,088";
                        minprotector_textBox.Text = "1,0";
                    }

                    break;

                case "Прочая самоходная сельскохозяйственная техника и машины":
                    {
                        dl_textBox.Text = "0,00";
                        dttextBox.Text = "0,12";
                        minprotector_textBox.Text = "1,0";
                    }

                    break;

                case "Автогрейдеры":
                    {
                        dl_textBox.Text = "0,00";
                        dttextBox.Text = "0,126";
                        minprotector_textBox.Text = "1,0";
                    }

                    break;

                case "Погрузчики фронтальные одноковшовые":
                    {
                        dl_textBox.Text = "0,00";
                        dttextBox.Text = "0,124";
                        minprotector_textBox.Text = "1,0";
                    }

                    break;

                case "Экскаваторы одноковшовые":
                    {
                        dl_textBox.Text = "0,00";
                        dttextBox.Text = "0,08";
                        minprotector_textBox.Text = "1,0";
                    }

                    break;

                case "Катки дорожные":
                    {
                        dl_textBox.Text = "0,00";
                        dttextBox.Text = "0,085";
                        minprotector_textBox.Text = "1,0";
                    }

                    break;

                case "Прочая самоходная дорожно-строительная техника и машины":
                    {
                        dl_textBox.Text = "0,00";
                        dttextBox.Text = "0,11";
                        minprotector_textBox.Text = "1,0";
                    }

                    break;


                case "Аэродромная самоходная техника и машины":
                    {
                        dl_textBox.Text = "0,00";
                        dttextBox.Text = "0,1";
                        minprotector_textBox.Text = "1,0";
                    }

                    break;

                case "Землеройная самоходная техника и машины":
                    {
                        dl_textBox.Text = "0,00";
                        dttextBox.Text = "0,08";
                        minprotector_textBox.Text = "1,0";
                    }

                    break;

                case "Коммунальная самоходная техника и машины":
                    {
                        dl_textBox.Text = "0,00";
                        dttextBox.Text = "0,13";
                        minprotector_textBox.Text = "1,0";
                    }

                    break;

                case "Лесозаготовительная самоходная техника и машины":
                    {
                        dl_textBox.Text = "0,00";
                        dttextBox.Text = "0,11";
                        minprotector_textBox.Text = "1,0";
                    }

                    break;

                case "Пожарная самоходная техника и машины":
                    {
                        dl_textBox.Text = "0,00";
                        dttextBox.Text = "0,15";
                        minprotector_textBox.Text = "1,0";
                    }

                    break;

                case "Строительная самоходная техника и машины":
                    {
                        dl_textBox.Text = "0,00";
                        dttextBox.Text = "0,06";
                        minprotector_textBox.Text = "1,0";
                    }

                    break;

                case "Самоходная техника и машины для нефтедобычи нефтепереработки":
                    {
                        dl_textBox.Text = "0,00";
                        dttextBox.Text = "0,18";
                        minprotector_textBox.Text = "1,0";
                    }

                    break;

            }

        }

        
        private void расчетИзноса_Click(object sender, EventArgs e)
        {

            Расчет_Износа();

        }
        
        
        // расчет износа 
        private void Расчет_Износа()
        {
            
            iznosKuzov_textBox.Text = Iznos.ИзносКузова(oldkuzovtextBox.Text, garanti_textBox.Text);
            iznosPlastic_textBox.Text = Iznos.ИзносПластика(oldplastic_textBox.Text);
            iznosDet_textBox.Text = Iznos.ИзносДеталей(dttextBox.Text, olddetal_textBox.Text, dl_textBox.Text, probeg_textBox.Text);
            iznosshin_textBox.Text = Iznos.ИзносШин(higprotektor_textBox.Text, nweprotector_textBox.Text, minprotector_textBox.Text);
            iznosAk_textBox.Text = Iznos.ИзносАКБ(oldAKB_textBox.Text);
        }



        // Выводим результаты расчета износа в шаблон Word
        private void export_toWordFormula_Click(object sender, EventArgs e)
        {

            WordDocument wordDoc = null;
            try
            {
                wordDoc = new WordDocument(pathToTemplate);

                wordDoc.ReplaceAllStrings("{@@TK}", oldkuzovtextBox.Text);
                wordDoc.ReplaceAllStrings("{@@DT}", dttextBox.Text);
                wordDoc.ReplaceAllStrings("{@@DL}", dl_textBox.Text);
                wordDoc.ReplaceAllStrings("{@@TCK}", garanti_textBox.Text);
                wordDoc.ReplaceAllStrings("{@@TAK}", oldAKB_textBox.Text);
                wordDoc.ReplaceAllStrings("{@@HH}", nweprotector_textBox.Text);
                wordDoc.ReplaceAllStrings("{@@TKI}", olddetal_textBox.Text);
                wordDoc.ReplaceAllStrings("{@@LKI}", probeg_textBox.Text);
                wordDoc.ReplaceAllStrings("{@@HF}", higprotektor_textBox.Text);
                wordDoc.ReplaceAllStrings("{@@HDOP}", minprotector_textBox.Text);

                wordDoc.ReplaceAllStrings("{@@TPL}", oldplastic_textBox.Text);

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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void minprotector_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dttextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dl_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void datadtp_textBox_TextChanged(object sender, EventArgs e)
        {
            ПересчетВозраста();
           // Расчет_Износа();
        }

        private void dataprod_textBox_TextChanged(object sender, EventArgs e)
        {
            ПересчетВозраста();
           // Расчет_Износа();
        }

        private void probeg_textBox_TextChanged(object sender, EventArgs e)
        {
           // Расчет_Износа();
        }

        private void higprotektor_textBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void garanti_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pathTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            заполнитьTextBoxs_из_dataGridView1();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            заполнитьTextBoxs_из_dataGridView1();
        }



       

        

        

      

       
    }
}
