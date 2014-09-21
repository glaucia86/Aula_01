using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proj_01.Model; //importanto a classe Modelo.

namespace Proj_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!!!!");
            Console.ReadKey();*/

            Pessoa p = new Pessoa();

            p.IdPessoa  = 1;
            p.Nome      = "Glaucia Lemos";
            p.Email     = "glaucia_lemos86@hotmail.com";

            Console.WriteLine("ID da Pessoa....: " + p.IdPessoa);
            Console.WriteLine("Nome do Cliente.....: " + p.Nome);
            Console.WriteLine("Email do Cliente.....: " + p.Email);

            Console.ReadKey();

        }
    }
}
