%include "io64.inc"

section .text
global CMAIN
CMAIN:
    mov rbp, rsp
    ; 스텍 메모리, 스텍 프레임
    
    ; Stack을 볼 수 있는 방법?
    ; Register은 다양한 용도로 사용이 된다.
    ; a, b, c, d등 범용 레지스터
    ; 포인터 레지스터 (포인터 = 위치를 가리키는)
    ; ip (Instruction Pointer) : 다음 수행 명령어의 위치
    ; sp (Stack Pointer) : 현재 스택의 마지막 위치 (일종의 Cusor)
    ; bp (Base Pointer) : 스택 상대 주소 계산용
    
    ; Stack에 값을 넣음
    push 1 
    push 2 
    push 3
    
    ; Stack에서 값 꺼
    pop rax 
    pop rbx 
    pop rcx 
    
    xor rax, rax
    ret
    

section.data
    msg db "HI", 0x00