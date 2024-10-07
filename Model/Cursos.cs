using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MatricuFastWeb.Model
{
    public class Cursos
    {
        public string cursoID { get; set; }
        public string nombreCurso { get; set; }
        public int creditos { get; set; }
        public int horas { get; set; }
        public string adicionadoPor { get; set; }
        public DateTime fechaAdicion { get; set; }
        public string modificadoPor { get; set; }
        public DateTime fechaModificacion { get; set; }

    }
}