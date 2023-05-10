using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OtherClass oc = new OtherClass();
            Console.WriteLine("Hello World!");
        }

        //클래스 안에 클래스를 만들 수 있음
        class ThirdClass
        {

        }
    }

    internal class OtherClass
    {
    }

    class SecondClass
    {

    }
}