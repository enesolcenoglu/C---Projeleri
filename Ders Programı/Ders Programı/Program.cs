using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static string tekrarla(int sayi, string karakter)
        {
            string yazi = "";
            for (int i = 0; i < sayi; i++)
            {
                yazi += karakter;
            }
            return yazi;
        }
        static void Main(string[] args)
        {
            string k = "*";
            int x = 0, y = 3, a = 15;

            string[,] dizi = {
                { "Pazartesi", "Matematik","Matematik","Edebiyat","Edebiyat","BTT","BTT","ProgTem","ProgTem"},
                { "Salı", "Matematik","Matematik","Edebiyat","Edebiyat","BTT","BTT","ProgTem","ProgTem"},
                { "Çarşamba", "Matematik","Matematik","Edebiyat","Edebiyat","BTT","BTT","ProgTem","ProgTem"},
                { "Perşembe", "Matematik","Matematik","Edebiyat","Edebiyat","BTT","BTT","ProgTem","ProgTem"},
                { "Cuma", "Matematik","Matematik","Edebiyat","Edebiyat","BTT","BTT","ProgTem","ProgTem"},
            };
            Console.SetCursorPosition(x, 0);
            Console.WriteLine(tekrarla(75, k));
            Console.WriteLine("{0} DERS PROGRAMI {0}", tekrarla(30, k));
            Console.WriteLine(tekrarla(75, k));
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(k + " ");
                    Console.Write(dizi[i, j]);
                    y = y + 1;
                    if (j == 0)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.Write(k);
                        Console.Write(tekrarla(a, k));
                        y = y + 1;
                    }
                }
                y = 3;
                x = x + a;

            }
            Console.WriteLine();
            Console.WriteLine(tekrarla(75, k));
            Console.WriteLine(tekrarla(75, k));
            for (int i = 0; i < 14; i++)
            {
                Console.SetCursorPosition(x - 1, i);
                Console.Write("*");
            }
            Console.ReadKey();
        }
    }
