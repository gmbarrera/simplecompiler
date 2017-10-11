using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCompiler
{
    public enum TipoNodo
    {
        ExpresionNode = 1,
        VariableNode = 2,
        ConjuntoNode = 3,
        NumeroNode = 4,
        CreacionNode = 5,
        MostrarNode = 6,
    }

    public interface ExpresionNode
    {
        TipoNodo GetTipoNodo();
        List<int> GetConjunto();
    }
}
