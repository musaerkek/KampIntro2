using System;

namespace Day2HW6
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.UrunAdi = "Akıllı Robot Süpürge";
            product1.Fiyati = 2979;
            product1.DegerlendirmeSayisi = 3479;

            Product product2 = new Product();
            product2.UrunAdi = "Çay";
            product2.Fiyati = 32.90;
            product2.DegerlendirmeSayisi = 1495;

            Product product3 = new Product();
            product3.UrunAdi = "Oyun Konsolu";
            product3.Fiyati = 8849;
            product3.DegerlendirmeSayisi = 39;

            Product[] products = new Product[] { product1, product2, product3 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.UrunAdi + ":" + product.Fiyati + "TL" + " " + product.DegerlendirmeSayisi + "Değerlendirme");
            }
            Console.WriteLine("-----Foreach Bitti-----");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].UrunAdi + ": " + products[i].Fiyati + "TL" + " " + products[i].DegerlendirmeSayisi + "Değerlendirme");
            }
            Console.WriteLine("-----For Bitti-----");
            int count = 0;
            while (count < products.Length)
            {
                Console.WriteLine(products[count].UrunAdi + ": " + products[count].Fiyati + "TL" + " " + products[count].DegerlendirmeSayisi + "Değerlendirme");
                count++;
            }
            Console.WriteLine("-----While Bitti-----");
        }
    }
    class Product
    {
        public string UrunAdi { get; set; }
        public double Fiyati { get; set; }
        public int DegerlendirmeSayisi { get; set; }
    }
}
