using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;

namespace DAL
{
    public static class PersonaRepository
    {
        static List<Persona> personas = new List<Persona>();
        static string rutaArchivo = @"C:\Users\Estudiante\Desktop\PulsacionGUI\Personas.txt";
        static string rutaArchivoFiltrado = @"C:Users\Estudiante\Desktop\PulsacionGUI\PersonasFiltradas.txt";
        static FileStream fileStream;
        static StreamWriter escritor;
        static StreamReader streamReader;

        public static int TotalPersonas()
        {
            return personas.Count();
        }

        public static decimal TotalPulsaciones()
        {
            return personas.Sum(p => p.Pulsacion);
        }



        public static void Guardar(Persona persona, int tipo)
        {
            switch (tipo)
            {
                case 0: fileStream = new FileStream(rutaArchivo, FileMode.Append); break;
                case 1: fileStream = new FileStream(rutaArchivoFiltrado, FileMode.Append); break;
            }
            escritor = new StreamWriter(fileStream);
            EscribirPersona(escritor, persona);
            escritor.Close();
            fileStream.Close();
        }

        public static void EscribirPersona(StreamWriter escritor, Persona persona)
        {
            escritor.WriteLine(persona.Identificacion + "; " + persona.Apellidos + ";" + persona.Nombres
                + ";" + persona.Edad + ";" + persona.Genero + ";" + persona.Pulsacion);
        }

        public static List<Persona> Consultar(int tipo)
        {
            personas.Clear();
            switch (tipo)
            {
                case 0: fileStream = new FileStream(rutaArchivo, FileMode.OpenOrCreate, FileAccess.Read); break;
                case 1: fileStream = new FileStream(rutaArchivoFiltrado, FileMode.OpenOrCreate, FileAccess.Read); break;
            }
            streamReader = new StreamReader(fileStream);
            char delimitador = ';';
            string linea = string.Empty;

            while ((linea = streamReader.ReadLine()) != null)
            {
                Persona persona = new Persona();
                string[] person = linea.Split(delimitador);
                persona.Identificacion = person[0];
                persona.Apellidos = person[1];
                persona.Nombres = person[2];
                persona.Edad = Convert.ToInt32(person[3]);
                persona.Genero = person[4];
                persona.Pulsacion = Convert.ToDecimal(person[5]);
                personas.Add(persona);
            }
            fileStream.Close();
            streamReader.Close();
            return personas;
        }

        public static void Eliminar(Persona persona)
        {
            personas.Remove(persona);
            LimpiarArchivo(0);
            foreach (var itemPersona in personas)
            {
                Guardar(itemPersona,0);
            }
        }

        public static void Modificar(Persona old, Persona personaNueva)
        {
            personas.Remove(old);
            personas.Add(personaNueva);
            LimpiarArchivo(0);
            foreach (var itemPersona in personas)
            {
                Guardar(itemPersona, 0);
            }
        }

        public static Persona BuscarIdentificacion(string identificacion)
        {
            Consultar(0);
            return personas.Find(p => p.Identificacion.Equals(identificacion));
        }

        public static void LimpiarArchivo(int tipo)
        {
            switch (tipo)
            {
                case 0: fileStream = new FileStream(rutaArchivo, FileMode.Create); break;
                case 1: fileStream = new FileStream(rutaArchivoFiltrado, FileMode.Create); break;
            }
            fileStream.Close();
        }
    }
}
