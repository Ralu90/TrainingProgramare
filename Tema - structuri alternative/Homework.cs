using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgramare.Tema___structuri_alternative
{
    public class Homework
    {
        [Test]

        public void MetodaTest()
        {
            //isOld(101);
            //isOld(49);
            //showGender("Random");
            showGender("Female");
                
        }

        public void isOld(int PersonAge)
        {
            if (PersonAge >= 100)
            {
                Console.WriteLine("You are ancient!");
            }
            else if (PersonAge >= 50)
            {
                Console.WriteLine("You are old!");
            }
            else if (PersonAge < 50)
            {
                Console.WriteLine("You are still young!");
            }

        }

        public void showGender(string PersonGender)
        {
            switch (PersonGender)
            {
                case "Female":
                    Console.WriteLine("You are Female!");
                    break;
                case "Male":
                    Console.WriteLine("You are Female!");
                    break;
                default:
                    Console.WriteLine("You haven't specified your gender!");
                        break;

            }
        }
    }


}
