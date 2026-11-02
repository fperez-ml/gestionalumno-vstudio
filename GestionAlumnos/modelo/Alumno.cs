using System;
using System.Collections.Generic;
using System.Text;

namespace GestionAlumnos.modelo
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public string Curso { get; set; }


        public Alumno() { 
        
        }

        public Alumno(string nombre, string curso)
        {
            this.Nombre = nombre;
            this.Curso = curso;
        }
    }
}
