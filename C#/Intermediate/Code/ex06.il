.assembly ex06 { }
.assembly extern mscorlib {}


.class public Program
{
    //instance로 인스턴스임을 알린다.
    .method public instance void foo() cil managed
    {

        .locals init(int32 x, int32 y)

        ldstr "foo"
        call void [mscorlib]System.Console::WriteLine(string)

        ret
    }

    .method public specialname rtspecialname void .ctor() cil managed
    {
        //기반 클래스 생성자 호출
        ldarg.0
        call instance void [mscorlib]System.Object::.ctor()

        ret
    }

    .method public static void Main() cil managed
    {
        .entrypoint

        // 지역변수 선언
        // Program p
        .locals init( class Program V_0 )

        // 클래스를 위해 힙에 객체를 만들고 생성자를 만든다.
        newobj instance void Program::.ctor()

        // 객체의 주소를 Program V_0에 넣는다.
        // 객체의 주소는 newobj에서 stack의 top에 넣어진다.
        stloc.0
        
        // 현재 스택의 TOP 주소를 받아서 해당 인스턴스의 Foo를 호출함
        ldloc.0
        callvirt void Program::foo()


        ret
    }
}