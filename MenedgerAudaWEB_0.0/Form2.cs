using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenedgerAudaWEB_0._0
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();


            textBox1.Text = LoadDataXML.UploadWEB().ToString();

            textBox2.Text = LoadDataXML.MakeTask("","","","","","","").ToString();

           // textBox2.Text = TimePurser.timePurser();
            textBox3.Text = "Версия библиотеки: " +  DataClass.GetVersion() +"  " + DataClass.GetFilename();

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            XDocument a = XDocument.Load("Калькуляция.xml");  // загрузка для отладки запросов из калькуляция.xml

            XMLinTab(a, "ПарамРасч");

            textBox1.Text = DataClass.ПоискРасчетов(a).ToString();

            a = DataClass.filtrCalc(a, "2013-07-23T23:47:37.63");
            textBox2.Text = DataClass.ДеталиЗамена(a).ToString();
            textBox2.Text = a.ToString();
        }


        // Отображает Xdocument  в таблицу
        public void XMLinTab(XDocument doc, string dataMember)
        {

           DataSet DataSet1 = new DataSet();
            
            DataSet1.ReadXml(doc.CreateReader());
          
            dataGridView1.DataSource = DataSet1;
            dataGridView1.DataMember = dataMember;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Form3 form = new Form3();
            form.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.ShowDialog();
        }



    }


}
