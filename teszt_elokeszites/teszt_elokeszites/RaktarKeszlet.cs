using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teszt_elokeszites
{
    public class RaktarKeszlet
    {
        public List<Tetel> raktar;

        public RaktarKeszlet()
        {
            raktar = new List<Tetel>();
        }

        public void UjTetelHozzaadasa(string megnevezes, string cikkszam, int mennyiseg, decimal egysegar)
        {
            raktar.Add(new Tetel { Megnevezes = megnevezes, Cikkszam = cikkszam, Mennyiseg = mennyiseg, Egysegar = egysegar });
        }

        public List<Tetel> RaktarLekerdezes()
        { return raktar; }

    }

    public class Tetel
    {
        public string Megnevezes { get; set; }
        public string Cikkszam { get; set; }
        public int Mennyiseg { get; set; }
        public decimal Egysegar { get; set; }
    }

    }
