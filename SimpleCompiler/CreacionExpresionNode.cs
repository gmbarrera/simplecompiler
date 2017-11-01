using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCompiler
{
    public class CreacionExpresionNode : ExpresionNode
    {
        private List<int> c;

        public CreacionExpresionNode(List<int> c)
        {
            this.c = c;
        }

        public override TipoNodo GetTipoNodo()
        {
            return TipoNodo.CreacionNode;
        }

        public override List<int> GetConjunto()
        {
            return this.c;
        }
    }
}
