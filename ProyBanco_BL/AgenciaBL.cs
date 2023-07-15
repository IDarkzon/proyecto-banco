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
    public class AgenciaBL
    {
        AgenciaADO objAgenciaADO = new AgenciaADO();

        public DataTable ListarAgencia()
        {
            return objAgenciaADO.ListarAgencia();
        }
    }
}
