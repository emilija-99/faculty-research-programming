.include "m328Pdef.inc"
ldi r16, 0x65
;out ddrb, R16
ldi xl, 0x24
ldi xh, 0x0
st x, r16
end: rjmp end
