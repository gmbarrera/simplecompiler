using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCompiler
{
    class NumeroExpresionNode : ExpresionNode
    {
        public override TipoNodo GetTipoNodo()
        {
            return TipoNodo.NumeroNode;
        }

        public override List<int> GetConjunto()
        {
            return null;
        }
    }
}
