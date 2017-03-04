using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenedgerAudaWEB_0._0
{
    class DictionClass
    {

        public  static void translite()

        {
            Dictionary<string, string> words = new Dictionary<string, string>();

            // Читаем файл "Словарь.тхт" в строковый массив

            foreach (string строка in File.ReadAllLines(@"C:\AUDATEX\offinout\словарь.txt"))
            {
                int index = строка.IndexOf(',');
                int ll = строка.Length;
               try
               {
                    words.Add(строка.Substring(0, index).ToUpper().Trim(), строка.Substring(index + 1, ll - 1 - index));

               }
               catch (Exception ee)
               {

                   MessageBox.Show("Дублирующая запись в строке файла словарь.txt:  " + index  + ee.StackTrace);
               }
                
            }

            string staa;

            // Считываем в поток файл Калькуляция.xml и производим замену/перевод

            using (StreamReader assa = new StreamReader("Калькуляция.xml"))
            {

                staa = assa.ReadToEnd();

                foreach (KeyValuePair<string, string> pair in words)
                {

                    staa = staa.Replace(pair.Key, pair.Value);

                }

                assa.Close();                                        

                StreamWriter sww = new StreamWriter("Калькуляция_перевод.xml", false);

                sww.Write(staa);
                sww.Close();

            }

        }

        // Взять часть строки
        private string CutPart(ref string value, string token)
        {
            string result;
            int index = value.IndexOf(token);
            if (index < 0)
            {
                result = value;
                value = "";
            }
            else
            {
                result = value.Substring(0, index);
                value = value.Substring(index + token.Length);
            }
            return result;
        }


        // Преобразование полученной таблицы от А-Д в формат DataTable
        // </summary>
        ///<param name="data">данные</param>
        // <param name="fields">список полей через запятую</param>
        // <returns></returns>
        private DataTable ConvertToTable(string data, string fields)
        {
            DataTable table = new DataTable();
            string line, field;
            int no = 1;
            while (fields != "")
            {
                field = CutPart(ref fields, ",").Trim();
                
                table.Columns.Add(field, typeof(string));
            }

            object[] row;
            while (data != "")
            {
                line = CutPart(ref data, "\r\n");
                if (line == "") continue;
                row = new object[table.Columns.Count];
                no = 0;
                while (line != "")
                {
                    field = CutPart(ref line, "|");
                    row[no++] = field;
                }
                table.Rows.Add(row);
            }

            return table;
        }

        public abstract class Заглавные
        {
            /// <summary>
            /// Применить стратегию к <paramref name="sb"/>.
            /// </summary>
            public abstract void Применить(StringBuilder sb);

            class _ВСЕ : Заглавные
            {
                public override void Применить(StringBuilder sb)
                {
                    for (int i = 0; i < sb.Length; ++i)
                    {
                        sb[i] = char.ToUpperInvariant(sb[i]);
                    }
                }
            }

            class _Нет : Заглавные
            {
                public override void Применить(StringBuilder sb)
                {
                }
            }

            class _Первая : Заглавные
            {
                public override void Применить(StringBuilder sb)
                {
                    sb[0] = char.ToUpperInvariant(sb[0]);
                }
            }

            public static readonly Заглавные ВСЕ = new _ВСЕ();
            public static readonly Заглавные Нет = new _Нет();
            public static readonly Заглавные Первая = new _Первая();
        }
        public string ПерваяЗаглавная(string мод)
        {

            StringBuilder sbst = new StringBuilder();
            {
                sbst.Append(мод);
                sbst[0] = char.ToUpperInvariant(sbst[0]);
                for (int i = 1; i < sbst.Length; ++i)
                {
                    sbst[i] = char.ToLowerInvariant(sbst[i]);
                }
            }
            return sbst.ToString();
        }

 
    }
}