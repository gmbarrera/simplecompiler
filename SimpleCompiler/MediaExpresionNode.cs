using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCompiler
{
    class MediaExpresionNode : ExpresionNode
    {
        private List<int> c;

        public MediaExpresionNode(List<int> c)
        {
            this.c = c;
        }

        public List<int> GetConjunto()
        {
            return this.c;
        }

        public TipoNodo GetTipoNodo()
        {
            return TipoNodo.MediaNode;
        }
    }
}
