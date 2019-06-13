using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    public class Profesor
    {
        //Atributos del profesor
        public string Nombre { get; set; }
        public string Seccion { get; set; }
        public string Curso { get; set; }
        // Los atributos que calificaremos del profesor

        public string Puntualidad { get; set; }
        public string Enseñanza { get; set; }
        public string Pizarra { get; set; }
        public string Empatia { get; set; }
        public string Creatividad { get; set; }

        public Profesor(string nombre, string seccion, string curso, string puntualidad, string enseñanza,
         string pizarra, string empatia, string creatividad)
        {
            Nombre = nombre;
            Seccion = seccion;
            Curso = curso;
            Puntualidad = puntualidad; 
            Enseñanza = enseñanza;
            Pizarra = pizarra;
            Empatia = empatia;
            Creatividad = creatividad;
        }
        public class Profesores
        {
            public List<Profesor> profesores = new List<Profesor>();
            public void Insertar_Profesor(Profesor nuevo)
            { profesores.Add(nuevo); }
            //public void Calificar_Profesor(Profesor calificado, string puntaje,int opcion) //dependiendo de cual opcion eliga sera calificado uno de los atributos
            //{
            //    if (profesores.Exists(x => x.Nombre.Equals(calificado.Nombre))
            //        && profesores.Exists(x=>x.Seccion.Equals(calificado.Seccion)))
            //    {
            //        switch(opcion)
            //        {
            //            case 1: profesores.Find(x => x.Nombre.Equals(calificado.Nombre)).Puntualidad = puntaje; break;
            //            case 2: profesores.Find(x => x.Nombre.Equals(calificado.Nombre)).Enseñanza = puntaje; break;
            //            case 3: profesores.Find(x => x.Nombre.Equals(calificado.Nombre)).Pizarra = puntaje; break;
            //            case 4: profesores.Find(x => x.Nombre.Equals(calificado.Nombre)).Empatia= puntaje; break;
            //            case 5: profesores.Find(x => x.Nombre.Equals(calificado.Nombre)).Creatividad = puntaje; break;
            //        }
            //    }
            //}
            public void Calificar_Puntualidad(Profesor calificado, string puntaje)
            {
                if (profesores.Exists(x => x.Nombre.Equals(calificado.Nombre)))
                {
                    profesores.Find(x => x.Nombre.Equals(calificado.Nombre)).Puntualidad = puntaje;
                }
            }
            public void Calificar_Enseñanza(Profesor calificado, string puntaje)
            {
                if (profesores.Exists(x => x.Nombre.Equals(calificado.Nombre)))
                {
                    profesores.Find(x => x.Nombre.Equals(calificado.Nombre)).Enseñanza = puntaje;
                }
            }
            public void Calificar_Pizarra(Profesor calificado, string puntaje)
            {
                if (profesores.Exists(x => x.Nombre.Equals(calificado.Nombre)))
                {
                    profesores.Find(x => x.Nombre.Equals(calificado.Nombre)).Pizarra = puntaje;
                }
            }
            public void Calificar_Empatia(Profesor calificado, string puntaje)
            {
                if (profesores.Exists(x => x.Nombre.Equals(calificado.Nombre)))
                {
                    profesores.Find(x => x.Nombre.Equals(calificado.Nombre)).Empatia = puntaje;
                }
            }
            public void Calificar_Creatividad(Profesor calificado, string puntaje)
            {
                if (profesores.Exists(x => x.Nombre.Equals(calificado.Nombre)))
                {
                    profesores.Find(x => x.Nombre.Equals(calificado.Nombre)).Creatividad = puntaje;
                }
            }
        }
        }
    }
