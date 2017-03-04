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
    public partial class Окно_сообщений_форма : Form
    {
        public Окно_сообщений_форма(string Текст_сообщения, int интервал)
        {
            InitializeComponent();
            Timer t = new Timer();

            t.Interval = интервал;
            t.Start();
            t.Tick += new EventHandler(t_Tick);

            label1.Text = Текст_сообщения;

        }

        public void t_Tick(object sender, EventArgs e) // тут просто закрываю форму 
        {
            Close();
        }
        public static void Показать(string Текст_в_окне, int интервал) // тут просто закрываю форму логотип
        {
            Окно_сообщений_форма окно = new Окно_сообщений_форма(Текст_в_окне, интервал);
            окно.ShowDialog();

        }        

        private void Окно_сообщений_Load(object sender, EventArgs e)
        {

        }
    }
}
