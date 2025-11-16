using System.Security.Cryptography.X509Certificates;

namespace Class7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int azn = Int32.Parse(Console.ReadLine());

            Program program = new Program();
            program.Exchange(Currency.USD, azn);
            program.Exchange(Currency.EUR, azn);
            program.Exchange(Currency.TRY, azn);


        }
        public void Exchange(Enum currency, double azn)
        {

            //if (currency is Currency.USD)
            //{
            //    double result = azn / 1.7;
            //    Console.WriteLine($"{azn} AZN = {result} USD");
            //}
            //else if (currency is Currency.EUR)
            //{
            //    double result = azn / 1.8;
            //    Console.WriteLine($"{azn} AZN = {result} EUR");
            //}
            //else if (currency is Currency.TRY)
            //{
            //    double result = azn / 0.09;
            //    Console.WriteLine($"{azn} AZN = {result} TRY");
            //}

            if (currency is Currency)
            {
                switch (currency)
                {
                    case Currency.USD:
                        Console.WriteLine($"USD: {azn / 1.7}");
                        break;
                    case Currency.EUR:
                        Console.WriteLine($"EUR: {azn / 1.8}");
                        break;
                    case Currency.TRY:
                        Console.WriteLine($"TRY: {azn / 0.09}");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Duzgun valyuta secin");

            }
        }
    }

}
