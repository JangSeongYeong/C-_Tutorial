using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMethod();
            ParamMethod("jang");
            DefaultMethod();
            DefaultMethod("merry");
            Console.WriteLine(MyMethod(1, 2)); // 오버로드 테스트
            MyMethod(child3: "John", child1: "Liam", child2: "Liam"); // key:value 구조로 전송함으로써 매개변수의 순서를 신경안써도 된다.

        }

        static void MyMethod()
        {
            Console.WriteLine("이런거 잘 안썼지만 이제는 잘써봐야지");
        }

        static void ParamMethod(string fname)
        {
            Console.WriteLine(fname + " Refsnes");
        }

        static void DefaultMethod(string country = "Norway")
        {
            Console.WriteLine(country);
        }

        // 리턴값을 지정함으로써 리턴 가능
        static int MyMethod(int x, int y)
        {
            return x + y;
        }

        static void MyMethod(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child3);
        }
    }
}
