using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MenedgerAudaWEB_0._0
{
    public partial class Form1 : Form
    {

       


        public Form1()
        {
            InitializeComponent();
                      
            textBox4.Text = "01.01.2016";
            textBox5.Text = DateTime.Today.ToShortDateString();
            textBox7.Text = "ТС:  ";
            textBox8.Text = "VIN:";
          

        }
        public void button1_Click(object sender, EventArgs e)
        {

           
            try
            {

                dataGridView1.DataSource = null;
                DataClass.queryДела(TimePurser.DateFrom(textBox4.Text), TimePurser.DateTo(textBox5.Text));
                ДелаDataSet.ReadXml("СписокДел.xml");
                dataGridView1.DataSource = ДелаDataSet;
                dataGridView1.DataMember = "TaskProxy";


            }
            catch (Exception ee)
            {

                MessageBox.Show("Ошибка!  " + ee.Source);
            }
            
        }



        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
           
             System.IO.StringWriter swXML = new System.IO.StringWriter();

               ДелаDataSet.WriteXmlSchema(swXML);

            textBox1.Text = swXML.ToString();

      
        }

        // Выгружает калькуляцию из аудаекса
        private void button3_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";

            try
            {
                XDocument a = DataClass.queryCalc(textBox3.Text);
                textBox1.Text = DataClass.queryCalc(textBox3.Text).ToString();
                textBox2.Text = DataClass.ДеталиЗамена(a).ToString(); // отображает выборку в формате xml в текстбоксе 

                // отображение в таблице артикулов деталей
                dataSet1.ReadXml("a.xml");
                dataGridView2.DataSource = dataSet1;
                dataGridView2.DataMember = "НомДетали";

                DictionClass.translite();
            }

            catch

(Exception ee)
            {

                MessageBox.Show("Ошибка!  Калькуляция не загужена! Убедитесь в существовании ID " + ee.Source);
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Form3 form = new Form3();
            form.ShowDialog();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox7.Text ="ТС:  "+ dataGridView1.CurrentRow.Cells[7].Value.ToString()+
               
            dataGridView1.CurrentRow.Cells[8].Value.ToString();

            textBox8.Text = "VIN: "+dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {

         string   с = textBox3.Text;

            try
            {
                System.Diagnostics.Process.Start("https://www.audatex.ru/aurora/caseData.do?id=" +
              dataGridView1.CurrentRow.Cells[0].Value.ToString());

            }
            catch (Exception ee)
            {

                MessageBox.Show("Ошибка!  Пустой код запроса "+ ee.Source);
            }
           
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            Form5_exist form = new Form5_exist();
            form.ShowDialog();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
           // AcktOsm.FormsPdf();
            
        }
        
        private void button9_Click(object sender, EventArgs e)
        {
            DictionClass.translite();
            Окно_сообщений_форма.Показать("Перевод завершен успешно", 1200);
        }

        //открывает словарь 
        private void button10_Click(object sender, EventArgs e)
        {
            string словарь = @"C:\AUDATEX\offinout\словарь.txt";

            try
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Notepad++\notepad++.exe", словарь);
            }
            catch

(Exception ee)
            {

                MessageBox.Show("Ошибка!  Файл отсутствует " + ee.Source);
            }


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            System.Diagnostics.Process.Start("http://exist.ru/price.aspx?pcode=" + dataGridView2.CurrentRow.Cells[1].Value.ToString());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
           
            var xml_ = DataClass.Test().ToString();
            
            var xml_p = XElement.Parse(xml_);
            
            dynamic детали = new XMLresours.DynamicXMLNode("Детали");


              

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form8 form = new Form8();
            form.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form9 form = new Form9();
            form.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form10 form = new Form10();
            form.ShowDialog();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox7.Text = "ТС:  " + dataGridView1.CurrentRow.Cells[7].Value.ToString() +

            dataGridView1.CurrentRow.Cells[8].Value.ToString();

            textBox8.Text = "VIN: " + dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form11 form = new Form11();
            form.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            // Тест запроса 

            Form7 form = new Form7();
            form.ShowDialog();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}