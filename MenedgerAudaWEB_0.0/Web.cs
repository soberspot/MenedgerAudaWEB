using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenedgerAudaWEB_0._0
{
    class Web
    {
        // Отправка  POST запроса
        public static string POST(string Url, string Data)
        {
            System.Net.WebRequest req = System.Net.WebRequest.Create(Url);
            req.Method = "POST";
            req.Timeout = 100000;
            req.ContentType = "application/x-www-form-urlencoded";
            byte[] sentData = Encoding.GetEncoding(1251).GetBytes(Data);
            req.ContentLength = sentData.Length;
            System.IO.Stream sendStream = req.GetRequestStream();
            sendStream.Write(sentData, 0, sentData.Length);
            sendStream.Close();
            System.Net.WebResponse res = req.GetResponse();
            System.IO.Stream ReceiveStream = res.GetResponseStream();
            System.IO.StreamReader sr = new System.IO.StreamReader(ReceiveStream, Encoding.UTF8);
            //Кодировка указывается в зависимости от кодировки ответа сервера
            Char[] read = new Char[256];
            int count = sr.Read(read, 0, 256);
            string Out = String.Empty;
            while (count > 0)
            {
                String str = new String(read, 0, count);
                Out += str;
                count = sr.Read(read, 0, 256);
            }
            return Out;
        }

        //Отпрака Get запроса

        public static string GET(string Url, string Data)
        {
            System.Net.WebRequest req = System.Net.WebRequest.Create(Url + "?" + Data);
            System.Net.WebResponse resp = req.GetResponse();
            System.IO.Stream stream = resp.GetResponseStream();
            System.IO.StreamReader sr = new System.IO.StreamReader(stream);
            string Out = sr.ReadToEnd();
            sr.Close();
            return Out;
        }

//        Пример:
//Пусть есть адрес http://site.ru/ который принимает POST параметры fname и lname и выводит их на экран (сначала lname потом fname). А так же принимает GET параметр age и так же выводит его. Тогда:

//string Answer = POST("http://site.ru/", "fname=Andrey&lname=Mamatov");
////Answer = Mamatov Andrey
//Answer = GET("http://site.ru/", "age=123");
////Answer = 123

    }




}
