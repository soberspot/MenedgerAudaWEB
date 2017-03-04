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
    public partial class Form5_exist : Form
    {
        public Form5_exist()
        {
            InitializeComponent();

           
            // отображение в таблице артикулов деталей
            dataSet1.ReadXml("a.xml");
            dataGridView1.DataSource = dataSet1;
            dataGridView1.DataMember = "НомДетали";
          

            DictionClass.translite();



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            System.Diagnostics.Process.Start("http://exist.ru/price.aspx?pcode=" + dataGridView1.CurrentRow.Cells[2].Value.ToString());
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            System.Diagnostics.Process.Start("http://exist.ru/price.aspx?pcode=" + dataGridView1.CurrentRow.Cells[2].Value.ToString());
        }
    }
}
