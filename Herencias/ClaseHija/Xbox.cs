using Herencias.ClaseBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias.ClaseHija
{
    internal class Xbox: ClsConsola
    {
        public string XboxGamePass { get; set; }
        public string MostarDetallesXbox()
        {
            MostrarDetalles();
            return $"GamePass: {XboxGamePass}";
        }
    }
}
