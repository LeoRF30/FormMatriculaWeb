using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MatricuFastWeb.Model
{
    public class Usuario
    {
        public string usuarioID { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string correo { get; set; }
        public string clave { get; set; }
        public string adicionadoPor { get; set; }
        public DateTime fechaAdicion { get; set; }
        public string modificadoPor { get; set; }
        public DateTime fechaModificacion { get; set; }

    }
}