using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace PulsacionGUI
{
    public partial class FrmPersona : Form
    {
        Persona persona, personaNueva;
        PersonaServiceDB personaServiceDB = new PersonaServiceDB();
        string mensaje;
        public FrmPersona()
        {
            InitializeComponent();
            cmbGenero.SelectedIndex = 0;
            PersonaService.Consultar(0);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ComprobarCampos())
            {
                Guardar();
            }
            else
            {
                mensaje = "Existen campos de informacion vacios";
                MessageBox.Show(mensaje,"",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        public void Guardar()
        {
            try
            {
                persona = new Persona();
                persona.Identificacion = txtIdentificacion.Text;
                persona.Apellidos = txtApellidos.Text;
                persona.Nombres = txtNombres.Text;
                persona.Edad = Convert.ToInt32(txtEdad.Text);
                persona.Genero = cmbGenero.Text;
                persona.Pulsacion = persona.CalcularPulsacion(persona.Genero, persona.Edad);
                txtPulsacion.Text = Convert.ToString(persona.Pulsacion);
                PersonaService.Guardar(persona, 0);
                personaServiceDB.Guardar(persona);
                MessageBox.Show("Informacion guardada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarCampos();
            }
            catch (Exception e)
            {
                mensaje = $"{e}";
                MessageBox.Show(mensaje,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void btnCalcularPulsacion_Click(object sender, EventArgs e)
        {
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            limpiarCampos();
        }

        private void Eliminar()
        {
            if (persona != null)
            {
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar a esta persona?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if (respuesta.Equals(DialogResult.Yes))
                {
                    PersonaService.Eliminar(persona);
                    string mensaje = "Persona eliminada correctamente";
                    MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                string mensaje = "Debes buscar una persona primero";
                MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdentificacion.TextLength != 0)
                {
                    persona = PersonaService.BuscarIdentificacion(txtIdentificacion.Text);
                    pintarInformacion(persona);
                }
                else
                {
                    string mensaje = "Digite identificacion a buscar";
                    MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdentificacion.Focus();
                }
            }
            catch (Exception)
            {
                string mensaje = "No. Identifiacion no encontrada";
                MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        public void pintarInformacion(Persona persona)
        {
            txtApellidos.Text = persona.Apellidos;
            txtIdentificacion.Text = persona.Identificacion;
            txtEdad.Text = persona.Edad.ToString();
            txtNombres.Text = persona.Nombres;
            txtPulsacion.Text = persona.Pulsacion.ToString();
            cmbGenero.Text = persona.Genero;
        }

        public void limpiarCampos()
        {
            txtApellidos.Text = "";
            txtIdentificacion.Text = "";
            txtEdad.Text = "";
            txtNombres.Text = "";
            txtPulsacion.Text = "";
            cmbGenero.Text = "";
        }

        private bool ComprobarCampos()
        {
            if ((txtApellidos.Text.Length != 0)  && (txtNombres.Text.Length!=0) && (txtIdentificacion.Text.Length!=0) 
                && (txtEdad.Text.Length!=0) && (cmbGenero.SelectedIndex!=0))
            {
                return true; ;
            }
            return false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (persona != null)
            {
                DialogResult respuesta = MessageBox.Show("¿Desea Modificar a esta persona?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta.Equals(DialogResult.Yes))
                {
                    personaNueva = new Persona();
                    personaNueva.Identificacion = txtIdentificacion.Text;
                    personaNueva.Nombres = txtNombres.Text;
                    personaNueva.Apellidos = txtApellidos.Text;
                    personaNueva.Edad = Convert.ToInt32(txtEdad.Text);
                    personaNueva.Genero = cmbGenero.Text;
                    personaNueva.Pulsacion = personaNueva.CalcularPulsacion(personaNueva.Genero,personaNueva.Edad);
                    PersonaService.Modificar(persona, personaNueva);
                    string mensaje = "Persona modificada correctamente";
                    MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCampos();
                }
            }
            else
            {
                string mensaje = "Debes buscar una persona primero";
                MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Persona CrearPersona()
        {
            return persona;
        }
    }
}
