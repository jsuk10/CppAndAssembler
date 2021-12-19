%include "io64.inc"

section .text
global CMAIN
CMAIN:
    mov rbp, rsp; for correct debugging
    PRINT_STRING msg
    ret
    
section .data
    msg db 'hello World', 0x00
    
    a db 0x11, 0x11, 0x11, 0x11
    
    b dd 0x12345678