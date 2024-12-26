using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema
{
    public class Tema1

    {
        [Test]
        public void MetodaTest()
        {
            string FirstName;
            string LastName;
            int Age;
            char Gender;


            FirstName = "Raluca";
            LastName = "Frisan";
            Age = 24;
            Gender = 'F';
            int yearinfuture = Age + 20;


            Console.WriteLine("Your details are as follows: ");
            Console.WriteLine("- First Name: " + FirstName);
            Console.WriteLine("- Last Name: " + LastName);
            Console.WriteLine("- Gender: " + Gender);
            Console.Write("You will be " + yearinfuture + " years old in 20 years!");

        }
    }
}