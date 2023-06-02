using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregar....
using System.Data;
using System.Data.SqlClient;
using ProyBanco_BE;
using System.Drawing;

namespace ProyBanco_ADO
{
    public class EmpleadoADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarEmpleado()
        {
            try
            {
                DataSet dts = new DataSet();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarEmpleado";
                cmd.Parameters.Clear();

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Empleados");
                return dts.Tables["Empleados"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }   

        }

        public EmpleadoBE ConsultarEmpleado(String strCodigo)
        {
            try
            {
                EmpleadoBE objEmpleadoBE = new EmpleadoBE();

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarEmpleado";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigo", strCodigo);
                cnx.Open();

                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objEmpleadoBE.Cod_Emp = dtr["Codigo"].ToString();
                    objEmpleadoBE.Nom_Emp = dtr["Nombre"].ToString();
                    objEmpleadoBE.Ape_pat_Emp = dtr["Apellido Paterno"].ToString();
                    objEmpleadoBE.Ape_mat_Emp = dtr["Apellido Materno"].ToString();
                    objEmpleadoBE.Num_doc_Emp = dtr["Numero Documento"].ToString();
                    objEmpleadoBE.Tip_doc_Emp = Convert.ToInt16(dtr["Tip_doc_Emp"].ToString());
                    objEmpleadoBE.Tel_Emp = dtr["Telefono"].ToString();
                    objEmpleadoBE.Cor_Emp = dtr["Correo"].ToString();
                    //objEmpleadoBE.Img_Emp = dtr[dtr.GetOrdinal("Imagen")] as byte[];
                    objEmpleadoBE.Img_Emp = (byte[])dtr["Imagen"];
                    objEmpleadoBE.Id_Ubigeo = dtr["Id_Ubigeo"].ToString();
                    objEmpleadoBE.Est_Emp = Convert.ToInt16(dtr["Est_Emp"]);
                }
                dtr.Close();
                return objEmpleadoBE;
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

        public Boolean InsertarEmpleado(EmpleadoBE objEmpleadoBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarEmpleado";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@Num_doc_Emp", objEmpleadoBE.Num_doc_Emp);
                cmd.Parameters.AddWithValue("@Tip_doc_Emp", objEmpleadoBE.Tip_doc_Emp);
                cmd.Parameters.AddWithValue("@Nom_Emp", objEmpleadoBE.Nom_Emp);
                cmd.Parameters.AddWithValue("@Ape_pat_Emp", objEmpleadoBE.Ape_pat_Emp);
                cmd.Parameters.AddWithValue("@Ape_mat_Emp", objEmpleadoBE.Ape_mat_Emp);
                cmd.Parameters.AddWithValue("@Tel_Emp", objEmpleadoBE.Tel_Emp);
                cmd.Parameters.AddWithValue("@Cor_Emp", objEmpleadoBE.Cor_Emp);
                cmd.Parameters.AddWithValue("@Img_Emp", objEmpleadoBE.Img_Emp);
                cmd.Parameters.AddWithValue("@Id_Ubigeo", objEmpleadoBE.Id_Ubigeo);
                cmd.Parameters.AddWithValue("@Est_Emp", objEmpleadoBE.Est_Emp);
                cmd.Parameters.AddWithValue("@Usu_Registro", objEmpleadoBE.Usu_Registro);

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
        
        public Boolean ActualizarEmpleado(EmpleadoBE objEmpleadoBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarEmpleado";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@Cod_Emp", objEmpleadoBE.Cod_Emp);
                cmd.Parameters.AddWithValue("@Num_doc_Emp", objEmpleadoBE.Num_doc_Emp);
                cmd.Parameters.AddWithValue("@Tip_doc_Emp", objEmpleadoBE.Tip_doc_Emp);
                cmd.Parameters.AddWithValue("@Nom_Emp", objEmpleadoBE.Nom_Emp);
                cmd.Parameters.AddWithValue("@Ape_pat_Emp", objEmpleadoBE.Ape_pat_Emp);
                cmd.Parameters.AddWithValue("@Ape_mat_Emp", objEmpleadoBE.Ape_mat_Emp);
                cmd.Parameters.AddWithValue("@Tel_Emp", objEmpleadoBE.Tel_Emp);
                cmd.Parameters.AddWithValue("@Cor_Emp", objEmpleadoBE.Cor_Emp);
                cmd.Parameters.AddWithValue("@Img_Emp", objEmpleadoBE.Img_Emp);
                cmd.Parameters.AddWithValue("@Id_Ubigeo", objEmpleadoBE.Id_Ubigeo);
                cmd.Parameters.AddWithValue("@Est_Emp", objEmpleadoBE.Est_Emp);
                cmd.Parameters.AddWithValue("@Usu_Ult_Mod", objEmpleadoBE.Usu_Ult_Mod);

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

        public Boolean EliminarEmpleado(String strCodigo)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarEmpleado";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@Cod_Emp", strCodigo);

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
