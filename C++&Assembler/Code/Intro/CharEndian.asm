%include "io64.inc"

section .text
global CMAIN
CMAIN:
    mov rbp, rsp; for correct debugging
    PRINT_STRING msg
    ret
    
section .data
    msg db 'hello World', 0x00
    ; db인데 여러 데이터 저장 = 연속된 공간에 저장
    ; 0x00은 문자의 끝을 나타냄
    a db 0x11, 0x11, 0x11, 0x11
    ; 데이터가 연속된 공간에 저장됨을 볼 수 있음
    b dd 0x12345678
    ; 데이터가 역순으로 저장됨을 볼 수 있음(빅 엔디안)