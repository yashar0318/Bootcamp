using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Kurs kurs1 = new Kurs();
            kurs1.Kursadi = "C#";
            kurs1.Egitmen = "Yashar";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.Kursadi = "Java";
            kurs2.Egitmen = "Eli";
            kurs2.IzlenmeOrani = 70;

            Kurs kurs3 = new Kurs();
            kurs3.Kursadi = "C";
            kurs3.Egitmen = "Azer";
            kurs3.IzlenmeOrani = 71;

            //Console.WriteLine(kurs1.Egitmen + ": " + kurs1.Kursadi);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.Egitmen + ": " + kurs.Kursadi);
            }

        }
        class Kurs
        {
            public string Kursadi { get; set; }
            public string Egitmen { get; set; }
            public int IzlenmeOrani { get; set; }
        }
    }
}
