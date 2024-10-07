using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MatricuFastWeb.Model
{
    public class Estudiantes
    {
        public string EstudianteID { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string carrera { get; set; }
        public int añoIngreso { get; set; }
        public string adicionadoPor { get; set; }
        public DateTime fechaAdicion { get; set; }
        public string modificadoPor { get; set; }
        public DateTime fechaModificacion { get; set; }

    }
}