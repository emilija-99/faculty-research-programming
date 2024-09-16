.include "m328Pdef.inc"
ldi r16, 0x65
;out ddrb, R16
ldi xl, low(0x24)
ldi xh, high(0x24)
st x, r16
end: rjmp end
