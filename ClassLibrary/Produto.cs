using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Produto
    {

        public int id { get; set; }
        public string descricao { get; set; }
        public decimal valorUnitario { get; set; }
        public int qtd { get; set; }

        public Produto() { }

        public Produto(int id, string descricao, decimal valorUnitario)
        {
            this.id = id;
            this.descricao = descricao;
            this.valorUnitario = valorUnitario;
        }
    }
}
