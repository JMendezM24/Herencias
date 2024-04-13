﻿using Herencias.ClaseBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias.ClaseHija
{
    internal class Nintendo : ClsConsola
    {
        public bool EsPortatil { get; set; }
        public string MostrarDetallesNintendo()
        {
            MostrarDetalles();
            return $"Es portatil: {EsPortatil}";
        }
    }
}
