using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibreriaFrontEnd.Models
{
    public class Libros
    {
        public int ID { get; set; }
        public string Título { get; set; }
        public Nullable<int> IDAutor { get; set; }
    }
}