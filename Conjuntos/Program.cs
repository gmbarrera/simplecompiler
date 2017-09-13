using Conjuntos.parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Conjuntos.parser.Tokenizer;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            String codigo = "var miconjunto = Set() \n var oo = Set() n = 653";
            Tokenizer tk = new Tokenizer();

            tk.Add("var", 1);
            tk.Add("[a-z]+", 2);
            tk.Add("[0-9]+", 3);
            tk.Add("=", 4);
            tk.Add("Set|Int|Uni|Ext|If|Then|EndIf|For|In|Do|EndFor|Max|Min|Push|Med|Len", 5);
            tk.Add("\\(", 6);
            tk.Add("\\)", 7);
            tk.Add("\\[", 8);
            tk.Add("\\]", 9);
            tk.Add("\\'", 10);

            tk.Tokenize(codigo);
            List<Token> tokens = tk.GetTokens();
            tokens.ForEach(t => Console.WriteLine(t.sequence));
           


            Console.ReadKey();
        }
    }
}
