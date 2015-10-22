using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Knockout002.Models
{
    public class Libro
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Año { get; set; }
    }
}