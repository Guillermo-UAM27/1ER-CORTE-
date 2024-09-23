using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1ER_COTE
{
    public partial class RegistroDeEdadadGV : Form
    {
        private Registro registro = new Registro();
        private Operaciones operacion = new Operaciones();
        public RegistroDeEdadadGV()
        {
            InitializeComponent();
            // Agregar ciudades al ComboBox
            comboBoxCiudades.Items.Add("Leon");
            comboBoxCiudades.Items.Add("Masaya");
            comboBoxCiudades.Items.Add("Managua");
            comboBoxCiudades.SelectedIndex = 0; 
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string nombres = txtNombre.Text;
            string apellidos = txtApellidos.Text;
            DateTime fechaNacimiento = dateTimePickerFechaDeNacimiento.Value;
            string ciudad = comboBoxCiudades.SelectedItem.ToString();

            Persona nuevaPersona = new Persona(nombres, apellidos, fechaNacimiento, ciudad);
            registro.AgregarPersona(nuevaPersona);
            MessageBox.Show("Persona agregada correctamente.");
        }

        private void comboBoxCiudades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrarEdad_Click(object sender, EventArgs e)
        {
            Persona[] personas = registro.ObtenerPersonas();
            if (personas.Length > 0)
            {
                Persona ultimaPersona = personas.Last();
                int edad = operacion.CalcularEdad(ultimaPersona);
                bool mayorDeEdad = operacion.EsMayorDeEdad(ultimaPersona);
                string resultado = $"La edad de {ultimaPersona.Nombres} {ultimaPersona.Apellidos} es {edad} años.\n";
                resultado += mayorDeEdad ? "Es mayor de edad." : "Es menor de edad.";
                MessageBox.Show(resultado);
            }
            else
            {
                MessageBox.Show("No hay personas registradas.");
            }
        }
    }
}
