using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCompiler
{
    public enum TipoNodo
    {
        ExpresionNode,
        VariableNode,
        ConjuntoNode,
        NumeroNode,
        CreacionNode,
        MostrarNode,
        MaximoNode,
        MinimoNode,
        MediaNode,
        ExtraerNode,
    }

    public abstract class ExpresionNode
    {
        public static int id = 0;

        public ExpresionNode()
        {
            ExpresionNode.id++;
        }

        public abstract TipoNodo GetTipoNodo();
        public abstract List<int>  GetConjunto();
    }
}
