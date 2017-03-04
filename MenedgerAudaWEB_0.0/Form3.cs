using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenedgerAudaWEB_0._0
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }

           
       // TimePurser.timePurser();

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_судебных_делDataSet.Судебки". При необходимости она может быть перемещена или удалена.
            this.судебкиTableAdapter.Fill(this.база_судебных_делDataSet.Судебки);

            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
        }


        // загрузить  на сервер Audatex (кнопка) 
        private void LoadDataAudaweb(object sender, EventArgs e)
        {
         
          string tx; 
          string t =  TimePurser.TimePursers(textBox4.Text);
          textBox5.Text = tx  =  LoadDataXML.MakeTask(textBox1.Text, textBox3.Text, t, textBox2.Text,"","","").ToString();
          textBox6.Text = DataClass.UploadTask(tx);
       
        }

        // открыть в браузере (кнопка)
        private void OpenInBrouser(object sender, EventArgs e)
        {

              XDocument ответAudatexXML = XDocument.Parse(textBox6.Text);
            string val = DataClass.GetTaskID(ответAudatexXML);
            try
            {

                
                System.Diagnostics.Process.Start("https://www.audatex.ru/aurora/caseData.do?id=" +val);
               
            }
            catch (Exception ee)
            {

                MessageBox.Show("Ошибка!  Пустой код запроса " + ee.Source);
            }

           
        }

        


        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            
          this.судебкиTableAdapter.Update(this.база_судебных_делDataSet.Судебки);
        //  this.dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.судебкиTableAdapter.Update(this.база_судебных_делDataSet.Судебки);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
        }




    }
}
