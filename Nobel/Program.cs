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
                    Console.WriteLine($"\t{dijas.Evszam}: {dijas.Keresztnev} {dijas.Vezeteknev} ({dijas.Tipus})");
                }
            }

            //7

            Console.WriteLine("7.feladat: ");
            Dictionary<string, int> dijtipusDarab = new Dictionary<string, int>();
            foreach (Dijazott dijas in dijasok)
            {
                string kulcs = dijas.Tipus;
                if(dijtipusDarab.ContainsKey(kulcs))
                {
                    dijtipusDarab[kulcs]++;
                }
                else
                {
                    dijtipusDarab.Add(kulcs, 1);
                }
            }

            foreach (KeyValuePair<string,int> item in dijtipusDarab)
            {
                Console.WriteLine($"\t{item.Key}: {item.Value} db");
            }

            //8

            List<string> orvosi = new List<string>();

            foreach (Dijazott dijas in dijasok)
            {
                string sor = "";
                if(dijas.Tipus == "orvosi")
                {
                    sor += dijas.Evszam;
                    sor += " :";
                    sor += dijas.Keresztnev + " ";
                    sor += dijas.Vezeteknev;
                    orvosi.Add(sor);
                }

            }
            File.WriteAllLines("orvosi.txt", orvosi, Encoding.UTF8);

            Console.ReadLine();
        }
    }
}
