﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
//    IdEgreso int (Auto) Clave P
//Idproducto  int Clave F
//CodigoId    Varchar(30) Productos que se quieran identificar con algun codigo en la salida
//Cantidad    int
//FechaEgreso smalldatetime
//Observaciones   Varchar(50)
//IdUsuario int
//StockActual Int Stock antes del Egreso
//FechayHoraActualizacion smalldatetime
//Area    int
//Sector  int
//TipoSalida  char (1)	(I) nterna/(E) xterna/(A) juste Stock/Otros

    public class Egresos
    {
        public int IdEgreso { get; set; }
        public Productos oProductos { get; set; }
        public string CodigoId { get; set; }
        public int Cantidad {  get; set; }
        public string Observaciones { get; set; }
        public int IdUsuario { get; set; }
        public int StockActual { get; set; }
        public int Area { get; set; }
        public int Sector { get; set; }
        public char TipoSalida { get; set; }
    }
}
