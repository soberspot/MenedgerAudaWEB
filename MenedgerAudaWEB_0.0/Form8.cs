using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Auda;
using System.Web;
using System.Xml;

namespace MenedgerAudaWEB_0._0
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();

            dataSet1.ReadXml(@"C:\Users\Александр\Documents\Мои источники данных\БазаОценка.xml");

            dataGridView1.DataSource = dataSet1;
            dataGridView1.DataMember = "БазаИП";

        }

       
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            dataSet1.ReadXml(@"C:\Users\Александр\Documents\Мои источники данных\БазаОценка.xml");

            dataGridView1.DataSource = dataSet1;
            dataGridView1.DataMember = "БазаИП";

        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  this.база_ИПTableAdapter.Update(this.базаавтоDataSet.База_ИП);
            
        }
    }
}
