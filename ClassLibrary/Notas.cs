using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Notas
    {

        public int id { get; set; }
        public int idAluno { get; set; }
        public int idMateria { get; set; }
        public decimal nota { get; set; }
        public DateTime quando { get; set; }

    }
}
