using ProyBanco_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyBanco_ADO
{
    public class UsuarioADO
    {
        // Instancias.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public UsuarioBE ConsultarUsuario(String strLogin)
        {
            try
            {
                UsuarioBE objUsuarioBE = new UsuarioBE();

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarUsuario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", strLogin);
                cnx.Open();

                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objUsuarioBE.Login_Usuario = dtr["Usuario"].ToString();
                    objUsuarioBE.Pass_Usuario = dtr["Contraseña"].ToString();
                    objUsuarioBE.Niv_Usuario = Convert.ToInt16(dtr["Nivel"]);
                    objUsuarioBE.Est_Usuario = Convert.ToInt16(dtr["Estado"]);
                    objUsuarioBE.Fec_Registro = Convert.ToDateTime(dtr["Fecha_Registro"]);
                    objUsuarioBE.Usu_Registro = dtr["Usuario_Registro"].ToString();
                }
                dtr.Close();
                return objUsuarioBE;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }
        }
    }
}
