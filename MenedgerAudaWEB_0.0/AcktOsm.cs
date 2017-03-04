using System.Text;
using System.IO;

namespace MenedgerAudaWEB_0._0
{

    // Запись данных о ТС и месте и времени осмотра в файл pdf акта осмотра
    class AcktOsm
    {
         public static void fillAcktOsm(string a,string b,string c,string d,
                                          string e,string f,string g,string h,
                                          string k,string l,string m,string n,
                                          string p,string r)

         {
             const string путь = @"C:\AUDATEX\offinout\АКТосмотра.PDF";
            
          
            var sr = new StreamReader(@"C:\AUDATEX\offinout\Поля.XML");
            var str = new StringBuilder(sr.ReadToEnd());

            str = str.Replace("{АктОсм№}", a);
            str = str.Replace("{МаркаМодель}", b);
            str = str.Replace("{Кузов№}", c);
            str = str.Replace("{Шасси№}", d);
            str = str.Replace("{Цвет}", "");
            str = str.Replace("{ЛКП}", "");
            str = str.Replace("{ТипКузов}", "");
            str = str.Replace("{Двиг№}", "");
            str = str.Replace("{КлД}","");
            str = str.Replace("{МодДвиг}","");
            str = str.Replace("{РабОб}", "");
            str = str.Replace("{КвТЛС}","");
            str = str.Replace("{СВоРег}", e);
            str = str.Replace("{СобствТС}", f);
            str = str.Replace("{ДовЛиц}", " ");
            str = str.Replace("{АдресСоб}", g);
            str = str.Replace("{ДрЛиц}", " ");
            str = str.Replace("{ДатаДтп}", h);
            str = str.Replace("{МестоДтп}", " ");
            str = str.Replace("{ВИНКОД}", k);
            str = str.Replace("{ДатаОсм}", l);
            str = str.Replace("{Ч}", " ");
            str = str.Replace("{М}", " ");
            str = str.Replace("{РегЗн}", m);
            str = str.Replace("{ГодВып}", n);
            str = str.Replace("{Пробег}", p);
            str = str.Replace("{МестоОсм}", "  ");
            str = str.Replace("{}", " ");
            str = str.Replace("{}", " ");

            var sw = new StreamWriter("Поля1.xml");

            sw.Write(str);
            sw.Close();
            sr.Close();
            str.Clear();

                        File.Copy(путь, "АктЗап.PDF");
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Foxit Software\Foxit PhantomPDF\FoxitPhantomPDF.exe", "АктЗап.PDF");

         }
        
    }
}
