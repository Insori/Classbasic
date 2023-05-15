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


            List<Student> list = new List<Student>()
            {
                    new Student() { name = "전영중", grade = 3 },
                    new Student() { name = "성준수", grade = 3 },
                    new Student() { name = "최종수", grade = 3 },
                    new Student() { name = "기상호", grade = 1 }
            };

            foreach (var item in list) 
            { 
                Console.WriteLine(item);
            }

            /*foreach (var item in list)    //foreach문에서 수정할 요소를 삭제할 수 없음
            {
                if (item.grade > 1)
                {
                    list.Remove(item);
                }
            }*/

            //요소를 삭제하는 순간 순서가 밀린다. 따라서 밀린 요소를 건너뛴다.

            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i].grade > 1)
                {
                    list.RemoveAt(i);   
                }
            }

            Console.WriteLine("-------------------");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
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