﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCompiler.Parser
{
    public class Token
    {
        public const int MAXIMO = 0;
        public const int MINIMO = 1;
        public const int MEDIANA = 2;
        public const int INTERSECCION = 3;
        public const int UNION = 4;
        public const int EXTRAER = 5;
        public const int CREAR = 6;
        public const int LONGITUD = 7;
        public const int AGREGAR = 8;
        public const int ELIMINAR = 9;
        public const int ABRIR_CORCHETE = 10;
        public const int CERRAR_CORCHETE = 11;
        public const int VARIABLE = 12;
        public const int NUMERO = 13;
        public const int COMA = 14;
        public const int ASIGNACION = 15;

        public readonly int token;
        public readonly String sequence;

        public Token(int token, String sequence)
        {
            this.token = token;
            this.sequence = sequence;
        }



    }
}
