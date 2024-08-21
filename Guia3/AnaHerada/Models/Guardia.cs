using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaHereda.Models
{
    public class Guardia
    {
        public int HoraDe { get; private set; }
        public int MinDe { get; private set; }
        public int HoraHa                          
        {        
            get 
            {
                int min = ((HoraDe * 60) + MinDe + TotalMin) % 60;
                return min;
            } 
        }
        public int MinHa
        { 
            get
            {
                int min = ((HoraDe * 60) + MinDe + TotalMin) / 60;
                return min;
            }
        }
        public int TotalMin { get; private set; }

        public Policia OfAsignado {  get; private set; }

        public Guardia()
        {

        }
        public void AsigPoli(Policia poli,int h,int m,int tm)
        {
            OfAsignado = poli;
            HoraDe = h;
            MinDe = m;
            TotalMin = tm;
        }

    }
}

