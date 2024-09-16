.include "m328Pdef.inc"
.def mojomiljeniRegistar = r16
ldi mojomiljeniRegistar, 150
ldi zh, 0
ldi zl, 0
lpm
mov r1, r0
ldi zl,1
lpm
end: rjmp end
