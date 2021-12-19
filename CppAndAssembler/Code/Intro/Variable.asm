%include "io64.inc"

section .text
global CMAIN
CMAIN:
    mov rbp, rsp; for correct debugging
    mov rax, 0x12345678
    ; 변수를 메모리에 할당
    ;mov rax, a
    ; 이때 주소값으로 전달해준다. 즉 콜바이 벨류가 아닌 레퍼
    ; mov rax, [a]
    ; []를 넣어주면 해당 데이터의 벨류를 가지고 온다.
    ; 하지만 크기를 지정하지 않았으므로 rax의 크기 만큼 꺼내옴
    
    mov rax, [a]
    ; 바이트만 꺼내오는 방법 예시1
    
    mov [a], byte 0x99
    mov [a], word 0x8888
        ret
    
    ; 변수의 선언 및 사용 (data)
    ; 초기화 된 데이터를 사용할 경우 데이터 영역에 들어감
    ; {변수이름} {크기} {초기값}
    ; 명령어(크기) db(1) dw(2) dd(4) dq(8)
    ; 즉 4바이트 받고싶으면 dd
    ; ex) Data dw 0x00
    
section .data
    a db 0x11   ; [0x11]
    b dw 0x2222
    c dd 0x33333333
    d dq 0x4444444444444444
    
    ; 초기화 되지 않은 데이터 (bss)
    ; {변수이름} {크기} {개수}
    ; {크기} resb(1) resw(2) resd(4) resq(8)
section .bss
    e resb 10