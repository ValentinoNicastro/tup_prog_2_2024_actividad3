using AnaHereda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaHerada.Models
{
    public  class Denuncia: Incidentes// hereda de la clase abstracta incidente 
    {
        public Denuncia(Policia oficial, Persona sujeto) : base(oficial, sujeto)
        {
            //el constructor se encarga de pasarle los datos a incidente a travez de base
        }
        override public string VerDescripcion()
        {
            string dat = $@"{OfaCargo.VerDatos()}
                            {Sujeto.VerDatos()}
                            Hora:{Hora}:{Min}
                            Motivo:{Motivo}";
            return dat;
        }

    }
}
