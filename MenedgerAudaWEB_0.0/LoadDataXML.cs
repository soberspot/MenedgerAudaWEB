using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenedgerAudaWEB_0._0
{
    class LoadDataXML
    {
        public static XDocument UploadWEB()

        {
            XDocument srcTree = GetSrcTree();

            XDocument doc = new XDocument(
                new XComment("This is a comment"),
                new XElement("Root",
                    from el in srcTree.Element("Root").Elements()
                    where ((string)el).StartsWith("info")
                    select el
                )
            );


            return (doc);

        }

        private static XDocument GetSrcTree()
        {
            return new XDocument(
new XComment("This is a comment"),
new XElement("Root",
new XElement("Child1", "data1"),
new XElement("Child2", "data2"),
new XElement("Child3", "data3"),
new XElement("Child2", "data4"),
new XElement("Info5", "info5"),
new XElement("Info6", "info6"),
new XElement("Info7", "info7"),
new XElement("Info8", "info8")
)
);
        }

        public  static XDocument MakeTask(string номерДела, string VIN, string датаДТП, string регЗнак,
                                          string Пробег, string Имя, string Фамилия )
        {
                        
            XDocument taskXML = new XDocument(
                new XElement("Дело",
                 new XElement("CaseId",""),
                   new XElement("TaskId",""),
                   new XElement("НомерДела",номерДела),
                   new XElement("НомерСсылки", ""),
                   new XElement("ДатаДТП",датаДТП),
                   new XElement("ТС",
                       new XElement("VIN",VIN),
                       new XElement("РегЗнак",регЗнак),
                       new XElement("Пробег",Пробег),
                       new XElement("Владелец",
                           new XElement("Обращение",""),
                           new XElement("Имя",Имя),
                           new XElement("Фамилия",Фамилия),
                           new XElement("Страна",""),
                           new XElement("Индекс",""),
                           new XElement("Город",""),
                           new XElement("Адрес",""),
                           new XElement("Телефон",""),
                           new XElement("Телефон2",""),
                           new XElement("Факс",""),
                           new XElement("МобТелефон",""),
                           new XElement("ЭлПочта",""),
                           new XElement("Прочее",""),
                           new XElement("Примечание", "")
                           )
                       ),
                       new XElement("Полис",
                          new XElement("НомерПолиса","")
                          )

                   )
                
                
                );

            return (taskXML);

        }
    }
}
