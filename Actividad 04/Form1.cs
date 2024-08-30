using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            //Obtener los datos 
            string nombres = txtNombre.Text;
            string apellido = txtApellido.Text;
            string telefono = txtTelefono.Text;
            string edad = txtEdad.Text;
            string estatura = txtEstatura.Text;

            //Genero Seleccionado 
            string genero = "";
            if (rbHombre.Checked)
            {
                genero = "Hombre";
            }
            else if (rbMujer.Checked)
            {
                genero = "Mujer";
            }
            //Cadena de Datos 
            string datos = $"Nombre: {nombres}\r\n  Apellidos: {apellido}\r\n   Telefono: {telefono}\r\n    Edad: {edad}\r\n    Estatura: {estatura}\r\n    Genero: {genero}";

            //Datos de un archivo
            string rutaArchivo = "C:/Users/orozc/OneDrive/Documentos/Abraham Enrique UNACH NSEMESTRE 3PROGRAMACION AVANZADA.txt";

            //Verificar si el archivo existe
            bool archivoexiste = File.Exists(rutaArchivo);

            using (StreamWriter writer = new StreamWriter(rutaArchivo))
            {
                if (archivoexiste)
                {
                    //Si el archivo existe añadir el separador
                    writer.WriteLine("======================");
                }
                writer.WriteLine(datos);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            //Limpiar txt rb
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtEdad.Clear();
            txtEstatura.Clear();
            rbHombre.Checked = false;
            rbMujer.Checked = false;
        }
    }

}
