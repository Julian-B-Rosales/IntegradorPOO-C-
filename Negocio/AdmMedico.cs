using libIntegrador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class AdmMedico
    {
        public List<Medico> Listar()
        {
            List<Medico> lista = new List<Medico>();
            lista.Add(new Medico() { Apellido ="Ramirez", Nombre = "Diana", Especialidad = "Neurologia", ID = 1, Matricula = "Q23133"});
            lista.Add(new Medico() { Apellido ="Baez", Nombre = "Raul", Especialidad = "Pediatria", ID = 2, Matricula = "F98133"});
            lista.Add(new Medico() { Apellido ="Miranda", Nombre = "Isabel", Especialidad = "Pediatria", ID = 3, Matricula = "Q39422"});
            lista.Add(new Medico() { Apellido ="Klas", Nombre = "Juan", Especialidad = "Clinico", ID = 4, Matricula = "L134000"});
            lista.Add(new Medico() { Apellido ="Lucero", Nombre = "Manuel", Especialidad = "Clinico", ID = 5, Matricula = "G42009"});
            return lista;
        }

        public List<Medico> Listar(string especialidad)
        {
            //TODO Retornar medicos por especialidad
            return null;
        }

        public int Insertar(Medico medico)
        {
            //TODO Agregar medico a la lista
            return 0;
        }

        public int Eliminar(int id)
        {
            //TODO Elminar medico por id
            return 0;
        }

        public Medico TraerUno(int id)
        {
            //TODO Devolver medico por id
            return null;
        }
    }
}
