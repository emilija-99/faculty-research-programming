.include "m328Pdef.inc"
SBI DDRB, DDB5; Set the direction bit of PB5 high - output
Toggle:
SBI PORTB, PORTB5 ; Set the output port pin PB5 to HIGH
nop
nop
nop
CBI PORTB, PORTB5 ; Clear the output port pin PB5 to LOW
nop
RJMP Toggle ; Jump back to the label Toggle
