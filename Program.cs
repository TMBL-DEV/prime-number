// See https://aka.ms/new-console-template for more information
namespace primeProgram
{
    // start program
    class Program
    {
        public static void Main(string[] args)
        {
            // ask for input
            // validate input
            // if invalid input give a message back and restart the program
            Console.WriteLine("give a number, and we will resolve the prime numbers in that range");
            PrimeNumberConsole instance = PrimeNumberConsole.initiateByUserInput();
            Thread mathsThread = new Thread(new ThreadStart(instance.check));
            Console.WriteLine("time 2 big brain");
            mathsThread.Start();
            mathsThread.Join();
            foreach (var item in instance.primeNumbers.ToArray())
            {
                Console.WriteLine(item);
            }
        }
    }
}
