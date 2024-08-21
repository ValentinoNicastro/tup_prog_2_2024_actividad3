using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AnaHereda.Models
{
    public class Persona
    {
        public int DNI { get; private set; }
        public string Nombre { get; private set; }

        public Persona(int dni, string nom)
        {
            DNI = dni;
            Nombre = nom;
        }
       virtual public string VerDatos() //Me permite redefinir el metodo en las subclases heredadas de Persona
        {
            string dat = $"Persona:{Nombre}\nDNI:{DNI}";
            return dat;
        }
    }
}
