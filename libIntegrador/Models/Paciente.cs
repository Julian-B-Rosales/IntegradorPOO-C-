using libIntegrador.Models.Ayudantes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libIntegrador.Models
{
    public class Paciente:Persona
    {
        public int NroHistoriaClinica { get; set; }
		private int edad;

		public int Edad
		{
			get {
				edad = UtilidadesFechas.CalcularEdad(FechaNacimiento);
				return edad;
			}
		}

		public DateTime FechaNacimiento { get; set; }

	}
}
