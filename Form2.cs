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
    public partial class Form2 : Form
    {
        Profesor Registro;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Profesor _Registro)
        {
            InitializeComponent();
            Registro = _Registro;

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
               // Profesor nuevo = new Profesor(textBox1.Text, textBox2.Text, textBox3.Text);
            }
        }
    }
}
