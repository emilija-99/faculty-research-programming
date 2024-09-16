.include "m328Pdef.inc"
.cseg
.org 000000
rjmp Main
MyTable:
.DB "abcd"
.DW 0x0201,0x0403; The table values, word wise organized
Main:
LDI ZH,HIGH(MyTable*2) ; address of table to pointer Z
LDI ZL,LOW(MyTable*2) ; multiplied by 2 for bytewise access
LPM ; Read least significant byte from program memory; “a”
MOV R8,R0 ; Copy LSB to 8-bit register R8
ADIW ZL,1 ; Point to MSB in program memory; “b” 
LPM ; Read MSB of table value
MOV R9,R0 ; Copy MSB to 8-bit register
ADIW ZL,1 ; Point to LSB in program memory; “c”
LPM ; Read LSB of table value
MOV R10,R0 ; Copy LSB to 8-bit register
ADIW ZL,1 ; Point to MSB in program memory; “d”
LPM ; Read MSB of table value
MOV R11,R0 ; Copy MSB to 8-bit register 
ADIW ZL,1 ; Point to LSB in program memory; “01”
LPM ; Read least significant byte from program memory
MOV R12,R0 ; Copy LSB to 8-bit register R12
ADIW ZL,1 ; Point to MSB in program memory; “02”
LPM ; Read MSB of table value
MOV R13,R0 ; Copy MSB to 8-bit register
ADIW ZL,1 ; Point to LSB in program memory; “03”
LPM ; Read LSB of table value
MOV R14,R0 ; Copy LSB to 8-bit register
ADIW ZL,1 ; Point to MSB in program memory; “04”
LPM ; Read MSB of table value
MOV R15,R0 ; Copy MSB to 8-bit register
Loop:
rjmp Loop  
