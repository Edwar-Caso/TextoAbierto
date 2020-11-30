using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadesTextoAbierto
{
    public class Presentacion
    {
        public int Id_presentacion { get; set; }
        public int Id_cuestionario { get; set; }
        public string pregunta { get; set; }
        public string descripcion { get; set; }
        public byte imagen { get; set; }
    }
}
