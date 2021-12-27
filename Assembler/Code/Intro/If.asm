%include "io64.inc"

section .text
global CMAIN
CMAIN:
    mov rbp, rsp; for correct debugging
    
    ; 분기문
    ; 특정 조건에 따라 코드 흐름을 제어 하는 것
    ; ex) 스킬 버튼을 눌렀는가? Yes -> 스킬 사용
    
    mov rax, 10
    mov rbx, 20
   
    cmp rax, rbx    ;비교 연산
    
    JE LABEL_EQUAL
    
    ;JE에 의해 점프를 하지 않으면 다르다는 의미가 됨.
    mov rcx, 0
    
    JMP LABEL_EQUAL_END
LABEL_EQUAL:
    mov rcx, 1

LABEL_EQUAL_END:
    PRINT_HEX 1, rcx
      
    ret
    
    