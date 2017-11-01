using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCompiler
{
    class ConjuntoExpresionNode : ExpresionNode
    {
        private List<int> c;

        public ConjuntoExpresionNode(List<int> c)
        {
            this.c = c;
        }
        
        public override TipoNodo GetTipoNodo()
        {
            return TipoNodo.ConjuntoNode;
        }

        public override List<int> GetConjunto()
        {
            return this.c;
        }
    }
}
