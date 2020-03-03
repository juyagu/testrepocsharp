using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjetosDeNegocios;

namespace BLL
{
    public static class AlumnosNet
    {
        public static List<AlumnoEntidad> ListAlumnos()
        {
            List<AlumnoEntidad> res = null;
            res = DAL.AlumnosNet.ListAlumnos();
            return res;
        }
    }
}
