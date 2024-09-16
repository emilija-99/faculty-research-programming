.include "m328Pdef.inc"
SBI DDRB, DDB5 ;Postavljanje bita 5 kao izlaz - D13 Arduino UNO
SBI PORTB, PORTB5 ;Postavljanje 1 na izlaz porta B, bit 5
CBI PORTB, PORTB5 ;Postavljanje 0 na izlaz porta B, bit 5
end: rjmp end
