grammar KotlinVar;  

startRule : CONST_KW VAL_KW id EQUAL string_literal SEMI EOF ;

id : ID ;
string_literal : STRING ;

CONST_KW : 'const' ;
VAL_KW   : 'val' ;
EQUAL    : '=' ;
SEMI     : ';' ;

ID : LETTER (LETTER | DIGIT | '_')* ;

STRING : '"' SYMBOL* '"' ;

fragment LETTER : [a-zA-Z] ;
fragment DIGIT  : [0-9] ;

fragment SYMBOL : [a-zA-Z0-9+\-/*{}();_] ;

WS : [ \t\r\n]+ -> channel(HIDDEN) ;