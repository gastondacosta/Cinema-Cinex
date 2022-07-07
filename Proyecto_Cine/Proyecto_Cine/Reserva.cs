using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Cine
{
    public class Reservas
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int IdFuncion { get; set; }
        public int IdButaca { get; set; }
        public int IdTipoEntrada { get; set; }
        public DateTime FechaFuncion { get; set; }
        public string NombreCine { get; set; }
        public string NombrePelicula { get; set; }
        public int NumeroSala { get; set; }
    }
}
