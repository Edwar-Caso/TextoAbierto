using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using CapaEntidadesTextoAbierto;

namespace CapaDatosTextoAbierto
{
    public class CuestionarioDatos
    {
        public void Insertar(Pregunta Dcuestionario)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();
                const string sqlQuery =
                    "INSERT INTO Cuestionario (Id_Cuestionario, pregunta, descripcion, imagen) VALUES (@Id_Cuestionario, @pregunta, @descripcion, @imagen)";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
              
                    cmd.Parameters.AddWithValue("@Id_Cuestionario", Dcuestionario.Id_Cuestionario);
                    cmd.Parameters.AddWithValue("@pregunta", Dcuestionario.pregunta);
                    cmd.Parameters.AddWithValue("@descripcion", Dcuestionario.descripcion);
                    cmd.Parameters.AddWithValue("@imagen", Dcuestionario.imagen);

                    cmd.ExecuteNonQuery();
                }
            }


        }

        public void Actualizar(Pregunta Dcuestionario)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();
                const string sqlQuery =
                    "UPDATE Cuestionario SET pregunta = @pregunta, Descripcion = @descripcion, imagen = @imagen WHERE Id_Cuestionario = @Id_Cuestionario";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("@Id_Cuestionario", Dcuestionario.Id_Cuestionario);
                    cmd.Parameters.AddWithValue("@pregunta", Dcuestionario.pregunta);
                    cmd.Parameters.AddWithValue("@descripcion", Dcuestionario.descripcion);
                    cmd.Parameters.AddWithValue("@imagen", Dcuestionario.imagen); 

                    cmd.ExecuteNonQuery();
                }
            }


        }

        public void Eliminar(int Id_Cuestionario)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();
                const string sqlQuery = "DELETE FROM Cuestionario WHERE Id_Cuestionario = @Id_Cuestionario";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("@Id_Cuestionario", Id_Cuestionario);

                    cmd.ExecuteNonQuery();
                }
            }


        }

        public Pregunta GetByid(int Id_Cuestionario)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();

                const string sqlGetById = "SELECT * FROM Cuestionario WHERE Id_Cuestionario = @Id_Cuestionario";
                using (SqlCommand cmd = new SqlCommand(sqlGetById, cnx))
                {
                   
                    cmd.Parameters.AddWithValue("@Id_Cuestionario", Id_Cuestionario);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.Read())
                    {
                        Pregunta Lcuestionario = new Pregunta
                        {
                            Id_Cuestionario = Convert.ToInt32(dataReader["Id_Cuestionario"]),
                            pregunta = Convert.ToString(dataReader["pregunta"]),
                            descripcion = Convert.ToString(dataReader["descripcion"]),
                            imagen = Convert.ToByte(dataReader["Precio"])
                        };

                        return Lcuestionario;
                    }
                }
            }
            return null;
        }
    }
}
