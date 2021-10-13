using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarketRace.Entity
{
    public class Repuesto
    {
        public int ID_RE { get; set; }
        public string SKU { get; set; }
        public string TITULO { get; set; }
        public string DESCRIPCION { get; set; }
        public decimal PRECIO { get; set; }
        public int CANTIDAD { get; set; }
        public string IMAGEN { get; set; }
        public int ID_MA { get; set; }
        public int ID_CA { get; set; }
        public int ESTADO { get; set; }
    }
}