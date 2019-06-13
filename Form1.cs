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
    public partial class Form1 : Form
    {

        //Alumnos Registro;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(Alumnos _Registro)
        {
            InitializeComponent();

            //Registro = _Registro;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length > 0 &&
                textBox2.Text.Trim().Length > 0 && textBox3.Text.Trim().Length > 0)
            {
                Alumno nuevo = new Alumno(textBox1.Text, textBox2.Text, textBox3.Text);
                Alumnos.Insertar_Alumno(nuevo);
                Show_Datos();

            }
        }
        private void Show_Datos()
        {
            Informacion.DataSource = null;
            Informacion.DataSource =Alumnos.Registro;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Show_Datos();
        }
    }
}
