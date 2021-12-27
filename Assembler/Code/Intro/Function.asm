%include "io64.inc"

section .text
global CMAIN
CMAIN:
    mov rbp, rsp; for correct debugging
    ; 함수 (프로시저, procedure  서브 루틴, subroutine)
    
    CALL PRINT_MESG

    xor rax, rax
    ret
    
; 함수 구현부.
PRINT_MESG:
    PRINT_STRING msg
    NEWLINE
    ret

;입력과 반환값을 주는 함수
;? 넘겨 받는 방법 ?
;? 리턴 하는 방법 ?

MAX:
    cmp eax, ebx
    jg L1
    mov ecx, ebx,
    JMP RETURN
L1:
    mov ecx, eax    
RETURN:
    ret

section.data
    msg db "HI", 0x00