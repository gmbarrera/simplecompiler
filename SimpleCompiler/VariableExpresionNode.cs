using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCompiler
{
    class VariableExpresionNode : ExpresionNode
    {
        private List<int> c;

        public VariableExpresionNode(List<int> c)
        {
            this.c = c;
        }

        public TipoNodo GetTipoNodo()
        {
            return TipoNodo.VariableNode;
        }

        public List<int> GetConjunto()
        {
            return this.c;
        }
    }
}
