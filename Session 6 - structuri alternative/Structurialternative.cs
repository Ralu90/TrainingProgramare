using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgramare.Session_6___structuri_alternative
{
    public class Structurialternative
    {
        [Test]

        public void TestMethod()
        {
            //VerificareNumar(20, 12);
            CompareDigits(5);
            VerificareMasina("Ferrari");
                
                }

        public void VerificareNumar(int x, int y)
        {

            if (x<y)
            {
                Console.WriteLine($"Numarul {x} este mai mic decat numarul {y}");

            }
            else
            {
                Console.WriteLine($"Numarul {x} este mai mare decat numarul {y}");

            }

        }

        public void CompareDigits(int x)
        {
            if (x<5)
            {
                Console.WriteLine($"Numarul {x} este mai mic decat 5");
            }
            else if (x>5)
            {
                Console.WriteLine($"Numarul {x} este mai mare decat 5");
            }
            else 
            {
                Console.WriteLine($"Numarul {x} este egal cu 5");
            }
        }

       public void VerificareMasina(string masina)
        {
            switch (masina)
            {
                case "Mercedes":
                    Console.WriteLine("Este disponibil Mercedes");
                    break;
                case "Opel":
                    Console.WriteLine("Este disponibil Opel");
                    break;
                case "BMW":
                    Console.WriteLine("Este disponibil BMW");
                    break;
                default:
                    Console.WriteLine("Marca nu este disponibila");
                    break;



            }
        }


    }
}
