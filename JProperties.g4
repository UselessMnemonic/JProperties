grammar JProperties;

/* Parser Rules
 */

file
    : line* EOF
    ;

line
    : SPACE* property NATURAL_LINE_BREAK
    | SPACE* NATURAL_LINE_BREAK
    ;

property
    : key SPACE* PAIR_SEPERATOR SPACE* value
    | key SPACE* PAIR_SEPERATOR SPACE*
    ;

key
    : (PLAINCHAR | ESCAPE (ESCAPE | SPACE | PAIR_SEPERATOR | PLAINCHAR))+
    ;

value
    : (PLAINCHAR | ESCAPE (ESCAPE | SPACE | PAIR_SEPERATOR | PLAINCHAR)) (PLAINCHAR | SPACE | ESCAPE (ESCAPE | SPACE | PAIR_SEPERATOR | PLAINCHAR))*
    ;

/* Lexer Rules
 */

COMMENT
    : [!#] ~[\r\n]* -> skip
    ;

LOGICAL_LINE_BREAK
    : '\\' ('\r' '\n' | '\n') [ \r\f]* -> skip
    ;

NATURAL_LINE_BREAK
    : ('\r'? '\n' | '\n')
    ;

ESCAPE
    : '\\'
    ;

SPACE
    : [ \r\f]
    ;

PAIR_SEPERATOR
    : [:=]
    ;

PLAINCHAR
    : ~[:=\r\n\f \\]
    ;