using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgramare.Tema
{
    public static class Persona
    {

        static string firstName = "Raluca Ioana";
        static string lastName = "Frisan";
        static int age = 34;
        static string gender = "Female";

        [Test]
        public static void MetodaTest()

        {
            DisplayUserDetails();
            int nrAge = Person.AgeInFutureYears(20);
            Console.WriteLine("You will be " + nrAge + " years old in 20 years!");
            
        }

        public static int AgeInFutureYears(int x)
        {
            return x + age;
        }

        public static void DisplayUserDetails()

        {
            Console.WriteLine($"The person's details are as follows: \n" +
                               $"- First Name: {firstName} \n" +
                               $"- Last Name: {lastName}  \n" +
                               $"- Gender: {gender} \n");

        }

        
    }
}