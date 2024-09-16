;mov2.asm
;.include "m328Pdef.inc"
.DEF mojomiljeniRegistar = R16
.DEF drugiRegistar =  R17 
LDI mojomiljeniRegistar, 150
MOV drugiRegistar, mojomiljeniRegistar 
END: RJMP END
