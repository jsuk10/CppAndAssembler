%include "io64.inc"

section .text
global CMAIN
CMAIN:
        mov rbp, rsp; for correct debugging
    
    ; 특정 숫자를 입력받고 해당 숫자가 짝수면 1 홀수면 0 출력
    
    GET_DEC 1 , num      ;숫자 할당
    
    mov rax, [num]      ;숫자를 벨류로 전달
    
    mov bl, 2       ;나누기 할 숫자
    
    div bl          ;나눗셈 하여 ax에 몫 ah에 나머지 저장
    
    cmp ah, 0      ; 나머지(ah) 가 0과 같으면 짝 아님 홀
    
    JE LABEL_EQUAL  ; 짝수일 경우 이퀄로
    
    mov rcx, 0      ; 홀수일 경우 실행
    
    JMP LABEL_Not_EQUAL
LABEL_EQUAL:
    mov rcx, 1      ; 짝수일 경우 실행

LABEL_Not_EQUAL:

    PRINT_HEX 1, rcx    ; 짝이면 1 홀이면 0 출력
      
    ret
    
section .bss
    num resb 1