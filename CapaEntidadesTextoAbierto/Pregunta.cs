using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadesTextoAbierto
{
    public class Pregunta
    {
        public int IdPregunta { get; set; }
        public string pregunta { get; set; }
        public string descripcion { get; set; }
        public byte imagen { get; set; }
        public int IdProfesor { get; set; }

    }
}
