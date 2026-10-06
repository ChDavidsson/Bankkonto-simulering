namespace Bankkonto_simulering;

public class Konto
{
    private decimal saldo = 0;

    public void SattIn(decimal belopp)
    {
        if (belopp > 0)
        {
            saldo += belopp;
            Console.WriteLine($"Du satte in {belopp} kr.");
        }
        else
        {
            Console.WriteLine("Fel: Beloppet måste vara större än 0.");
        }
    }

    public void TaUt(decimal belopp)
    {
        if (belopp > 0 && belopp <= saldo)
        {
            saldo -= belopp;
            Console.WriteLine($"Du tog ut {belopp} kr.");
        }
        else
        {
            Console.WriteLine("Fel: Ogiltigt belopp eller för lite pengar på kontot.");
        }
    }

    public void VisaSaldo()
    {
        Console.WriteLine($"Saldo: {saldo} kr");
    }
}