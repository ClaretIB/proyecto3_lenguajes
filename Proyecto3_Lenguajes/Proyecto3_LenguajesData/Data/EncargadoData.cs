using Proyecto3_LenguajesData.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto3_LenguajesData.Data
{
    public class EncargadoData
    {
        private String connectionString;
        public EncargadoData(String connectionString)
        {
            this.connectionString = connectionString;
        }
/*-------------------------------INSERTAR ENCARGADO--------------------------------------*/
       public Encargado insertarEncargado(Encargado encargado)
        {
            SqlConnection conexion = new SqlConnection(this.connectionString);
            SqlCommand cmdInsertarPelicula = new SqlCommand();
            cmdInsertarPelicula.CommandText = "InsertarEncargado";
            cmdInsertarPelicula.CommandType = System.Data.CommandType.StoredProcedure;
            cmdInsertarPelicula.Connection = conexion;

            //configurar los parametros
            cmdInsertarPelicula.Parameters.Add(new SqlParameter("@nombre", encargado.Nombre));
            cmdInsertarPelicula.Parameters.Add(new SqlParameter("@apellidos", encargado.Apellidos));
            cmdInsertarPelicula.Parameters.Add(new SqlParameter("@cedula", encargado.Cedula));
            cmdInsertarPelicula.Parameters.Add(new SqlParameter("@telefono", encargado.Telefono));
            cmdInsertarPelicula.Parameters.Add(new SqlParameter("@direccion", encargado.Direccion));
            cmdInsertarPelicula.Parameters.Add(new SqlParameter("@correo", encargado.Correo));

            conexion.Open();
            cmdInsertarPelicula.ExecuteNonQuery();
            
            conexion.Close();
            return encargado;
        }

/*--------------------------------------VERIFICA SI ENCARGADO YA EXISTE--------------------------------*/
    public int getEncargado(String cedula)
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            SqlCommand cmdGeneros =
                new SqlCommand("SELECT * FROM encargado ", conexion);
            conexion.Open();
            SqlDataReader drGeneros = cmdGeneros.ExecuteReader();
            while (drGeneros.Read())
            {
                if (drGeneros["cedula"].ToString()==cedula)
                {
                    return Int32.Parse(drGeneros["id"].ToString());
                }
                                
            }
            conexion.Close();
            return -1;
        }
        /*-------------------------Actualizar Contrasena----------------------------------------*/
        public int ActualizarContrasena(String contrasena, int id)
        {
            SqlConnection conexion = new SqlConnection(this.connectionString);
            SqlCommand cmdInsertarPelicula = new SqlCommand();
            cmdInsertarPelicula.CommandText = "ActualizarEncargadoContrasena";
            cmdInsertarPelicula.CommandType = System.Data.CommandType.StoredProcedure;
            cmdInsertarPelicula.Connection = conexion;

            //configurar los parametros
            cmdInsertarPelicula.Parameters.Add(new SqlParameter("@contrasena", contrasena));
            cmdInsertarPelicula.Parameters.Add(new SqlParameter("@id", id));

            conexion.Open();
            cmdInsertarPelicula.ExecuteNonQuery();

            conexion.Close();
            return id;
           
        }
        /*----------------------------------Actualizar ------------------------------------------*/
        public Encargado ActualizarEncargado(Encargado encargado)
        {
            SqlConnection conexion = new SqlConnection(this.connectionString);
            SqlCommand cmdInsertarPelicula = new SqlCommand();
            cmdInsertarPelicula.CommandText = "ActualizarEncargado";
            cmdInsertarPelicula.CommandType = System.Data.CommandType.StoredProcedure;
            cmdInsertarPelicula.Connection = conexion;

            //configurar los parametros
            cmdInsertarPelicula.Parameters.Add(new SqlParameter("@telefono", encargado.Telefono));
            cmdInsertarPelicula.Parameters.Add(new SqlParameter("@direccion", encargado.Direccion));
            cmdInsertarPelicula.Parameters.Add(new SqlParameter("@id", encargado.Id));
            cmdInsertarPelicula.Parameters.Add(new SqlParameter("@correo", encargado.Correo));


            conexion.Open();
            cmdInsertarPelicula.ExecuteNonQuery();

            conexion.Close();
            return encargado;
        }

        /*-----------------------------obtener encargado----------------------------*/
        public Encargado obtenerEncargado(String cedula)
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            SqlCommand cmdGeneros =
                new SqlCommand("SELECT * FROM encargado", conexion);
            conexion.Open();
            SqlDataReader drGeneros = cmdGeneros.ExecuteReader();
            Encargado genero = new Encargado();
            while (drGeneros.Read())
            {

                if (drGeneros["cedula"].ToString() == cedula)
                {
                    genero.Id = Int32.Parse(drGeneros["id"].ToString());
                    genero.Cedula = drGeneros["cedula"].ToString();
                    genero.Nombre = drGeneros["nombre"].ToString();
                    genero.Apellidos = drGeneros["apellidos"].ToString();
                    genero.Direccion = drGeneros["direccion"].ToString();
                    genero.Telefono = drGeneros["telefono"].ToString();
                    genero.Contrasena = drGeneros["contrasena"].ToString();
                    genero.Correo = drGeneros["correo"].ToString();
                }


            }//whilw
            conexion.Close();
            return genero;
        }
        /*-------------------------------eliminar-------------------------------*/
        public int EliminarEncargado(int id)
        {
            SqlConnection conexion = new SqlConnection(this.connectionString);
            SqlCommand cmdEli = new SqlCommand("DELETE FROM dbo.encargado WHERE id =" + id, conexion);
            conexion.Open();
            SqlDataReader drEstu = cmdEli.ExecuteReader();
            while (drEstu.Read())
            {
                return 0;
            }
            conexion.Close();
            return -1;

        }
        /**-//------------------------------ GetTodosEncargados--------*/
        public LinkedList<Encargado> GetAllEncargados()
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            SqlCommand cmdExamenes = new SqlCommand("Select * from encargado", conexion);
            conexion.Open();
            SqlDataReader drExamenes = cmdExamenes.ExecuteReader();
            LinkedList<Encargado> listaEstudiantes = new LinkedList<Encargado>();

            while (drExamenes.Read())
            {
                Encargado estudiante = new Encargado();
                estudiante.Id = Int32.Parse(drExamenes["id"].ToString());
                estudiante.Nombre = drExamenes["nombre"].ToString();
                estudiante.Apellidos = drExamenes["apellidos"].ToString();
                estudiante.Cedula = drExamenes["cedula"].ToString();
                estudiante.Telefono = drExamenes["telefono"].ToString();
                estudiante.Direccion = drExamenes["direccion"].ToString();
                estudiante.Contrasena = drExamenes["contrasena"].ToString();
                estudiante.Correo = drExamenes["correo"].ToString();

                listaEstudiantes.AddLast(estudiante);

            }//while    
            conexion.Close();

            return listaEstudiantes;
        }



    }

}
