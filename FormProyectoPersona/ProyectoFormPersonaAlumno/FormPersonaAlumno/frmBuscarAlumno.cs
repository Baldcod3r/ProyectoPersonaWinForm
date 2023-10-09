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

namespace FormPersonaAlumno
{
    public partial class frmBuscarAlumno : Form
    {
        public frmBuscarAlumno()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string alumno = txtNombre.Text;
            string path = "C:\\Users\\Facundo\\OneDrive\\Escritorio\\registroAlumnos\\Alumno.txt";

            StreamReader archivoALeer = File.OpenText(path);
            string renglon;
            bool encuentra = false;
            bool finEncuentra = false;
            List<string> listAlumno = new List<string>();
            do
            {
                renglon = archivoALeer.ReadLine();
                if (alumno == renglon)
                {
                    encuentra = true;
                }
                if (encuentra && renglon == "*")
                {
                    listAlumno.Add(renglon);
                    finEncuentra = true;
                    encuentra = false;
                }
                else
                {
                    finEncuentra = false;
                }
                if (encuentra)
                {
                    listAlumno.Add(renglon);
                }

            } while (renglon != null);
            archivoALeer.Close();
            foreach(string a in listAlumno)
            {
                lstBoxAlumno.Items.Add(a);
            }



        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
