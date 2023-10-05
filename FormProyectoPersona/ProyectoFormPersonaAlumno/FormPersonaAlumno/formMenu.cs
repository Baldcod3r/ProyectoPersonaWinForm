using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPersonaAlumno
{
    public partial class panelContenedor : Form
    {
        public panelContenedor()
        {
            InitializeComponent();
        }

        public void formMenu_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            if (SubmenuReportes.Visible == false)
            { 
                SubmenuReportes.Visible = true; 
            }
                
            else
            {
                SubmenuReportes.Visible = false;
            }
            
        }

        private void btnCrearAutos_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            AbrirFormEnPanel(new formAlumno());

        }

        private void AbrirFormEnPanel(Form formhija)
        {
            if (this.panelAlumno.Controls.Count > 0)            
                this.panelAlumno.Controls.RemoveAt(0);         

            formhija.TopLevel = false;                           
            formhija.Dock = DockStyle.Fill;                     
            this.panelAlumno.Controls.Add(formhija);        
            this.panelAlumno.Tag = formhija;                
            formhija.Show();                                    


        }
    }
}
