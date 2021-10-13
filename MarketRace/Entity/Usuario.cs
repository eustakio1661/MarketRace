using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarketRace.Entity
{
    public class Usuario
    {
       public int ID_US { get; set; }
       public string DNI { get; set; }
       public string NOMBRE { get; set; }
       public string APELLIDO { get; set; }
       public string TELEFONO { get; set; }
       public string DIRECCION { get; set; }
       public string CORREO { get; set; }
       public string CLAVE { get; set; }
       public int ID_RO { get; set; }
       public int ID_ES { get; set; }
       public string IMAGEN { get; set; }
    }
}