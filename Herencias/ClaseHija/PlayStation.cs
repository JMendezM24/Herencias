using Herencias.ClaseBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias.ClaseHija
{
    internal class PlayStation : ClsConsola
    {
        public string ModeloControlador { get; set; }
        public string MostrardetallesPS()
        {
            MostrarDetalles();
            return $"Modelo Controlador: {ModeloControlador}";
        }
    }
}
