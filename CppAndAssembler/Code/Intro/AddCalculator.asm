%include "io64.inc"

section .text
global CMAIN
CMAIN:
    mov rbp, rsp; for correct debugging

    GET_DEC 1 , al  ; al = 1
    GET_DEC 1 , num ; num = 2

    ;Register + Const (레지스터 + 상수)
    add al, 1       ; 1을 더해줌
    PRINT_DEC 1, al
    NEWLINE
    
    ;Register + Variable (레지스터 + 변수)
    add al, [num]   ;al = 3
    PRINT_DEC 1, al
    NEWLINE

    ;Register + Register (레지스터 + 레지스터)
    mov bl, 3       ; bl = 3
    add al, bl      ; al = 6
    PRINT_DEC 1, al
    NEWLINE

    ;Variable + Const (변수 + 상수)
    ;데이터를 할당할때 크기를 붙이지 않으면 오류남.
    add [num], byte 1   ; num = 3

    PRINT_DEC 1, num
    NEWLINE

    ;Variable + Register (변수 + 레지스터)
    add [num], al       ;num = 9
    PRINT_DEC 1, num
    NEWLINE

    ret

section .bss
    num resb 1