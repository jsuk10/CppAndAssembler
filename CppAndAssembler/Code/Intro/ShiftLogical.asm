%include "io64.inc"

section .text
global CMAIN
CMAIN:
    mov rbp, rsp; for correct debugging

    ; 쉬프트(shift) 연산, 논리(logical) 연산
    mov eax, 0x12345678
    PRINT_HEX 4, eax
    NEWLINE
    shl eax, 8
    PRINT_HEX 4, eax
    NEWLINE
    shr eax, 8
    PRINT_HEX 4, eax
    NEWLINE
    
    mov al, 0b10010101      ; 1001 0101
    mov bl, 0b01111100      ; 0111 1100
    
    
    and al, bl              ; al = al and bl
    PRINT_HEX 1, al         ; 0001 0100 = 0x14
    NEWLINE
    not al                  ; al 비트 반전
    PRINT_HEX 1, al         ; 1110 1011 = 0xeb(15,12)
    NEWLINE
    
    or al, bl               ; al = al or bl
    PRINT_HEX 1, al         ; 1111 1111 = 0xff (16,16)
    NEWLINE
    
    xor al, bl              ; al = al xor bl
    PRINT_HEX 1, al         ; 1000 0011 0x83
    NEWLINE
    
    
    xor rax, rax
    ret

section .bss
    num resb 1