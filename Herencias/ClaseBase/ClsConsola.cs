using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias.ClaseBase
{
    internal class ClsConsola
    {
        public string Marca { get; set; }
        public int AnioLanzamiento { get; set; }
        public void MostrarDetalles ()
        {
            Console.WriteLine($"Marca: {Marca}, año lanzamiento: {AnioLanzamiento}");
        }
    }
}
