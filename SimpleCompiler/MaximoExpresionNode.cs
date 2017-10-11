using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCompiler
{
    public class MaximoExpresionNode : ExpresionNode
    {
        private List<int> c;

        public MaximoExpresionNode(List<int> c)
        {
            this.c = c;
        }

        public List<int> GetConjunto()
        {
            return this.c;
        }

        public TipoNodo GetTipoNodo()
        {
            return TipoNodo.MaximoNode;
        }
    }
}
