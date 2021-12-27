%include "io64.inc"

section .text
global CMAIN
CMAIN:
    mov rbp, rsp; for correct debugging
    
    mov rax, 0
    
LABLE_A:
    PRINT_HEX 1, [a+rax]
    NEWLINE
    inc rax
    cmp rax, 5
    JNE LABLE_A
    ;a 반복 하는 방법 1byte
    
    mov rax, 0
LABLE_B:
    PRINT_HEX 2, [b+rax*2]
    NEWLINE
    inc rax
    cmp rax, 5
    JNE LABLE_B;
    ; 출력값 8,800,8,800, 8
    ; why) 0x00,0x08,0x00,0x08식으로 되어 있는데 
    ;      2바이트씩 끊어서 그렇게 되었다.
    ; ans) 2바이트씩 점프한다.
    
    ret
    
section .data
    a db 0x01, 0x02, 0x03, 0x04, 0x05 
    ;일반적 배열
    ; 5 * 1 = 5바이트
    b times 5 dw 8
    ;times키워드 선언
    ; 5 * 2  = 10바이트

section .bss
    num resb 10
    ; 0값을 가지는 배열 10개 