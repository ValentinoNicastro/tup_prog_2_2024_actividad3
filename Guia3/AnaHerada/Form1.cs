using AnaHerada.Models;
using AnaHereda.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnaHerada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Comisaria comi = new Comisaria();
        private void button1_Click(object sender, EventArgs e)
        {
            
            string nom = tbxNomPoli.Text;
            int dni = Convert.ToInt32(tbxDNIPoli.Text);
            int placa = Convert.ToInt32(cmbPlaca.Text);
            Policia p1 = new Policia(dni, nom, placa);
            comi.AsigPoli(p1);
            tbxNomPoli.Clear();
            tbxDNIPoli.Clear();
            
        }

        private void btnAsgGuar_Click(object sender, EventArgs e)
        {

            int nro = Convert.ToInt32(nudNroGua.Value);
            int h = Convert.ToInt32(nudHD.Value);
            int m = Convert.ToInt32(nudMD.Value);
            int tm = Convert.ToInt32(nudTM.Value);
            Policia poli = comi.VerAgente(nro);
            comi.AsigGuardia(nro,h,m,tm,poli);
            
        }

        private void btnRegIns_Click(object sender, EventArgs e)
        {
            string nom = tbxPersona.Text;
            string mot = tbxMotivo.Text;
            int dni = Convert.ToInt32(tbxDNI.Text);
            int h = Convert.ToInt32(nudHora.Value);
            int m = Convert.ToInt32(nudMin.Value);
            int placa = Convert.ToInt32(cmbRegPoli.Text);
            int tipoI = Convert.ToInt32(cmbTipoI.SelectedIndex);
            Policia agente = comi.VerAgente(placa);
            Persona suj = new Persona(dni,nom);
            comi.RegistIncidente(agente,suj,mot,h,m,tipoI);
            tbxPersona.Clear();
            tbxMotivo.Clear();
        }

        private void btnListIns_Click(object sender, EventArgs e)
        {
            FormListar nacho = new FormListar();
            if (chbxArresto.Checked == true)
            {
                for (int i = 0; i < comi.CantIns; i++)
                {
                    Arresto ins = comi.VerArrestos(i);
                    nacho.tbxListar.Text = ins.VerDescripcion();
                }
            }
            else
            {
                if (chbxDenuncia.Checked == true)
                {
                    for (int i = 0; i < comi.CantIns; i++)
                    {
                        Denuncia ins = comi.VerDenuncias(i);
                        nacho.tbxListar.Text = ins.VerDescripcion();
                    }
                }
            }
            for (int i = 0; i < comi.CantIns; i++)
            {
                Incidentes ins = comi.VerIncidentes(i);
                nacho.tbxListar.Text = ins.VerDescripcion();
            }
            nacho.ShowDialog();
            nacho.Dispose();
        }
    }
}
