using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadesTextoAbierto
{
    public class Reporte
    {
        public int Id_reporte { get; set; }
        public int Id_cuestionario { get; set; }
        public string pregunta { get; set; }
    }
}
