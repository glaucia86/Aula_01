using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proj_02.Model;

namespace Proj_02
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();

            pf.IdCliente = 1;
            pf.Nome = "Glaucia Lemos";
            pf.Cpf = "000.000.000-11";

            pf.endereco = new Endereco();
            pf.endereco.Logradouro = "Rua Porto Santana, 316";
            pf.endereco.Estado = "Rio de Janeiro";

            //Saída de dados:
            Console.WriteLine("Id do Cliente.....: "  + pf.IdCliente);
            Console.WriteLine("Nome do Cliente....: " + pf.Nome);
            Console.WriteLine("CPF do Cliente.....: " + pf.Cpf);
            Console.WriteLine("Logradouro.....: " + pf.endereco.Logradouro );
            Console.WriteLine("Estado.....: " + pf.endereco.Estado);

            Console.ReadKey();
            
        }
    }
}
