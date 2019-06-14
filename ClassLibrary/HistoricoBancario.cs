using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class HistoricoBancario
    {

        public int id { get; set; }

        public string cpf { get; set; }

        public string mensagem { get; set; }

        public DateTime quando { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
