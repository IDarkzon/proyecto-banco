using System.Data;
// Otros
using ProyBanco_ADO;

namespace ProyBanco_BL
{
    public class UbigeoBL
    {
        UbigeoADO objUbigeoADO = new UbigeoADO();

        public DataTable Ubigeo_Departamentos()
        {
            return objUbigeoADO.Ubigeo_Departamentos();
        }

        public DataTable Ubigeo_ProvinciasDepartamento(String strIdDep)
        {
            return objUbigeoADO.Ubigeo_ProvinciasDepartamento(strIdDep);
        }

        public DataTable Ubigeo_DistritosProvinciaDepartamento(String strIdDep, String strIdProv)
        {
            return objUbigeoADO.Ubigeo_DistritosProvinciaDepartamento(strIdDep, strIdProv);
        }
    }
}