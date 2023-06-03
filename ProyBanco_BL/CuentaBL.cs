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
    public class CuentaBL
    {
        CuentaADO objCuentaADO = new CuentaADO();

        public DataTable ListarCuenta()
        {
            return objCuentaADO.ListarCuenta();
        }

        public CuentaBE ConsultarCuenta(String strCodigo)
        {
            return objCuentaADO.ConsultarCuenta(strCodigo);
        }

        public Boolean InsertarCuenta(CuentaBE objCuentaBE)
        {
            return objCuentaADO.InsertarCuenta(objCuentaBE);
        }

        public Boolean ActualizarCuenta(CuentaBE objCuentaBE)
        {
            return objCuentaADO.ActualizarCuenta(objCuentaBE);
        }

        public Boolean EliminarCuenta(String strCodigo)
        {
            return objCuentaADO.EliminarCuenta(strCodigo);
        }
    }
}
