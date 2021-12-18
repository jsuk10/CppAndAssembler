프로그래밍 언어는 고급 언어에서 기계어로 변환하는 과정이 필요하다.

이 과정에서 어셈블리 언어가 필요한데 이 과정을 해주는 것이 컴파일러, 어셈블러 이다.

![어셈블러 그림](Image\Intro\Compiler.jfif)

SASM을 보면 그림과 같이 섹션이 나누어 진 것이 보인다.

코드는 실행되는 코드이외에도 데이터나 여러 정보들이 있을 수 있다.
![SASM 그림](Image\Intro\SASMCode.png)

exe파일에는 Section(".text")에 코드가 들어가고 Data즉 HelloWorld는 Section(".data")에 들어가게 된다.

![실행 파일 구조 그림](Image\Intro\PEFileStructure.png)

SASM에서 짠것과 동일하게 들어간 것을 볼 수 있다.

![컴퓨터 구조 그림](Image\Intro\ComputerStructure.png)
컴퓨터 구조에서 핵심 3요소인 CPU, Main Memory(RAM), Hard Disk가 있는데, Ram은 휘발성, Disk는 비 휘발성인 특징이 있고, 속도는 Ram이 하드 디스크 보다 빠르다.

일반적으로 데이터를 Disk -> Ram -> CPU로 올리기 떄문에 속도는 CPU에 가까울수록 빠르다.

CPU에서는 연산(실행)이 이루어 진다

> RAM에 올라간 프로그램은 작업 관리자 창에서 볼 수 있음.

![프로세스 메모리 구조](Image\Intro\MemoryStructure.png)
위와 같이 코드, 데이터, 힙, 스택으로 구분되어 있으며 힙은 아래로 스택은 위로 확장하는 구조를 가진다.

> 힙이나 스택이 가득차서 다른 영역을 침범하는 경우 큰 손실을 일의킬 수 있음.
