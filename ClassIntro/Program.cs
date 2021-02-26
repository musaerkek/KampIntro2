using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Musa";
            int yas = 22;

            Kurs Kurs1 = new Kurs();
            Kurs1.KursAdi = "C#";
            Kurs1.Egitmen = "Engin Demiroğ";
            Kurs1.IzlenmeOranı = 68;

            Kurs Kurs2 = new Kurs();
            Kurs2.KursAdi = "Java";
            Kurs2.Egitmen = "Kerem Varış";
            Kurs2.IzlenmeOranı = 64;

            Kurs Kurs3 = new Kurs();
            Kurs3.KursAdi = "Python";
            Kurs3.Egitmen = "Berkay Bilgin";
            Kurs3.IzlenmeOranı = 80;

            //Console.WriteLine(Kurs1.KursAdi + " : " + Kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { Kurs1, Kurs2, Kurs3 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }
    }
}
