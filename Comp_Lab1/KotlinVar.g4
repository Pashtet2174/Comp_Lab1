grammar KotlinVar;


// --- Правила парсера ---
program : declaration* EOF;
declaration : CONST VAL IDENTIFIER ASSIGN STRING SEMICOLON ;

// --- Правила лексера ---
CONST      : 'const';
VAL        : 'val';
IDENTIFIER : [a-zA-Z_] [a-zA-Z0-9_]*;
STRING     : '"' .*? '"';
ASSIGN     : '=';
SEMICOLON  : ';';
WS         : [ \t\r\n]+ -> skip;