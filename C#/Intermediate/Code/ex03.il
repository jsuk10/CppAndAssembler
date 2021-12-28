.assembly ex03 { }
.assembly extern mscorlib {}

.method static void foo() cil managed
{
    .entrypoint

    // C# : System.Console.WriteLine()
    call void [mscorlib]System.Console::WriteLine()

    // C# : System.Console.WriteLine("Hello, IL")
    ldstr "HELLO, IL"
    call void [mscorlib]System.Console::WriteLine(class System.String)


    ret
}
