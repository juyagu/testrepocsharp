using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosDeNegocios
{
    public class AlumnoEntidad
    {
        public string nombre {get;set;}
        public string apellido { get; set; }
        public string curso { get; set; }
        public AlumnoEntidad() { }
        public AlumnoEntidad(string nombre, string apellido,string curso)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.curso = curso;
        }
    }
}
