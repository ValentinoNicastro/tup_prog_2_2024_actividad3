using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaHereda.Models
{
    public class Policia: Persona //La clase Policia hereda de la clase Persona
    {
        public int Nplaca { get; private set; }
        public Policia(int dni,string nom, int np): base(dni,nom)// la palabra reservada base transfiere 
        {                                                        // el valor ingresado del constructor Policia   
            Nplaca = np;                                         // al constructor Persona
        }
        override public string VerDatos() { // Al ser subclase de Persona con override puedo 
            string dat = $"Policia:{Nombre}\nDNI:{DNI}\nNro.Placa:{Nplaca}";//puedo modificar los metodos public de Persona
            return dat;
        }


    }
}
