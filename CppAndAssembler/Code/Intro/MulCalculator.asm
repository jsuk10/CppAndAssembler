%include "io64.inc"

section .text
global CMAIN
CMAIN:
    mov rbp, rsp; for correct debugging

    ; 곱하기
    ; mul reg
    ; mul bl => al * bl 연산을 해서 결과를 ax에 저장.
    ; mul bx => ax * bx 연산 결과는 dx(상위 16비트) ax (하위 16비트) 에 저장
    ; 5 * 8
    mov ax, 0
    mov al, 5
    mov bl, 8
    mul bl
    PRINT_DEC 2, ax
    NEWLINE
    
    ; 나누기
    ; div reg
    ; div bl => ax / bl 연산을 해서al에 몫, ah에 나머지 저장.
    ; 100 / 3
    
    mov ax, 100
    mov bl, 3
    div bl
    PRINT_DEC 2, al  ; al = 몫
    NEWLINE
    mov al, ah       ; ah는 프린트 할 수 없으므로 값을 옮겨서 출력
    PRINT_DEC 2, al  ; ah = 나머지
    NEWLINE
    ret

section .bss
    num resb 1