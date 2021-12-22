using System;

class People
{
    private int age = 0;
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    //public int get_Age() { return age; }      //error 해당 내용을 작성하면 함수가 두개 있으므로 
}

class Program
{
    static void Main()
    {
        People p = new People();
        p.Age = 10;
        int n2 = p.Age;
    }
}






