using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgramare.Session2
{
    
    public class Cursant
    {
        string numeCursant;
        string prenumeCursant;
        int varsta;
        int cnp;
        bool esteActiv;
        char gen;
        float nota;
        double inaltime;

        [Test]
        public void MetodaTest()
        {
            numeCursant = "Frisan";
            prenumeCursant = "Raluca";
            varsta = 24;
           // cnp = 123456879;
            var numarLung = 123456789;
            esteActiv = true;
            gen = 'F';
            nota = 8.50F;
            inaltime = 1.85;

            Console.WriteLine("Nume: " + numeCursant);
            Console.Write("Prenume: " + prenumeCursant);
            Console.Write("Varsta: " + varsta);

            Console.Write("Nume cursant: " + numeCursant + " " + prenumeCursant + "\n");
            Console.Write("Varsta: " + numarLung);
        }

    }
}
