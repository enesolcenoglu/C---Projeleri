using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayısal_Loto_Programı
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>();
            for (int i = 1; i <= 49; i++)
            {
                sayilar.Add(i);
            }
            for (int x = 1; x <= 6; x++)
            {
                System.Threading.Thread.Sleep(1000); //Seçimler arası 1sn bekleme süresi 
                Random rnd = new Random();
                int index = rnd.Next(0, sayilar.Count);
                Console.WriteLine(sayilar[index]);
                sayilar.RemoveAt(index);
            }
            Console.ReadLine();
        }
    }
}
