using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Math
    {
        public static int abs(int i) { return 0; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Math.abs(-3);   //가장 가까운 Math 클래스로 인식

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