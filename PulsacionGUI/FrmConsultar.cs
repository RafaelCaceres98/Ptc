using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace PulsacionGUI
{
    public partial class FrmConsultar : Form
    {
        List<Persona> personas = new List<Persona>();
        List<Persona> personasFiltradas = new List<Persona>();

        public FrmConsultar()
        {
            InitializeComponent();
            btnConsultar.Focus();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            personas = PersonaService.Consultar(0);
            dtgvPersonas.DataSource = personas;
        }

        private void btnTotalPulsaciones_Click(object sender, EventArgs e)
        {
            decimal totalPulsaciones = PersonaService.TotalPulsaciones();
            string mensaje = $"Total pulsaciones {totalPulsaciones}";
            MessageBox.Show(mensaje,"",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnNumeroPersonas_Click(object sender, EventArgs e)
        {
            int totalPersonas = PersonaService.TotalPersonas();
            string mensaje = $"Total pulsaciones {totalPersonas}";
            MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbFiltarGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (personas.Count == 0)
            {
                string mensaje = "Primero presionar el boton de consultar";
                MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MapearPersonas(cmbFiltarGenero.SelectedItem.ToString());
                dtgvPersonas.DataSource = personasFiltradas;
            }
                
                
            
        }
        
        public void MapearPersonas(string genero)
        {
            personasFiltradas.Clear();
            dtgvPersonas.DataSource = "";
            if (genero.Equals("F"))
            {
                foreach (var itemPersona in personas)
                {
                    if (itemPersona.Genero.Equals(genero))
                    {
                        personasFiltradas.Add(itemPersona);
                    }
                }
            }else if (genero.Equals("M"))
            {
                foreach (var itemPersona in personas)
                {
                    if (itemPersona.Genero.Equals(genero))
                    {
                        personasFiltradas.Add(itemPersona);
                    }
                }
            }
        }

        private void btnGenerarArchivo_Click(object sender, EventArgs e)
        {
            if (personasFiltradas.Count==0)
            {
                string mensaje = "No ha filtrado por genero";
                MessageBox.Show(mensaje,"",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                PersonaService.LimpiarArchivo(1);
                foreach (var itemPersona in personasFiltradas)
                {
                    PersonaService.Guardar(itemPersona,1);
                }
                string mensaje = "Archivo generado correctamente";
                MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            PersonaService.Consultar(1);
            personas = personas.Where(p => (p.Genero.Equals("F") && (p.Edad==19))).ToList<Persona>();
            dtgvPersonas.DataSource = "";
            dtgvPersonas.DataSource = personas;
        }
    }
}
