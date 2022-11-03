using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libIntegrador.Models
{
    public class Medico:Persona
    {
        public string Especialidad { get; set; }
        public string Matricula { get; set; }
    }
}
