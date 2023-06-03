using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyBanco_BE
{
    public class CuentaBE
    {
        public String Num_Cuen { get; set; }
        public Int16 Tip_Mon { get; set; }
        public Single Sal_Cuen { get; set; }
        public Int16 Tipo { get; set; }
        public DateTime Fec_Aper { get; set; }
        public String Cod_Cli { get; set; }
        public String Cod_Age { get; set; }
        public Int16 Est_Cuen { get; set; }
        public String Usu_Registro { get; set; }
        public DateTime Fec_Registro { get; set; }
        public String Usu_Ult_Mod { get; set; }
        public DateTime Fec_Ult_Mod { get; set; }
    }
}
