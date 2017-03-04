using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenedgerAudaWEB_0._0
{
    class Iznos
    {

        
       public   Iznos()
        {

        }


        // износ кузова
       public static string ИзносКузова(string t, string CK )

       {
           
       double П =(-1)*(4*Convert.ToDouble(t))/(20 + 4*Convert.ToDouble(CK));

       double ИК = 100 * (1-Math.Exp(П));
       if (ИК < 80)

          ИК = Convert.ToInt16(ИК);

       else ИК = 80;

       return ИК.ToString();
       
       
       }


        //расчет износа пластиковых деталей
        public static string ИзносПластика (string a)
       {
            
            double ИП = 100*(1-Math.Exp((-0.1)*Convert.ToDouble(a)));

            if (ИП < 80)

                ИП = Convert.ToInt16(ИП);
            else ИП = 80;

            return ИП.ToString();

            
        }

        //расчет износа комплектующих
        public static string ИзносДеталей (string dt, string t, string dl, string l)
        {

            double N = (-1) * ((Convert.ToDouble(dt) * Convert.ToDouble(t) + Convert.ToDouble(dl) * (Convert.ToDouble(l) / 1000)));

        double    ИД = 100 * (1 - Math.Exp(N));

        if (ИД < 80)

            ИД = Convert.ToInt16(ИД);

        else
            ИД = 80;

        return ИД.ToString();
                

        }


        public static string ИзносДеталей_ЦБ(string dt, string t, string dl, string l)
        {

            double _l = Math.Round((Convert.ToDouble(l) / 1000), 0) * 1000;

            // Округляем возраст ТС до ближайшего целого

            double _t = Math.Round(Convert.ToDouble(t),0);

           // double N = (-1) * ((Convert.ToDouble(dt) * Convert.ToDouble(t) + Convert.ToDouble(dl) * (Convert.ToDouble(l) / 1000)));

            double N = (-1) * ((Convert.ToDouble(dt) *_t + Convert.ToDouble(dl) *(_l / 1000)));

            double ИД = 100 * (1 - Math.Exp(N));

            if (ИД < 80)
                // if (ИД < 50)
                ИД = Convert.ToInt16(ИД);

            else
                ИД = 80;
            // ИД = 50;
            return ИД.ToString();
            
        }


        //расчет износа шин

        public static string ИзносШин(string f, string n, string m)
        {
           
            double ИШ = (Convert.ToDouble(n) - Convert.ToDouble(f)) / (Convert.ToDouble(n) - Convert.ToDouble(m)) * 100;

            ИШ = Convert.ToDouble(ИШ);

                if (ИШ < 80)

                ИШ = Convert.ToInt16(ИШ);

                else ИШ = 80;

            return ИШ.ToString();

        }


        public static string ИзносШин_ЦБ(string f, string n, string m, string v)
        {
            
            
                double ИШ = (Convert.ToDouble(n) - Convert.ToDouble(f)) / (Convert.ToDouble(n) - Convert.ToDouble(m)) * 100;

             
            ИШ = Convert.ToDouble(ИШ);
                            
                if (ИШ < 80)

                    ИШ = Convert.ToInt16(ИШ);

                else ИШ = 80;

            return ИШ.ToString();

        }


        //расчет износа АКБ
           public static string ИзносАКБ (string t)
        {

         double ИАКБ;
               
               if (Convert.ToDouble(t) < 4)

            ИАКБ = Convert.ToDouble(t)/4*100;

               else ИАКБ = 80;
               
           return ИАКБ.ToString();

        }
        

    }
}
