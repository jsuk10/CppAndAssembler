.assembly ex04 { }
.assembly extern mscorlib {}

// int x = 2;
// int y = 20;
// Console.WriteLine("{0}, {1}", x, y)

.method static void foo() cil managed
{
    .entrypoint

    .locals init(int32 x, int32 y)

    ldc.i4.2        // push 2
    stloc.0         // x = StackFram.top(2)
    ldc.i4.s 20     // push 20
    stloc.1         // y = StackFrame.top(20)

    ldstr "{0}, {1}"// string
    ldloc.0         // x
    box int32       // boxing
    ldloc.1         // y
    box int32       // boxing

    call void [mscorlib]System.Console::WriteLine(string, object, object)


    ret
}
