using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCompiler
{
    public class MostrarExpresionNode : ExpresionNode
    {
        private List<int> c;

        public MostrarExpresionNode(List<int> c)
        {
            this.c = c;
        }

        public TipoNodo GetTipoNodo()
        {
            return TipoNodo.MostrarNode;
        }

        public List<int> GetConjunto()
        {
            return this.c;
        }
    }
}
