using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyBanco_BE
{
    public class EmpleadoBE
    {
        public String Cod_Emp { get; set; }
        public String Num_doc_Emp { get; set; }
        public Int16 Tip_doc_Emp { get; set; }
        public String Nom_Emp { get; set; }
        public String Ape_pat_Emp { get; set; }
        public String Ape_mat_Emp { get; set; }
        public String Tel_Emp { get; set; }
        public String Cor_Emp { get; set; }
        public Byte[] Img_Emp { get; set; }
        public String Id_Ubigeo { get; set; }
        public Int16 Est_Emp { get; set; }
        public String Usu_Registro { get; set; }
        public DateTime Fec_Registro { get; set; }
        public String Usu_Ult_Mod { get; set; }
        public DateTime Fec_Ult_Mod { get; set; }
    }
}
