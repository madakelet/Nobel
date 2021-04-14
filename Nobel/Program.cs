using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nobel
{
    class Program
    {
        static void Main(string[] args)
        {
            //2

            List<Dijazott> dijasok = new List<Dijazott>();
            string[] sorok = File.ReadAllLines("nobel.csv");
            foreach  (string sor in sorok.Skip(1))
            {
                dijasok.Add(new Dijazott(sor));
            }

            //3

            int hossz = dijasok.Count;
            int j = 0;
            while(j < hossz && !(dijasok[j].Keresztnev == "Arthur B." && dijasok[j].Vezeteknev == "McDonald"))
            {
                j++;
            }
            Console.WriteLine($"3. feladat: {dijasok[j].Tipus}");

            //4

            j = 0;
            while (j < hossz && !(dijasok[j].Evszam == 2017 && dijasok[j].Tipus == "irodalmi"))
            {
                j++;
            }

            Console.WriteLine($"4. feladat: {dijasok[j].Keresztnev} {dijasok[j].Vezeteknev}");

            //5

            Console.WriteLine("5. feladat:");
            foreach (Dijazott dijas in dijasok)
            {
                if(dijas.Evszam > 1989 && dijas.Vezeteknev == "")
                {
                    Console.WriteLine($"\t{dijas.Evszam}: {dijas.Keresztnev}");
                }
            }

            //6

            Console.WriteLine("6. feladat: ");
            foreach (Dijazott dijas in dijasok)
            {
                if(dijas.Vezeteknev.Contains("Curie"))
                {
                    Console.WriteLine($"\t{dijas.Evszam}: {dijas.Keresztnev} {dijas.Vezeteknev} {dijas.Tipus}");
                }
            }



            Console.ReadLine();
        }
    }
}
