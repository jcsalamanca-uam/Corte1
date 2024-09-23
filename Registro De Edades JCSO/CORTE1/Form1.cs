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

namespace CORTE1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CBCCiudad.Items.AddRange(new string[] { "Managua", "Masaya", "Granada" });

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Crear una nueva persona con los datos ingresados
            var nuevaPersona = new Persona
            {
                Nombres = TBNombres.Text,
                Apellidos = TBApellidos.Text,
                FechaNacimiento = DTPNacimiento.Value,
                Ciudad = CBCCiudad.SelectedItem?.ToString()
            };

            // Agregar la persona al registro
            Registro.AgregarPersona(nuevaPersona);
            MessageBox.Show("Persona agregada exitosamente.");
        }
    }
    public class Persona
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Ciudad { get; set; }


    }
    public class Registro
    {
        private Persona[] personas = new Persona[30];
        private int contador;

        public void AgregarPersona(Persona persona)
        {
            if (contador < 30)
                personas[contador++] = persona;
        }

        public void MostrarPersonas()
        {
            for (int i = 0; i < contador; i++)
                Console.WriteLine($"{personas[i].Nombres} {personas[i].Apellidos}, {personas[i].FechaNacimiento.ToShortDateString()}, {personas[i].Ciudad}");
        }
    }

    public class Operacion
    {
        public int CalcularEdad(DateTime fechaNacimiento)
        {
            int edad = DateTime.Now.Year - fechaNacimiento.Year;
            if (DateTime.Now < fechaNacimiento.AddYears(edad))
                edad--;
            return edad;
        }

        public string EsMayorDeEdad(DateTime fechaNacimiento)
        {
            return CalcularEdad(fechaNacimiento) >= 18 ? "Mayor de edad" : "Menor de edad";
        }
    }

}
