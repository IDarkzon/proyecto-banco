using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregar....
using System.Data;
using System.Data.SqlClient;
using ProyBanco_BE;

namespace ProyBanco_ADO
{
    public class ClienteADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarCliente()
        {
            try
            {
                DataSet dts = new DataSet();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarCliente";
                cmd.Parameters.Clear();

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Clientes");
                return dts.Tables["Clientes"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ClienteBE ConsultarCliente(String strCodigo)
        {
            try
            {
                ClienteBE objClienteBE = new ClienteBE();

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarCliente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigo", strCodigo);
                cnx.Open();

                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objClienteBE.Cod_Cli = dtr["Codigo"].ToString();
                    objClienteBE.Nom_Cli = dtr["Nombre"].ToString();
                    objClienteBE.Ape_pat_Cli = dtr["Apellido_Paterno"].ToString();
                    objClienteBE.Ape_mat_Cli = dtr["Apellido_Materno"].ToString();
                    objClienteBE.Num_doc_Cli = dtr["Numero_Documento"].ToString();
                    objClienteBE.Tip_doc_Cli = Convert.ToInt16(dtr["Tip_doc_Cli"]);
                    objClienteBE.Fec_nac_Cli = Convert.ToDateTime(dtr["Fecha_Nacimiento"]);
                    objClienteBE.Tel_Cli = dtr["Telefono"].ToString();
                    objClienteBE.Cor_Cli = dtr["Correo"].ToString();
                    objClienteBE.Dir_Cli = dtr["Direccion"].ToString();
                    objClienteBE.Id_Ubigeo = dtr["Id_Ubigeo"].ToString();
                    objClienteBE.Est_Cli = Convert.ToInt16(dtr["Est_Cli"]);
                }
                dtr.Close();
                return objClienteBE;
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

        public Boolean InsertarCliente(ClienteBE objClienteBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarCliente";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@Num_doc_Cli", objClienteBE.Num_doc_Cli);
                cmd.Parameters.AddWithValue("@Tip_doc_Cli", objClienteBE.Tip_doc_Cli);
                cmd.Parameters.AddWithValue("@Nom_Cli", objClienteBE.Nom_Cli);
                cmd.Parameters.AddWithValue("@Ape_pat_Cli", objClienteBE.Ape_pat_Cli);
                cmd.Parameters.AddWithValue("@Ape_mat_Cli", objClienteBE.Ape_mat_Cli);
                cmd.Parameters.AddWithValue("@Tel_Cli", objClienteBE.Tel_Cli);
                cmd.Parameters.AddWithValue("@Cor_Cli", objClienteBE.Cor_Cli);
                cmd.Parameters.AddWithValue("@Dir_Cli", objClienteBE.Dir_Cli);
                cmd.Parameters.AddWithValue("@Fec_nac_Cli", objClienteBE.Fec_nac_Cli);
                cmd.Parameters.AddWithValue("@Id_Ubigeo", objClienteBE.Id_Ubigeo);
                cmd.Parameters.AddWithValue("@Est_Cli", objClienteBE.Est_Cli);
                cmd.Parameters.AddWithValue("@Usu_Registro", objClienteBE.Usu_Registro);

                cnx.Open();
                cmd.ExecuteNonQuery();

                return true;
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

        public Boolean ActualizarCliente(ClienteBE objClienteBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarCliente";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@Cod_Cli", objClienteBE.Cod_Cli);
                cmd.Parameters.AddWithValue("@Num_doc_Cli", objClienteBE.Num_doc_Cli);
                cmd.Parameters.AddWithValue("@Tip_doc_Cli", objClienteBE.Tip_doc_Cli);
                cmd.Parameters.AddWithValue("@Nom_Cli", objClienteBE.Nom_Cli);
                cmd.Parameters.AddWithValue("@Ape_pat_Cli", objClienteBE.Ape_pat_Cli);
                cmd.Parameters.AddWithValue("@Ape_mat_Cli", objClienteBE.Ape_mat_Cli);
                cmd.Parameters.AddWithValue("@Tel_Cli", objClienteBE.Tel_Cli);
                cmd.Parameters.AddWithValue("@Cor_Cli", objClienteBE.Cor_Cli);
                cmd.Parameters.AddWithValue("@Dir_Cli", objClienteBE.Dir_Cli);
                cmd.Parameters.AddWithValue("@Fec_nac_Cli", objClienteBE.Fec_nac_Cli);
                cmd.Parameters.AddWithValue("@Id_Ubigeo", objClienteBE.Id_Ubigeo);
                cmd.Parameters.AddWithValue("@Est_Cli", objClienteBE.Est_Cli);
                cmd.Parameters.AddWithValue("@Usu_Ult_Mod", objClienteBE.Usu_Ult_Mod);

                cnx.Open();
                cmd.ExecuteNonQuery();

                return true;
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

        public Boolean EliminarCliente(String strCodigo)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarCliente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigo", strCodigo);

                cnx.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException x)
            {
                return false;
                throw new Exception(x.Message);
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
