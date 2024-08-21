using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Net;
using AnaHerada.Models;
namespace AnaHereda.Models 
{ 
    public class Comisaria
    {
        Guardia[] guardia = new Guardia[2];
        ArrayList incidentes = new ArrayList();
        ArrayList agentes = new ArrayList();
        public int CantIns                
        {
            get 
            {
                return incidentes.Count;
            }
        }
        public Comisaria()
        {
            for(int i = 0;i < guardia.Length; i++)
            {
                guardia[i] = new Guardia(); 
            }
        }

        public bool AsigPoli(Policia poli)
        {                                
            if(CantIns < 2)
            {
                agentes.Add(poli);
                return true;
            }
            return false;
        }
        public Policia VerAgente(int np) 
        {
            Policia busq = null; 
            for (int i = 0; i < agentes.Count;i++)   
            {                               
                Policia poli = agentes[i] as Policia;
                if (poli != null && np == poli.Nplaca) 
                {
                    busq = poli;
                }
            }
            return busq;
        }
        public void RegistIncidente(Policia poli,Persona suj,string mot,int h,int m,int tipoI)
        {
            if (tipoI == 0) //Lo que hago es verificar si el incidente es un arresto o denuncia
            {              // si es arresto creo un obj de la clase arresto
                Arresto ins = new Arresto(poli,suj);
                ins.RegMotivo(h, m, mot);
                incidentes.Add(ins);
            }
            else // sino hago lo cotrario y lo guardo en denuncia 
            {
                Denuncia ins = new Denuncia(poli, suj);
                ins.RegMotivo(h, m, mot);
                incidentes.Add(ins);
            }
           
        }
        public void AsigGuardia(int num,int h1,int m1,int tm,Policia agente)
        {
            int i = 0;
            Guardia guard = guardia[i++]; 
            guard.AsigPoli(agente, h1, m1, tm);  
            
        }
        public Incidentes VerIncidentes(int idx)
        { 
            if(idx < CantIns) 
            {
                return incidentes[idx] as Incidentes;
            }
            return null; 
        }
        public Arresto VerArrestos(int idx)
        {
            if (idx < CantIns)
            {
                return incidentes[idx] as Arresto;
            }
            return null;
        }
        public Denuncia VerDenuncias(int idx)
        {
            if ( idx < CantIns)
            {
                return incidentes[idx] as Denuncia;
            }
            return null;
        }
    }
}
