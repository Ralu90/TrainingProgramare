using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgramare.Session_3
{
    public class Metode
    {
        [Test]
        public void MetodaTest()
        {
            //SumNumbers();
            //SumNumbers(12, 13);
           // SumNumbers(12, 13, 20);
           int sum = GetResult(15, 16, 3);
           Console.WriteLine("The result is: " + sum);

        }
        public void SumNumbers()
        {
            int number1 = 12;
            int number2 = 54;
            int sum = number1 + number2;

            Console.WriteLine("The result is: " +  sum);
        }

        public void SumNumbers(int NumberA, int NumberB)
        {
            int sum = NumberA + NumberB;
            Console.WriteLine("The result is: " + sum);

        }
        public void SumNumbers(int NumberA, int NumberB, int NumberC)
        {
            int sum = NumberA + NumberB + NumberC;
            Console.WriteLine("The result is: " + sum);
        }
        public int GetResult(int NumberA, int NumberB, int NumberC)
        {
            int sum = NumberA + NumberB + NumberC;
            return sum;
        }



    }   

            
    }
