using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using Auda;

namespace MenedgerAudaWEB_0._0
{
    public class DataClass
    {

        // КОНСТРУКТОР КЛАССА
        public DataClass()
        {


        }


        // Запрос дел
        public static XDocument queryДела(string dateFrom, string dateTo)
        {
            Auda.Saxif ad = new Auda.Saxif();
            XDocument Дела =
                XDocument.Parse(ad.GetTaskList("RU417276", "xvcXX6Qd", dateFrom, dateTo, "OPENED"));
            Дела.Save("СписокДел.xml");
            return (Дела);

        }

        // Запрос калькуляции .XML из AudaWEB (каско) и сохранение в файл Калькуляция.xml


        public static XDocument queryCalc(string идентификатор)

        {
            Auda.Saxif ad = new Auda.Saxif();     // библиотека Auda.dll
            XDocument калькуляцияXML = XDocument.Parse(ad.GetTaskCalcs("RU417276", "xvcXX6Qd", идентификатор, "true"));
            калькуляцияXML.Save("Калькуляция.xml");
            return (калькуляцияXML);
        }

        // Cформировать дело. Загружает данные на сервер AudaWEB
        public static string UploadTask(string taskXML) 
         {
            Auda.Saxif ad = new Auda.Saxif();
             ad.Generator = "OneC_AlphaAuto";                
            string a = ad.UploadTask("RU417276", "xvcXX6Qd", taskXML);
            return (a);

         }

        //Поиск сделанных расчетов в запрошенном файле 
        public static XDocument ПоискРасчетов(XDocument docXml)

        {
            var doc = new XDocument(
                new XComment(""),
                new XElement("Расчеты",
                                       from Расчеты in docXml.Element("Расчеты")
                                                             .Elements("Расчет")
                                                             .Elements("ПарамРасч")
                                                             .Elements("ДатаРасч")
                                       select Расчеты));

            return (doc);

        }


        public static XDocument filtrCalc(XDocument docXML, string расчет)
        {
            XDocument doc = new XDocument(
                new XComment(""),
                new XElement("Расчеты",
                             from Расчеты in docXML.Element("Расчеты")
                                 .Elements("Расчет")
                                 .Elements("ПарамРасч")
                                 .Elements("ДатаРасч")
                              where ((string)Расчеты).StartsWith(расчет) // Фильтр по строке расчет
                             select Расчеты
                    )
                );

            return (doc);

        }


        //версия используемой библиотеки
        public static string GetVersion()
        {
            Auda.Saxif ad = new Auda.Saxif();           
            string a = ad.GetVersion();
            return (a);
        }

        public static string GetFilename()
        {
            Auda.Saxif ad = new Auda.Saxif();            
            string a = ad.GetFileName();
            return (a);
        }



    // Выбор  деалей, подлежащих замене

        public static XDocument ДеталиЗамена(XDocument калькуляцияXML)
        {
            XDocument doc = new XDocument(
                new XComment("Детали, подлежащие замене"),
                new XElement("Список_заменяемых_деталей",
                    new XElement("Деталь"),
                    from детали in калькуляцияXML.Element("Расчеты")
                        .Elements("Расчет")
                        .Elements("Детали")
                        .Elements("Деталь")
                        // .Elements("НаимДетали")
                        .Elements("НомДетали")
                    select детали
               
                  
            )
                   );
                    
            doc.Save("a.xml");
            return (doc);
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


        // выбор из xml  возвращенной строки после создания дела  Audatex значения идентификатора дела   
        public static string GetTaskID(XDocument ответAudatexXML)
        {
            XDocument doc = new XDocument(ответAudatexXML);            
                var taskId = doc.Element("Результат").Element("TaskId").Value;            
            return (taskId);

        }

        public static XDocument Test()
        {
            XDocument калькуляцияXML = XDocument.Load("Калькуляция.xml"); 
               var doc = new XDocument(
                new XComment("Детали, подлежащие замене"),
                new XElement("Список_заменяемых_деталей",
                    new XElement("Детали"),
                    from  детали in калькуляцияXML.Element("Расчеты")
                        .Elements("Расчет")
                        .Elements("Детали")
                        .Elements("Деталь")
                        .Elements("НаимДетали")
                        .Elements("НомДетали")
                    select 

                   new XElement("НаимДетали" , детали.Value)
                 //  new XElement("НомДетали")
            //,new XElement("НаимДетали",  "")


            )
                   );

            doc.Save("test.xml");
            return (doc);
        }

    }
}
