using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCore.Models
{
    public class AlumnoModel
    {
        public string Nombre { get; set; }
        public string App { get; set; }
        public string Apm { get; set; }
        public string NC { get; set; }
        public int Semestree { get; set; }
        public string Carrera { get; set; }
        public double Promedio { get; set; }
        public DateTime FechaIngreso { get; set; }
    }
}
