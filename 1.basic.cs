using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // alt와 +를 같이 누르면 전각 <-> 반각 변환된다.
            
            Console.WriteLine("Hello World");
            Console.WriteLine("I am avengers");
            Console.WriteLine("six : "+3+3);
            Console.Write("라인 1 ");
            Console.WriteLine("줄바꿈 없는지 테스트");

            // 주석
            /*
             * 다수 주석
             */
            
            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);
            // en 10의 n제곱


            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string

            /*
            Console.Write("키미노 나마에와!!!! : ");
            string userName = Console.ReadLine();
            Console.WriteLine("Username is : "+userName);
            */

            // ReadLine을 통해서 받아오는 값은 string이기에 형변환이 필요하다.

            /*
            Console.Write("혹시,,, 나이가? : ");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("userAge is : " + userAge);
            */

            Console.WriteLine("1.51 : "+ Math.Round(1.51)); // 2
            Console.WriteLine("1.49 : " +Math.Round(1.49)); // 1

            string firstName = "John";
            string lastName = "Doe";
            string name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name);

            string day = "two";
            switch (day)
            {
                case "mon":
                    Console.WriteLine("Today is Saturday.");
                    break;
                case "two":
                    Console.WriteLine("Today is Sunday.");
                    break;
                default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;
            }

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine(numbers[i, j]);
                }
            }

        }
    }
}
