using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoBimestralForms.Classes
{
    public class PC
    {

        public int uid_pc { get; set; } //not null
        public string processador { get; set; }//not null
        public string placaMae { get; set; }//not null
        public string fonte { get; set; }//not null
        public string coolerProcessador { get; set; }//not null
        public string memoriaRam { get; set; }//not null
        public string hd { get; set; }
        public string ssd { get; set; }
        public string placaDeVideo { get; set; }
        public string gabinete { get; set; }//not null
        public string cpfCliente { get; set; }//not null
        public int fk_tipoServico { get; set; }//not null
        public string observacoes { get; set; }
        public bool statuspc { get; set; }//not null

    }
}
