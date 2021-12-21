using System;

interface ICamera
{
    void Take();
}

class MP3
{
    public virtual void Play() { }
}

class SmartPhone : MP3, ICamera
{
    public override void Play() { }     //가상 함수를 재정의함.

    //public ovrride void Take() { }    //error 인터페이스는 구현이 없기 때문에 ovrride를 하지 않는다.
    //public void Take() { }            //이렇게 해도 됨.
    public virtual void Take() { }      //가상으로 만들거나 일반 함수로 만들어도 됨.
}

class Program
{
    static void Main()
    {

    }
}
