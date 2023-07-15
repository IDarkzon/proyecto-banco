using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Otros
using ProyBanco_ADO;
using ProyBanco_BE;

namespace ProyBanco_BL
{
    public class ClienteBL
    {
        ClienteADO objClienteADO = new ClienteADO();

        public DataTable ListarCliente()
        {
            return objClienteADO.ListarCliente();
        }

        public ClienteBE ConsultarCliente(String strCodigo)
        {
            return objClienteADO.ConsultarCliente(strCodigo);
        }

        public ClienteBE ConsultarClienteDNI(String strDNI)
        {
            return objClienteADO.ConsultarClienteDNI(strDNI);
        }

        public Boolean InsertarCliente(ClienteBE objClienteBE)
        {
            return objClienteADO.InsertarCliente(objClienteBE);
        }

        public Boolean ActualizarCliente(ClienteBE objClienteBE)
        {
            return objClienteADO.ActualizarCliente(objClienteBE);
        }

        public Boolean EliminarCliente(String strCodigo)
        {
            return objClienteADO.EliminarCliente(strCodigo);
        }
    }
}
