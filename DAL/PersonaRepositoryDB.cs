using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entity;

namespace DAL
{
    public class PersonaRepositoryDB
    {
        private SqlConnection Conexion;
        private SqlDataReader Reader;
        private SqlCommand Comando;
        IList<Persona> personas = new List<Persona>();
        public PersonaRepositoryDB(SqlConnection conexion)
        {
            Conexion = conexion;
        }

        public void Guardar(Persona persona)
        {
            using (Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "INSERT INTO Persona (Identificacion,Apellido,Nombre,Edad,Genero,Pulsacion)VALUES"
                    +"(@Identificacion,@Apellido,@Nombre,@Edad,@Genero,@Pulsacion)";

                Comando.Parameters.Add("@Identificacion", System.Data.SqlDbType.VarChar).Value = persona.Identificacion;
                Comando.Parameters.Add("@Apellido", System.Data.SqlDbType.VarChar).Value = persona.Apellidos;
                Comando.Parameters.Add("@Nombre", System.Data.SqlDbType.VarChar).Value = persona.Nombres;
                Comando.Parameters.Add("@Edad", System.Data.SqlDbType.Int).Value = persona.Edad;
                Comando.Parameters.Add("@Genero", System.Data.SqlDbType.Char).Value = persona.Genero;
                Comando.Parameters.Add("@Pulsacion", System.Data.SqlDbType.Float).Value = persona.Pulsacion;
                Comando.ExecuteNonQuery();
            }
        }

        public IList<Persona> Consultar()
        {
            using (var comando = Conexion.CreateCommand()) 
            {
                Comando.CommandText = " Select * from Persona";
                Reader = Comando.ExecuteReader();
            
                while (Reader.Read())
                    {
                    Persona persona = new Persona();
                    persona.Map(Reader);
                    personas.Add(persona);
                }
            }
            return personas;
        }

       
   }





}
