namespace WhileForeach;

class Program
{
    static void Main(string[] args)
    {
        //While
        //1den başlayıp verilen sayıya kadar ortalama hesaplama.

        Console.Write("Lutfen bir sayi giriniz: ");
        int sayi = int.Parse(Console.ReadLine());
        int sayac = 1;
        int toplam = 0;

        while (sayac <= sayi)
        {
            toplam += sayac;
            sayac++;
        }

        Console.WriteLine(toplam / sayi);

        //A'dan Z'ye tüm harfleri konsola yazar.
        char character = 'a';
        while (character <= 'z')
        {
            Console.Write(character);
            character++;
        }

        //Foreach
        string[] arabalar = { "BMW", "FORD", "TOYOTA", "NISSAN" };

        foreach (var araba in arabalar)
        {
            Console.WriteLine(araba);
        }
    }
}
