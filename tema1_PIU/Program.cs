namespace SalariuAngajat
{
    class Program
    {
        static void Main()
        {
            int oreLucrate = 0;
            double tarifOra = 0;

            Console.Write("Introduceti numarul de ore lucrate: ");
            string ore = Console.ReadLine();

            Console.Write("Introduceti tariful pe ora: ");
            string tarif = Console.ReadLine();

            int.TryParse(ore, out oreLucrate);
            double.TryParse(tarif, out tarifOra);

            double salariu = oreLucrate * tarifOra;

            Console.WriteLine("Salariul este: " + salariu);

            if (salariu > 3000)
            {
                Console.WriteLine("Salariu mare!");
            }
            else
            {
                Console.WriteLine("Ati lucrat prea putine ore pentru a avea un salariu mare!");
            }
        }
    }
}
