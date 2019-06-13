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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Login oLogin = new Login();
            string rol=oLogin.Loguear(cmbRol.SelectedItem.ToString(), txtCodigo.Text.Trim(), txtContrasena.Text.Trim());

            if (rol=="")
            {
                MessageBox.Show("Usuario no válido");
            }

            else
            {
                this.Hide();
                new FormPrincipal(rol).Show();
            }
        }
    }
}
