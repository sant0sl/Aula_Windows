using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDados_console.Classes
{
    class Cliente
    {
        [Key]
        public int UID { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string sexo { get; set; }
    }
}
