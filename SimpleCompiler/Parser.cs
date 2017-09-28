using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleCompiler;

namespace Conjuntos.parser
{
    public class Parser
    {
        public LinkedList<Token> tokens;
        public Token lookahead;

        private Dictionary<String, List<int>> variables = new Dictionary<string,List<int>>();

        private void NextToken()
        {
            if (this.tokens.First != null)
            {
                this.lookahead = this.tokens.First.Value;
                this.tokens.RemoveFirst();
            }
            else
                this.lookahead = null;
        }

        private Tokenizer BuildTokenizer()
        {
            Tokenizer tokenizer = new Tokenizer();

            tokenizer.Add("\\[", Token.ABRIR_CORCHETE);
            tokenizer.Add("\\]", Token.CERRAR_CORCHETE);
            tokenizer.Add("\\(", Token.ABRIR_PARENTESIS);
            tokenizer.Add("\\)", Token.CERRAR_PARENTESIS);
            tokenizer.Add(",", Token.COMA);
            tokenizer.Add("=", Token.ASIGNACION);
            tokenizer.Add("set", Token.CREAR);
            tokenizer.Add("[0-9]+", Token.NUMERO);
            tokenizer.Add("[a-z]+", Token.VARIABLE);

            return tokenizer;
        }

        public void Parse(String code)
        {
            Tokenizer tokenizer = BuildTokenizer();
            tokenizer.Tokenize(code);
            var tokens = tokenizer.GetTokens();
            this.Parse(tokens);
        }

        private void Parse(List<Token> tokens)
        {
            this.tokens = new LinkedList<Token>();
            foreach (var item in tokens)
                this.tokens.AddLast(item);

            NextToken();

            while (this.lookahead != null)
            {
                ExpresionNode e = Expresion();
                e.GetConjunto().ForEach(i => Console.Write(i + ","));
                Console.WriteLine();
            }
        }

        private ExpresionNode Expresion()
        {
            ExpresionNode node = Conjunto();
            if (node != null)
                return node;

            node = Variable();
            if (node != null)
                return node;

            node = Creacion();
            if (node != null)
                return node;

            return null;
        }

        private VariableExpresionNode Variable()
        {
            List<int> c;

            if (this.lookahead.token == Token.VARIABLE)
            {
                String nombreVariable = this.lookahead.sequence;

                NextToken();
                if (this.lookahead != null && this.lookahead.token == Token.ASIGNACION)
                {
                    NextToken();
                    ExpresionNode exp = Expresion();
                    c = exp.GetConjunto();
                    this.variables.Add(nombreVariable, c);
                }
                else
                {
                    c = variables[nombreVariable];
                    if (c == null)
                        throw new Exception("Variable no definida");
                }
                return new VariableExpresionNode(c);
            }
            return null;
        }

        private ConjuntoExpresionNode Conjunto()
        {
            List<int> c = new List<int>();

            if (this.lookahead.token == Token.ABRIR_CORCHETE)
            {
                NextToken();
                while (this.lookahead != null && this.lookahead.token != Token.CERRAR_CORCHETE)
                {
                    if (this.lookahead.token == Token.NUMERO)
                        c.Add(Int32.Parse(this.lookahead.sequence));
                    else if (this.lookahead.token != Token.COMA)
                        throw new Exception("Error");

                    NextToken();
                }
                NextToken();

                return new ConjuntoExpresionNode(c);
            }

            return null;
        }

        private CreacionExpresionNode Creacion()
        {
             List<int> c = new List<int>();

             if (this.lookahead.token == Token.CREAR)
             {
                 NextToken();
                 if (this.lookahead.token != Token.ABRIR_PARENTESIS)
                     throw new Exception("Syntax error");

                 NextToken();
                 if (this.lookahead.token != Token.NUMERO)
                     throw new Exception("Syntax error");
                 int desde = Int32.Parse(this.lookahead.sequence);

                 NextToken();
                 if (this.lookahead.token != Token.COMA)
                     throw new Exception("Syntax error");

                 NextToken();
                 if (this.lookahead.token != Token.NUMERO)
                     throw new Exception("Syntax error");
                 int hasta = Int32.Parse(this.lookahead.sequence);

                 NextToken();
                 if (this.lookahead.token != Token.COMA)
                     throw new Exception("Syntax error");

                 NextToken();
                 if (this.lookahead.token != Token.NUMERO)
                     throw new Exception("Syntax error");
                 int salto = Int32.Parse(this.lookahead.sequence);

                 NextToken();
                 if (this.lookahead.token != Token.CERRAR_PARENTESIS)
                     throw new Exception("Syntax error");

                 NextToken();

                 for (int i = desde; i < hasta; i += salto)
                     c.Add(i);

                 return new CreacionExpresionNode(c);
             }
             return null;
        }
        




    }
}
