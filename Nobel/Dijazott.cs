using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nobel
{
    class Dijazott
    {
        public int Evszam { get; }
        public string Tipus { get; }
        public string Keresztnev { get; }
        public string Vezeteknev { get; }

        public Dijazott(string sor)
        {
            string[] s = sor.Split(';');
            Evszam = int.Parse(s[0]);
            Tipus = s[1];
            Keresztnev = s[2];
            Vezeteknev = s[3];
        }
    }
}
