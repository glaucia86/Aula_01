using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_02.Model
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public Endereco endereco { get; set; }//Um cliente possui um endereço:

    }
}
