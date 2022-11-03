using libIntegrador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class AdmHabitacion
    {
        public static List<Habitacion> Listar()
        {
            List<Habitacion> lista = new List<Habitacion>();

            lista.Add(new Habitacion() { Estado = "Disponible", ID = 11, Numero = 200});
            lista.Add(new Habitacion() { Estado = "Ocupada", ID = 12, Numero = 201});
            lista.Add(new Habitacion() { Estado = "En Remodelacion", ID = 13, Numero = 202});
            lista.Add(new Habitacion() { Estado = "Ocupada", ID = 14, Numero = 203});
            lista.Add(new Habitacion() { Estado = "Disponible", ID = 15, Numero = 204});

            return lista;
        }

        public static List<Habitacion> Listar(string estado)
        {
            //TODO Retornar habitaciones por estado
            return null;
        }

        public static int Insertar(Habitacion habitacion)
        {
            //TODO Agregar habitacion a la lista
            return 0;
        }

        public static int Eliminar(int id)
        {
            //TODO Elminar habitacion por id
            return 0;
        }

        public static Habitacion TraerUno(int numero)
        {
            //TODO Devolver medico por id
            return null;
        }
    }
}
