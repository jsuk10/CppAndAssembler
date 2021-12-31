.assembly ex05 { }
.assembly extern mscorlib {}


.class public Program
{
    .method public static void foo() cil managed
    {

        .locals init(int32 x, int32 y)

        ldstr "foo"
        call void [mscorlib]System.Console::WriteLine(string)

        ret
    }

    .method public static void Main() cil managed
    {
        .entrypoint

        .locals init(int32 x, int32 y)

        ldstr "Main"

        call void [mscorlib]System.Console::WriteLine(string)

        call void Program::foo()

        ret
    }
}