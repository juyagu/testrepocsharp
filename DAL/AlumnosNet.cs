using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjetosDeNegocios;

namespace DAL
{
    public static class AlumnosNet
    {
        public static List<AlumnoEntidad> ListAlumnos()
        {
            var contexto = new CSHARPEntities();
            List<AlumnoEntidad> res = null;
            //res = contexto.ALUMNOS.OrderBy(o => o.apellido).ToList();
            var resultado = from a in contexto.ALUMNOS
                            join c in contexto.CURSOS
                            on a.curso equals c.id_curso
                            select new AlumnoEntidad { nombre = a.nombre, apellido = a.apellido, curso = c.descripcion };
            res = resultado.ToList();
            return res;
        }
    }
}
