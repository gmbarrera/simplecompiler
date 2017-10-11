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
    }

    public interface ExpresionNode
    {
        TipoNodo GetTipoNodo();
        List<int> GetConjunto();
    }
}
