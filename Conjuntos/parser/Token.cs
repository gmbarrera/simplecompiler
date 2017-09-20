using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjuntos.parser
{
    public class Token
    {
        public readonly int token;
        public readonly String sequence;

        public Token(int token, String sequence)
        {
            this.token = token;
            this.sequence = sequence;
        }
    }
}
