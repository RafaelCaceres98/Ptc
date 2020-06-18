using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Persona
    {
        public string Identificacion { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public string Genero { get; set; }
        public int Edad { get; set; }
        public decimal Pulsacion { get; set; }

        public decimal CalcularPulsacion(String genero, int edad)
        {
            decimal pulsacion=0;
            if (genero.Equals("F"))
            {
                pulsacion = (210 - edad) / 10;
            }
            else
            {
                pulsacion = (220 - edad) / 10;
            }
            return pulsacion;
        }

        public void Map(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
