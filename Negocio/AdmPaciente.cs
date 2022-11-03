using libIntegrador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class AdmPaciente
    {
        public static List<Paciente> Listar()
        {
            List<Paciente> lista = new List<Paciente>();

            lista.Add(new Paciente() { Apellido = "Irigoyen", Nombre = "Roman", ID = 6, NroHistoriaClinica = 145123});
            lista.Add(new Paciente() { Apellido = "Videla", Nombre = "Silvio", ID = 7, NroHistoriaClinica = 3145});
            lista.Add(new Paciente() { Apellido = "Echegaray", Nombre = "Enrique", ID = 8, NroHistoriaClinica = 54236});
            lista.Add(new Paciente() { Apellido = "Pereyra", Nombre = "Jose", ID = 9, NroHistoriaClinica = 65346});
            lista.Add(new Paciente() { Apellido = "Totti", Nombre = "Irene", ID = 10, NroHistoriaClinica = 243555});


            return lista;
        }

        public static int Insertar(Paciente paciente)
        {
            //TODO Agregar paciente a la lista
            return 0;
        }

        public static int Eliminar(int id)
        {
            //TODO Elminar paciente por id
            return 0;
        }

        public static Paciente TraerUno(int nroHistClinica)
        {
            //TODO Devolver paciente por numero de historia clinica
            return null;
        }
    }
}
