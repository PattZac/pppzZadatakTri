using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pppzZadatakTri
{
    class Neboder
    {
        private double visina;
        private int brojKatova;
        public double Visina { get => visina; set => visina = value; }
        public int BrojKatova { get => brojKatova; set => brojKatova = value; }

        public Neboder(double v, int bk)
        {
            Visina = v;
            BrojKatova = bk;
        }
        public override string ToString()
        {
            return "Broj Katove: " + BrojKatova + ", Visina Nebodera: "+Visina+"m." +
                "\r\nProsječnu visinu katova: "+Visina/BrojKatova+"m.";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Neboder Tower = new Neboder(200,100);
            Tower.Visina += 10;
            Tower.BrojKatova += 1;
            Console.WriteLine("Tower -\r\n"+Tower.ToString());
            Console.ReadKey();
        }
    }
}
