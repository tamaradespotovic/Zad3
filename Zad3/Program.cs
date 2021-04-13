using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            double kamataUprocentima=0.05;
            double kamata=0.0;
            double ostatak_duga = 100000.0;
            double glavnica = 0.0;
            double rata = 5000.0;
            DateTime dt1 = DateTime.Now;
            DateTime dt2 = dt1.AddMonths(1);
            

            Console.WriteLine("Datum uzimanja kredita:" + dt1.Day + "." + dt1.Month + "." + dt1.Year);
            Console.WriteLine("Rata:" + rata);
            Console.WriteLine("Glavnica:" + glavnica);
            Console.WriteLine("Kamata:" + kamata);
            Console.WriteLine("Ostatak duga:" + ostatak_duga);
            Console.WriteLine();
          
            while (ostatak_duga > 0)
            {
                
                    double broj_proteklih_dana = (dt2 - dt1).TotalDays;
                    dt1 = dt2;
                    dt2 = dt2.AddMonths(1);

                  // Console.WriteLine(broj_proteklih_dana);
                    double c = broj_proteklih_dana / 365;
                 //   Console.WriteLine(c);
                    kamata = ostatak_duga * kamataUprocentima * c;
                    kamata = Math.Round(kamata, 0);
                    glavnica = rata - kamata;
                    ostatak_duga = ostatak_duga - glavnica;

                    Console.WriteLine("Datum:" + dt2.Day + "." + dt2.Month + "." + dt2.Year);
                    Console.WriteLine("Rata:" + rata);
                    Console.WriteLine("Glavnica:" + glavnica);
                    Console.WriteLine("Kamata:" + kamata);
                    Console.WriteLine("Ostatak duga:" + ostatak_duga);
                    Console.WriteLine();
                    if (ostatak_duga < 0)
                        break;
                }
                
                Console.ReadLine();
            }
        }
    }
//}
