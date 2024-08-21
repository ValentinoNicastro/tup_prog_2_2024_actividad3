using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AnaHereda.Models
{
    public abstract class Incidentes //Declaor Incidentes como una clase abstracta lo cual significa que esta incompleta 
    {
        public int Hora { get; private set; }
        public int Min { get; private set; }
        public string Motivo { get; private set; }

        public Policia OfaCargo { get; private set; }
        public Persona Sujeto { get; private set; }

       public Incidentes(Policia oficial,Persona sujeto)
        {
            OfaCargo = oficial;
            Sujeto = sujeto; 
        }
        public void RegMotivo(int h,int m,string motivo)
        {
            Hora = h;
            Min = m;
            Motivo = motivo;
        }
        abstract public string VerDescripcion();// declaro ver descrp. como un metodo abstracto 
        

    }
}
