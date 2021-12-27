%include "io64.inc"

section .text
global CMAIN
CMAIN:
    mov rbp, rsp; for correct debugging
    
    mov ecx, 10
    
LABEL_LOOP:
    PRINT_STRING msg
    NEWLINE
    dec ecx             ;하나씩 줄여주는 명령어
    cmp ecx, 0
    JNE LABEL_LOOP
    
    ; Loop [라벨]
    ; - ecx에 반복 횟수
    ; - loop할떄마다 ecx 1감소, 0이면 나감 아니면 라벨로
    
    mov ecx, 20
    mov rax, 0
    
LABEL_Loop_SUM:
    inc rax
    LOOP LABEL_Loop_SUM
    
    PRINT_DEC 1, rax
    
    ret
    
section .data
    msg db "Hello World", 0x00
    msgs db "Loop", 0x00