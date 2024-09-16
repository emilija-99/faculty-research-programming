;mov3.asm
;.include "m328Pdef.inc"
.DEF mojomiljeniRegistar = R16
.DEF drugiRegistar =  R17 
START:
LDI mojomiljeniRegistar, 150
MOV drugiRegistar, mojomiljeniRegistar 
RJMP START
