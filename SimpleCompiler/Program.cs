using Conjuntos.parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            //String codigo = "var miconjunto = set() \n var oo = set() n = 653";
            String codigo = "[34,43] ";
            codigo += "hola = [6,2]";
            codigo += "miconjunto = set(10,50,2) ";
            codigo += "sarasa = hola ";
            codigo += "sarasa ";

            Parser p = new Parser();
            p.Parse(codigo);


            Console.ReadKey();
        }
    }
}
