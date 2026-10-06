namespace Bankkonto_simulering;

class Program
{
    static void Main(string[] args)
    {
        Konto konto = new Konto();
        bool kors = true;

        while (kors)
        {
            MenuHelper.ShowMenu();
            string val = Console.ReadLine();

            switch (val)
            {
                case "1":
                    Console.Write("Belopp: ");
                    decimal insattning = decimal.Parse(Console.ReadLine());
                    konto.SattIn(insattning);
                    break;
                case "2":
                    Console.Write("Belopp: ");
                    decimal uttag = decimal.Parse(Console.ReadLine());
                    konto.TaUt(uttag);
                    break;
                case "3":
                    konto.VisaSaldo();
                    break;
                case "4":
                    kors = false;
                    break;
                default:
                    Console.WriteLine("Ogiltigt val");
                    break;
            }
        }
    }
}
