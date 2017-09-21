grammar Gramatica;

/*
 * Parser Rules
 */
 expresion :
		conjunto
		| VARIABLE
		| VARIABLE '=' expresion
		| FUNCION_CREACION '({' (NUMERO | (NUMERO ',' NUMERO)*)  '})'
		| FUNCION_CREACION '(' NUMERO ',' NUMERO ')'
		| FUNCION_CREACION '(' NUMERO ',' NUMERO ',' NUMERO ')'
		| FUNCION_BINARIA '(' expresion ',' expresion ')'
		| FUNCION_UNARIA '(' expresion ')'
		| FUNCION_ELEMENTO '(' expresion ',' NUMERO ')'
		;
 
conjunto :
      OPEN_COR   (NUMERO | (NUMERO ',' NUMERO)*)    CLOSE_COR
      ;

/*
 * Lexer Rules
 */

OPEN_COR : '[' ;
CLOSE_COR : ']' ;

NUMERO : [0-9]+   ;
           
VARIABLE : [a-z]+ ;
            
FUNCION_CREACION : 'set'		;
FUNCION_BINARIA  : 'int'|'uni'|'ext' ;
FUNCION_UNARIA   : 'max'|'min'|'len'|'med' ;
FUNCION_ELEMENTO : 'add'|'del' ;


WS
	:	' ' -> channel(HIDDEN)
	;
