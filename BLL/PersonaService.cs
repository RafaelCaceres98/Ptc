using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public static class PersonaService
    {
        public static void LimpiarArchivo(int tipo)
        {
            PersonaRepository.LimpiarArchivo(tipo);
        }

        public static void Guardar(Persona persona, int tipo)
        {
            PersonaRepository.Guardar(persona, tipo);
        }

        public static List<Persona> Consultar(int tipo)
        {
            return PersonaRepository.Consultar(tipo);
        }

        public static void Eliminar(Persona persona)
        {
            PersonaRepository.Eliminar(persona);
        }

        public static Persona BuscarIdentificacion(string identificacion)
        {
            return PersonaRepository.BuscarIdentificacion(identificacion);
        }

        public static int TotalPersonas()
        {
            return PersonaRepository.TotalPersonas();
        }

        public static decimal TotalPulsaciones()
        {
            return PersonaRepository.TotalPulsaciones();
        }
        
        public static void Modificar(Persona old, Persona personaNueva)
        {
            PersonaRepository.Modificar(old,personaNueva);
        }
    }
}
