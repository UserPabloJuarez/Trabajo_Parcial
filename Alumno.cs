using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
   public class Alumno
    {
        //Estos serán las atributos que tengan los alumnos por ahora
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }

        public Alumno(string codigo, string nombre, string contraseña) //constructor
        {
            Codigo = codigo;
            Nombre = nombre;
            Contraseña = contraseña;
        }

    }
    public class Alumnos
    {
        //Se tendrá una lista donde se agregarán alumnos
        public static List<Alumno> Registro = new List<Alumno>();
        public static void Insertar_Alumno(Alumno nuevo)
        { Registro.Add(nuevo); }
        public bool Existe_Alumno(Alumno verificar)
        {
            return (Registro.Exists(x => x.Codigo.Equals(verificar.Codigo)));
        }

    }
}
