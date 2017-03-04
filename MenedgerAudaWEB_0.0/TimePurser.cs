using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MenedgerAudaWEB_0._0
{
    public class TimePurser

    {

       public TimePurser()
      { 
       }

        // Преобразование даты в формат AudaWEB
        public static string  TimePursers(string dateString)

        {
            string lineV = dateString.PadRight(10);
            string дд = lineV.Substring(0,2);
            string чч = lineV.Substring(3,2);
            string год = lineV.Substring(6,4);

             return (год+"-"+ чч +"-"+ дд + "T00:00:00");

        }


        public static string DateFrom(string dateString)

        {
            string lineV = dateString.PadRight(10);
            string дд = lineV.Substring(0, 2);
            string чч = lineV.Substring(3, 2);
            string год = lineV.Substring(6, 4);

            return (год + "-" + чч + "-" + дд);

        }

        public static string DateTo(string dateString)

        {
            string lineV = dateString.PadRight(10);
            string дд = lineV.Substring(0, 2);
            string чч = lineV.Substring(3, 2);
            string год = lineV.Substring(6, 4);

            return (год + "-" + чч + "-" + дд);

        }

        // старый расчет возраста (возможно, неверный)
        public static  double _ВозрастТС(string s1, string s2)
        {
            

            try
            {

                DateTime per1 = new DateTime();

                DateTime per2 = new DateTime();

                if (s1 != null & s2 != null)

                per1 = DateTime.Parse(s1);

                per2 = DateTime.Parse(s2);


                double _age_ = (double)per2.Year - (double)per1.Year;

                // double _month = 1;

                // if ((double)per2.Month < (double)per1.Month)

                //     _month = 0.1 * ((double)per2.Month - (double)per1.Month -1) / 1.2;

                // else

                //    _month = 0.1 * ((double)per2.Month - (double)per1.Month +1) / 1.2;


                // if ((double)per2.Month == (double)per1.Month)

                double _month = 0.1 * ((double)per2.Month - (double)per1.Month) / 1.2;

                double _age = _age_ + _month;

                return Math.Round(_age,1, MidpointRounding.AwayFromZero);
            }

            catch ( Exception )
            {

                MessageBox.Show("Ошибка в формате даты или отсутствие записи даты ДТП или даты выпуска ТС"  );

                double _age = -1;

                return _age;
            }
            
        }

        // новый расчет возраста 
        public static double ВозрастТС(string s1, string s2)
        {


            try
            {

                DateTime d1 = new DateTime();

                DateTime d2 = new DateTime();

                if (s1 != null & s2 != null)

                    d1 = DateTime.Parse(s1);

                    d2 = DateTime.Parse(s2);

                    // compute & return the difference of two dates,
                    // returning years, months & days
                    // d1 should be the larger (newest) of the two dates
                    // we want d1 to be the larger (newest) date
                    // flip if we need to
                    if (d1 < d2)
                    {
                        DateTime d3 = d2;
                        d2 = d1;
                        d1 = d3;
                    }

                    // compute difference in total months
                  int  months = 12 * (d1.Year - d2.Year) + (d1.Month - d2.Month);

                    // based upon the 'days',
                    // adjust months & compute actual days difference
                    if (d1.Day < d2.Day)
                    {
                        months--;
                      int  days = DateTime.DaysInMonth(d2.Year, d2.Month) - d2.Day + d1.Day;
                    }
                    else
                    {
                      int   days = d1.Day - d2.Day;
                    }
                    // compute years & actual months
                 int   years = months / 12;
                       months -= years * 12;
                
                      double _age = years + months * 0.1;

                      return _age;
                
            }

            catch (Exception)
            {

                MessageBox.Show("Ошибка в формате даты или отсутствие записи даты ДТП или даты выпуска ТС");

                double _age = -1;

                return _age;
            }

        }
        
    }
}
