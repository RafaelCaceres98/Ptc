using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;
using Entity;

namespace BLL
{
    public class PersonaServiceDB
    {
        PersonaRepositoryDB Persona;
        IList<Persona> personas;
        SqlConnection Conexion;
        public PersonaServiceDB()
        {
            //Conexion = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Persona;" 
            //    + "Integrated Security=SSPI;MultipleActiveResultSets=True");
            
            Conexion = new SqlConnection(@"SERVER=CPE;DATABASE=Persona;Integrated security=true");
            Persona = new PersonaRepositoryDB(Conexion);
        }

        public void Guardar(Persona persona)
        {
            try
            {
                Conexion.Open();
                Persona.Guardar(persona);
                Conexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
    public Persona Map(SqlDataReader Reader)
    {
        Persona persona = new Persona();
        persona.Identificacion = (string)Reader["Identificacion"];
        persona.Nombres = (string)Reader["Nombres"];
        persona.Genero = (string)Reader["Genero"];
        persona.Edad= (int)Reader["Edad"];
        persona.Pulsacion = (decimal)Reader["Pulsacion"];
        return persona;
        }

}
