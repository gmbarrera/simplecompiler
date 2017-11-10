using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCompiler
{
    public class ExtraerExpresionNode : ExpresionNode
    {
        private List<int> c;

        public ExtraerExpresionNode(List<int> c)
        {
            this.c = c;
        }

        public TipoNodo GetTipoNodo()
        {
            return TipoNodo.ExtraerNode;
        }

        public List<int> GetConjunto()
        {
            return this.c;
        }
    }
}
