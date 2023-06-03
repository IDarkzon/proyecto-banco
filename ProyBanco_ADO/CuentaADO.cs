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
    public class CuentaADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarCuenta()
        {
            try
            {
                DataSet dts = new DataSet();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarCuenta";
                cmd.Parameters.Clear();

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Cuentas");
                return dts.Tables["Cuentas"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public CuentaBE ConsultarCuenta(String strCodigo)
        {
            try
            {
                CuentaBE objCuentaBE = new CuentaBE();

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarCuenta";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigo", strCodigo);
                cnx.Open();

                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objCuentaBE.Num_Cuen = dtr["Numero Cuenta"].ToString();
                    objCuentaBE.Tip_Mon = Convert.ToInt16(dtr["Tip_Mon"].ToString());
                    objCuentaBE.Sal_Cuen = Convert.ToSingle(dtr["Saldo Cuenta"].ToString());
                    objCuentaBE.Tipo = Convert.ToInt16(dtr["Tipo"].ToString());
                    objCuentaBE.Fec_Aper = Convert.ToDateTime(dtr["Fecha Apertura"].ToString());
                    objCuentaBE.Cod_Cli = dtr["Codigo Cliente"].ToString();
                    objCuentaBE.Cod_Age = dtr["Codigo Agencia"].ToString();
                    objCuentaBE.Est_Cuen = Convert.ToInt16(dtr["Est_Cuen"].ToString());
                }
                dtr.Close();
                return objCuentaBE;
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

        public Boolean InsertarCuenta(CuentaBE objCuentaBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarCuenta";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@tipoMoneda", objCuentaBE.Tip_Mon);
                cmd.Parameters.AddWithValue("@saldoCuenta", objCuentaBE.Sal_Cuen);
                cmd.Parameters.AddWithValue("@tipoCuenta", objCuentaBE.Tipo);
                cmd.Parameters.AddWithValue("@fecApertura", objCuentaBE.Fec_Aper);
                cmd.Parameters.AddWithValue("@codigoCliente", objCuentaBE.Cod_Cli);
                cmd.Parameters.AddWithValue("@codigoAgencia", objCuentaBE.Cod_Age);
                cmd.Parameters.AddWithValue("@estadoCuenta", objCuentaBE.Est_Cuen);
                cmd.Parameters.AddWithValue("@usuRegistro", objCuentaBE.Usu_Registro);

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

        public Boolean ActualizarCuenta(CuentaBE objCuentaBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarCuenta";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@Codigo", objCuentaBE.Num_Cuen);
                cmd.Parameters.AddWithValue("@tipoMoneda", objCuentaBE.Tip_Mon);
                cmd.Parameters.AddWithValue("@saldoCuenta", objCuentaBE.Sal_Cuen);
                cmd.Parameters.AddWithValue("@tipoCuenta", objCuentaBE.Tipo);
                cmd.Parameters.AddWithValue("@codigoCliente", objCuentaBE.Cod_Cli);
                cmd.Parameters.AddWithValue("@codigoAgencia", objCuentaBE.Cod_Age);
                cmd.Parameters.AddWithValue("@estadoCuenta", objCuentaBE.Est_Cuen);
                cmd.Parameters.AddWithValue("@UsuarioUltMod", objCuentaBE.Usu_Ult_Mod);

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

        public Boolean EliminarCuenta(String strCodigo)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarCuenta";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@codigo", strCodigo);

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
    }
}
