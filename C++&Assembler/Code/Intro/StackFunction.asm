%include "io64.inc"

section .text
global CMAIN
CMAIN:
    mov rbp, rsp
   
    ; Stack에 값을 넣음
    
    push rax
    push rbx
    ; MAX함수에서 rax, rbx를 사용한다.
    push 3
    push 9
    call MAX
    PRINT_DEC 8, rax
    NEWLINE
    add rsp, 16         
    ; rsp(Stack Pointer)에 값을 더해서 위의 인자 두개를 푸쉬한 것을 지워준다.
    
    pop rbx
    pop rax
    
    xor rax, rax
    ret

MAX:
    push rbp
    mov rbp, rsp
    
    mov rax, [rbp + 16] ; ret와 BP가 저장되어 있으므로 +16(8*2)
    mov rbx, [rbp + 24]
    cmp rax, rbx
    jg LI
    mov rax, rbx
    
LI:
    pop rbp
    ret
