using DelegateDecompiler;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace Knockout002.Models
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        [Computed]
        [ScriptIgnore]
        [JsonIgnore]
        public string FullName
        {
            get { return Nombre + " " + Apellido; }
        }
    }
}