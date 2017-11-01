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

        public override TipoNodo GetTipoNodo()
        {
            return TipoNodo.MostrarNode;
        }

        public override List<int> GetConjunto()
        {
            return this.c;
        }
    }
}
