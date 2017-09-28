using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCompiler
{
    class NumeroExpresionNode : ExpresionNode
    {
        public TipoNodo GetTipoNodo()
        {
            return TipoNodo.NumeroNode;
        }

        public List<int> GetConjunto()
        {
            return null;
        }
    }
}
