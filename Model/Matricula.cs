using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MatricuFastWeb.Model
{
    public class Matricula
    {
        public string matriculaID { get; set; }
        public string estudianteID { get; set; }
        public string CursoID { get; set; }
        public DateTime fechaMatricula { get; set; }
        public string adicionadoPor { get; set; }
        public DateTime fechaAdicion { get; set; }
        public string modificadoPor { get; set; }
        public DateTime fechaModificacion { get; set; }

    }
}