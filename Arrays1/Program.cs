﻿namespace Arrays1;

class Program
{
    static void Main(string[] args)
    {
        //Dizi Tanımlama
        string[] renkler = new string[5];
        string[] hayvanlar = ["Kedi", "Kopek", "Kus", "Maymun"];

        int[] dizi;
        dizi = new int[5];

        //Dizilere Değer Atama ve Erişim
        renkler[0] = "Mavi";
        dizi[3] = 10;

        /*Console.WriteLine(hayvanlar[1]);
        Console.WriteLine(dizi[3]);
        Console.WriteLine(renkler[0]);*/

        //Döngülerle Dizi Kullanımı
        //Klavyeden girilen n tane sayının ortalamasını alan program

        Console.Write("Dizinin eleman sayisini giriniz: ");
        int diziUzunlugu = int.Parse(Console.ReadLine());
        int[] sayiDizisi = new int[diziUzunlugu];

        for (int i = 0; i < diziUzunlugu; i++)
        {
            Console.Write("Lutfen {0}. sayiyi girin: ", i + 1);
            sayiDizisi[i] = int.Parse(Console.ReadLine());
        }

        int toplam = 0;
        foreach (var sayi in sayiDizisi)
        {
            toplam += sayi;
        }

        Console.WriteLine("Ortalama: " + toplam / diziUzunlugu);
    }
}
