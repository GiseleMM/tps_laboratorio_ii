using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Entidades
{
    public static class PerrosDAO
    {
        private static string cadena_conexion;
        private static SqlConnection conexion;
        private static SqlCommand comando;
        private static SqlDataReader lector;

        static PerrosDAO()
        {

            cadena_conexion = $"Server=.;DataBase=TPFinal;trusted_connection=true;";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadena_conexion);
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;

        }
        public static bool ProbarConexion()
        {
            bool buenaConexion = true;
            try
            {
                conexion.Open();
            }
            catch (Exception)
            {
                buenaConexion = false;

            }
            finally
            {
                if (PerrosDAO.conexion.State == System.Data.ConnectionState.Open)
                {
                    PerrosDAO.conexion.Close();
                }
            }

            return buenaConexion;
        }
        /// <summary>
        /// Lee la lista de perros de la base de datos y con el id y idAdoptante los almanena en dictionary
        /// para luego recorrerla y obtener el adoptante para cada perro
        /// </summary>
        /// <returns></returns>
        public static List<Perro> ListarPerros()
        {
            List<Perro> listaPerros = new List<Perro>();
            Dictionary<int, int> idDniAdoptante = new Dictionary<int, int>();
            try
            {
                string sql = "SELECT * FROM PERROS ";
                comando.CommandText = sql;
                conexion.Open();
                using (lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        Perro p = new Perro(lector.GetString(1), lector.GetInt32(2), lector.GetString(3));
                        if (p is not null)
                        {
                            p.Id = lector.GetInt32(0);
                            p.ParaAdopcion = lector.GetBoolean(4);
                            if (p.ParaAdopcion == false)
                            {
                                idDniAdoptante.Add(p.Id, lector.GetInt32(5));//guardo dni de adoptante junto id de perro
                                
                            }

                        }
                        listaPerros.Add(p);
                    }
                }

            }
            catch (Exception)
            {
                listaPerros = null;
                throw; 
            }
            finally
            {
                if (PerrosDAO.conexion.State == System.Data.ConnectionState.Open)
                {
                    PerrosDAO.conexion.Close();
                }
            }
            foreach (KeyValuePair<int,int> item in idDniAdoptante)
            {
                Perro x=PerrosDAO.Leer(item.Key);
                x.Adoptante = AdoptanteDAO.Leer(item.Value);
            }

                return listaPerros;

        }
        public static Perro Leer(int id)
        {
            Perro perro = null;
            int dniAdoptante = 0;
            try
            {

                string sql = $"SELECT * FROM PERROS WHERE ID ={id}";
                comando.CommandText = sql;
                conexion.Open();
                using (lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        perro = new Perro(lector.GetString(1), lector.GetInt32(2), lector.GetString(3));
                        if (lector.GetBoolean(4) == false)
                        {
                            dniAdoptante = lector.GetInt32(5);

                        }
                    }
                }

            }
            catch (Exception)
            {
                perro = null;

            }
            finally
            {
                if (PerrosDAO.conexion.State == System.Data.ConnectionState.Open)
                {
                    PerrosDAO.conexion.Close();
                }
            }
            if (perro.ParaAdopcion == false)
            {
                perro += AdoptanteDAO.Leer(dniAdoptante);//solo pone a adoptante en atributo no lo suma a la lista de perros de adoptante
            }
            return perro;
        }
        public static bool Agregar(this Perro p)
        {
            bool rta = true;
            string sql = string.Empty;
            try
            {

                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@Edad", p.Edad);
                comando.Parameters.AddWithValue("@Nombre", p.Nombre);
                comando.Parameters.AddWithValue("@Refugio", p.Refugio);
                comando.Parameters.AddWithValue("@ParaAdopcion", p.ParaAdopcion ? 1 : 0);
                if (p.Adoptante is null)
                {
                    
                   sql= $"INSERT INTO PERROS (Nombre,Edad,Refugio,ParaAdopcion)";
                    sql += $" VALUES (@Nombre,@Edad,@Refugio,@ParaAdopcion)";
                }
                if (p.ParaAdopcion == false)
                {
                    comando.Parameters.AddWithValue("@IdAdoptante", p.Adoptante.Dni);
                    sql = $"INSERT INTO PERROS (Nombre,Edad,Refugio,ParaAdopcion,IdAdoptante)";
                    sql += $" VALUES (@Nombre,@Edad,@Refugio,@ParaAdopcion,@IdAdoptante)";
                }

               
                comando.CommandText = sql;
                conexion.Open();
              
                int filasAfectadas = comando.ExecuteNonQuery();
                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {

                rta = false;

            }
            finally
            {
                if (PerrosDAO.conexion.State == System.Data.ConnectionState.Open)
                {
                    PerrosDAO.conexion.Close();
                }
            }
            return rta;
        }

        public static bool ModificarDatos(this Perro p,string nombre,int edad,string refugio,bool paraAdopcion,int dni)
        {
            bool rta = true;
            string sql = string.Empty;
            try
            {


                conexion.Open();
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Edad", edad);
                comando.Parameters.AddWithValue("@Refugio", refugio);
              comando.Parameters.AddWithValue("@ParaAdopcion", paraAdopcion ? 1 : 0);
                comando.Parameters.AddWithValue("@Id", p.Id);
                if (dni != 0)
                {
                    comando.Parameters.AddWithValue("@IdAdoptante", dni);
                     sql = $"UPDATE Perros SET Nombre=@Nombre,Edad=@Edad,Refugio=@Refugio,ParaAdopcion=@ParaAdopcion,IdAdoptante=@IdAdoptante";
                    sql += " WHERE Id= @Id";
                }
                else
                {
                    sql = $"UPDATE Perros SET Nombre=@Nombre,Edad=@Edad,Refugio=@Refugio,ParaAdopcion=@ParaAdopcion";
                    sql += " WHERE Id= @Id";
                }
              
                comando.CommandText = sql;
                int filasAfectadas = comando.ExecuteNonQuery();
                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {

                rta = false;
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return rta;


        }
        public static bool Eliminar(this Perro p)
        {
            bool rta = true;
            try
            {
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Id", p.Id);

                string sql = $" DELETE FROM PERROS WHERE Id= @Id";
                conexion.Open();
                comando.CommandText = sql;
                int filasAfectadas = comando.ExecuteNonQuery();
                if (filasAfectadas == 0)
                {
                    rta = false;
                }
            }
            catch (Exception)
            {
                rta = false;

            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return rta;

        }
        public static List<Perro> LeerPerrosDeADoptante(int DNI)
        {
            List<Perro> listaAux = new List<Perro>();
            try
            {
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@IdAdoptante", DNI);
                string sql = $"SELECT * FROM PERROS WHERE IdAdoptante = @IdAdoptante";
                comando.CommandText = sql;
                conexion.Open();
                using (lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        Perro p = new Perro(lector.GetString(1), lector.GetInt32(2), lector.GetString(3));
                        p.Id = lector.GetInt32(0);
                        listaAux.Add(p);


                    }
                }

            }
            catch (Exception)
            {
                listaAux = null;
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return listaAux;
        }


    }
}

