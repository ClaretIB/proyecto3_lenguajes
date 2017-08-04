using Proyecto3_LenguajesData.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto3_LenguajesData.Data
{
    public class EstudianteData
    {
        private String connectionString;
        public EstudianteData(String connectionString)
        {
            this.connectionString = connectionString;
        }

        public Estudiante InsertarEstudiante(Estudiante estudiante)
        {
            SqlConnection conexion = new SqlConnection(this.connectionString);
            SqlCommand cmdInsertarPelicula = new SqlCommand();
            cmdInsertarPelicula.CommandText = "InsertarEstudiante";
            cmdInsertarPelicula.CommandType = System.Data.CommandType.StoredProcedure;
            cmdInsertarPelicula.Connection = conexion;

            //configurar los parametros
            cmdInsertarPelicula.Parameters.Add(new SqlParameter("@nombre", estudiante.Nombre));
            cmdInsertarPelicula.Parameters.Add(new SqlParameter("@apellidos", estudiante.Apellidos));
            cmdInsertarPelicula.Parameters.Add(new SqlParameter("@cedula", estudiante.Cedula));
            cmdInsertarPelicula.Parameters.Add(new SqlParameter("@cedula_encargado", estudiante.Encargado));
            cmdInsertarPelicula.Parameters.Add(new SqlParameter("@grado", estudiante.Grado));

            conexion.Open();
            cmdInsertarPelicula.ExecuteNonQuery();

            conexion.Close();
            return estudiante;
        }

        public int EliminarEstudiante(int id)
        {
            SqlConnection conexion = new SqlConnection(this.connectionString);
            SqlCommand cmdEli = new SqlCommand("DELETE FROM dbo.estudiante WHERE id ="+id, conexion);
            conexion.Open();
            SqlDataReader drEstu = cmdEli.ExecuteReader();
            while (drEstu.Read())
            {
                return 0;
            }
            conexion.Close();
            return -1;
          
        }

        public Estudiante GetEstudiante(String cedula)
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            SqlCommand cmdGeneros =
                new SqlCommand("SELECT * FROM estudiante", conexion);
            conexion.Open();
            SqlDataReader drGeneros = cmdGeneros.ExecuteReader();
            Estudiante genero = new Estudiante();
            while (drGeneros.Read())
            {
               
                if (drGeneros["cedula"].ToString() == cedula)
                {
                    genero.Id = Int32.Parse(drGeneros["id"].ToString());
                    genero.Cedula = drGeneros["cedula"].ToString();
                    genero.Nombre = drGeneros["nombre"].ToString();
                    genero.Apellidos = drGeneros["apellidos"].ToString();
                    genero.Grado = drGeneros["grado"].ToString();
                    genero.Encargado = drGeneros["cedula_encargado"].ToString();
                }
                
                  
            }//whilw
            conexion.Close();
            return genero;
        }
        /*------------------------Actualiza estudiante---------------------------*/
        public Estudiante ActualizarEstudiante(Estudiante estudiante)
        {
            SqlConnection conexion = new SqlConnection(this.connectionString);
            SqlCommand cmdInsertarPelicula = new SqlCommand();
            cmdInsertarPelicula.CommandText = "ActualizarEstudiante";
            cmdInsertarPelicula.CommandType = System.Data.CommandType.StoredProcedure;
            cmdInsertarPelicula.Connection = conexion;

            //configurar los parametros
            cmdInsertarPelicula.Parameters.Add(new SqlParameter("@grado", estudiante.Grado));
            cmdInsertarPelicula.Parameters.Add(new SqlParameter("@id", estudiante.Id));

            conexion.Open();
            cmdInsertarPelicula.ExecuteNonQuery();

            conexion.Close();
            return estudiante;
        }
        /*----------------------------cambia cedula encargado------------------------*/
        public int cambiarEncargado(int idEstudiante, String cedulaEncargado)
        {
            SqlConnection conexion = new SqlConnection(this.connectionString);
            SqlCommand cmdInsertarPelicula = new SqlCommand();
            cmdInsertarPelicula.CommandText = "CambiarEncargado";
            cmdInsertarPelicula.CommandType = System.Data.CommandType.StoredProcedure;
            cmdInsertarPelicula.Connection = conexion;

            //configurar los parametros
            cmdInsertarPelicula.Parameters.Add(new SqlParameter("@id", idEstudiante));
            cmdInsertarPelicula.Parameters.Add(new SqlParameter("@cedulaEncargado", cedulaEncargado));

            conexion.Open();
            cmdInsertarPelicula.ExecuteNonQuery();

            conexion.Close();
            return idEstudiante;
        }
        /*-----------------------get todos los estudiantes------------------------*/
        public LinkedList<Estudiante> GetAllEstudiantes()
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            SqlCommand cmdExamenes = new SqlCommand("Select * from estudiante", conexion);
            conexion.Open();
            SqlDataReader drExamenes = cmdExamenes.ExecuteReader();
            LinkedList<Estudiante> listaEstudiantes = new LinkedList<Estudiante>();

            while (drExamenes.Read())
            {
                Estudiante estudiante = new Estudiante();
                estudiante.Id = Int32.Parse(drExamenes["id"].ToString());
                estudiante.Nombre = drExamenes["nombre"].ToString();
                estudiante.Apellidos = drExamenes["apellidos"].ToString();
                estudiante.Cedula = drExamenes["cedula"].ToString();
                estudiante.Grado = drExamenes["grado"].ToString();
                estudiante.Encargado = drExamenes["cedula_encargado"].ToString();

                listaEstudiantes.AddLast(estudiante);

            }//while    
            conexion.Close();

            return listaEstudiantes;
        }
    }
}
