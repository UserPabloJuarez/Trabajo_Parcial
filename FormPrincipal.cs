using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class FormPrincipal : Form
    {
        Alumnos Registro_Alumnos;
        Profesor Registro_Profesor;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        public FormPrincipal(Alumnos _Registro_AlumnosA, Profesor _Registro_ProfesorB)
        {
            InitializeComponent();
            Registro_Alumnos = _Registro_AlumnosA;
            Registro_Profesor = _Registro_ProfesorB;
        }

        public FormPrincipal(string rol)
        {
            InitializeComponent();
            ActivaBotonRol(rol);

        }

        private void ActivaBotonRol(string rol)
        {

            bool bRol;
            bRol = (rol == "admin");
            btnAlumnos.Enabled = bRol;
            btnProfesores.Enabled = bRol;
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frma = new Form1(Registro_Alumnos);
            frma.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frma = new Form2(Registro_Profesor);
            frma.ShowDialog();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLoguearAlumno_Click(object sender, EventArgs e)
        {
            new FrmLogin().ShowDialog();
            this.Hide();
        }
    }
}
