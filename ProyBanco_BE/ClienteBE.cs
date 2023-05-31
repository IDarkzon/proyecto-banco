using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyBanco_BE
{
    public class ClienteBE
    {
		public String Cod_Cli { get; set; }
		public String Num_doc_Cli { get; set; }
		public Int16 Tip_doc_Cli { get; set; }
		public String Nom_Cli { get; set; }
		public String Ape_pat_Cli { get; set; }
		public String Ape_mat_Cli { get; set; }
		public String Tel_Cli { get; set; }
		public String Cor_Cli { get; set; }
		public String Dir_Cli { get; set; }
		public DateTime Fec_nac_Cli { get; set; }
		public String Id_Ubigeo { get; set; }
		public Int16 Est_Cli { get; set; }
        public String Usu_Registro { get; set; }
        public DateTime Fec_Registro { get; set; }
        public String Usu_Ult_Mod { get; set; }
        public DateTime Fec_Ult_Mod { get; set; }
    }
}
