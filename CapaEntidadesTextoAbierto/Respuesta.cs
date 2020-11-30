using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadesTextoAbierto
{
     public class Respuesta
    {
        public int Id_respuesta { get; set; }
        public int Id_cuestionario { get; set; }
        public string nombre_alumno { get; set; }
        public string respuesta { get; set; }

    }
}
