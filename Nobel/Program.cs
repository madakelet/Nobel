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



            Console.ReadLine();
        }
    }
}
