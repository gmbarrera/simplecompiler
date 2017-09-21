using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCompiler.Parser
{
    public class Parser
    {
        public LinkedList<Token> tokens;
        public Token lookahead;

        private void NextToken()
        {
            this.lookahead = this.tokens.First.Value;
            this.tokens.RemoveFirst();
        }

        public void Parse(List<Token> tokens)
        {
            this.tokens = new LinkedList<Token>();
            foreach (var item in tokens)
                this.tokens.AddLast(item);

            NextToken();

            Expresion();

        }

        private void Expresion()
        {
            Conjunto();
            Variable();

        }

        private void Variable()
        {
            if (this.lookahead.token == Token.VARIABLE)
            {
                //
                NextToken();
                if (this.lookahead.token == Token.ASIGNACION)
                {
                    //
                    NextToken();
                    Expresion();
                }
            }
        }

        private void Conjunto()
        {
            if (this.lookahead.token == Token.ABRIR_CORCHETE)
            {
                NextToken();
                Numero();
            }
        }

        private void Numero()
        {
            if (this.lookahead.token == Token.NUMERO)
            {
                //

                NextToken();

                if (this.lookahead.token == Token.COMA)
                    Coma();
                else if (this.lookahead.token == Token.CERRAR_CORCHETE)
                {
                    // termina definicion de conjunto

                }
                else
                {
                    throw new Exception("Error");
                }
            }
        }

        private void Coma()
        {
            //hacemos algo
        }




    }
}
