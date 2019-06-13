using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication4;

namespace WindowsFormsApplication4
{
    public class Login
    {
        public string admin = "admin";
        string retorno;

        public string Loguear (string rol, string codigo, string contrasena)
        {
            if (rol == "ADMINISTRADOR")
            {
                if (codigo == "admin" && contrasena == "123456")
                {
                    retorno = admin;
                }

                else
                {
                    retorno = "";
                }
            }
            else if (rol == "ALUMNO")
            {
               
                Alumno al = Alumnos.Registro.Find(x => x.Codigo == codigo && x.Contraseña == contrasena);
                if (al != null)
                {
                    retorno = "Alumno";

                }

                else
                {
                    retorno = "";
                }
                
            }
            return retorno;
        }
    }
}
