using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCompiler
{
    class MinimoExpresionNode : ExpresionNode
    {
        private List<int> c;

        public MinimoExpresionNode(List<int> c)
        {
            this.c = c;
        }

        public override List<int> GetConjunto()
        {
            return this.c;
        }

        public override TipoNodo GetTipoNodo()
        {
            return TipoNodo.MinimoNode;
        }
    }
}
