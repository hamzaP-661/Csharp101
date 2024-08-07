namespace SwitchCase;

class Program
{
    static void Main(string[] args)
    {
        int month = DateTime.Now.Month;

        switch (month)
        {
            case 1: 
                Console.WriteLine(month + "- Ocak");
                break;
            case 2:
                Console.WriteLine(month + "- Subat");
                break;
            case 3:
                Console.WriteLine(month + "- Mart");
                break;
            case 4:
                Console.WriteLine(month + "- Nisan");
                break;
            case 5:
                Console.WriteLine(month + "- Mayis");
                break;
            case 6:
                Console.WriteLine(month + "- Haziran");
                break;
            case 7:
                Console.WriteLine(month + "- Temmuz");
                break;
            case 8:
                Console.WriteLine(month + "- Agustos");
                break;
            case 9:
                Console.WriteLine(month + "- Eylul");
                break;
            case 10:
                Console.WriteLine(month + "- Ekim");
                break;
            case 11:
                Console.WriteLine(month + "- Kasim");
                break;
            case 12:
                Console.WriteLine(month + "- Aralik");
                break;
            default:
                Console.WriteLine("Yanlis veri girisi");
                break;
        }

        switch(month)
        {
            case 12:
            case 1:
            case 2:
                Console.WriteLine("Kis ayindasiniz.");
                break;
            case 3:
            case 4:
            case 5:
                Console.WriteLine("Ilkbahar ayindasiniz.");
                break;
            case 6:
            case 7:
            case 8:
                Console.WriteLine("Yaz ayindasiniz.");
                break;
            case 9:
            case 10:
            case 11:
                Console.WriteLine("Sonbahar ayindasiniz.");
                break;
            
        }
    }
}
