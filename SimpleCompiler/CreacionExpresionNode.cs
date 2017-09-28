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

        public TipoNodo GetTipoNodo()
        {
            return TipoNodo.CreacionNode;
        }

        public List<int> GetConjunto()
        {
            return this.c;
        }
    }
}
