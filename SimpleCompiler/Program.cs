using SimpleCompiler.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleParser
{
    class Program
    {
        static void Main(string[] args)
        {
            //String codigo = "var miconjunto = set() \n var oo = set() n = 653";
            String codigo = "[34,43]";
            Tokenizer tk = new Tokenizer();


            tk.Add("\\[", Token.ABRIR_CORCHETE);
            tk.Add("\\]", Token.CERRAR_CORCHETE);
            tk.Add(",", Token.COMA);
            tk.Add("=", Token.ASIGNACION);
            tk.Add("[0-9]+", Token.NUMERO);


            tk.Tokenize(codigo);
            List<Token> tokens = tk.GetTokens();
            tokens.ForEach(t => Console.WriteLine(t.sequence));

            Parser p = new Parser();

            p.Parse(tokens);

            Console.WriteLine("Listo.");
            Console.ReadKey();
        }
    }
}
