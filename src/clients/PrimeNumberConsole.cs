namespace primeProgram
{
    class PrimeNumberConsole
    {
        const int defaultPrimeNumber = 2;
        List<int> primeNumbers = new List<int>();
        private int inputNumber = 2;

        public PrimeNumberConsole(string inputNumberToCovert)
        {
            this.inputNumber = Int32.Parse(s: inputNumberToCovert);
            this.primeNumbers.Add(2);
        }

        public int[] check()
        {
            for (int i = 2; i < this.inputNumber; i++)
            {
                int possiblePrimeNumber = i + 1;
                if (this.checkIfPrime(possiblePrimeNumber))
                {
                    this.primeNumbers.Add(possiblePrimeNumber);
                }
            }

            return this.primeNumbers.ToArray();
        }

        private bool checkIfPrime(int possiblePrime)
        {
            // get the sqrt and  of the possiblePrime and round it up
            Double maxInt = Math.Ceiling(Math.Sqrt(possiblePrime));
            // check all the prime numbers we have with the current number
            foreach (int primeNumber in this.primeNumbers)
            {
                if (primeNumber <= maxInt)
                {
                    double dividedResult = (double)possiblePrime / primeNumber;
                    if ((dividedResult == Math.Floor(dividedResult)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static PrimeNumberConsole initiateByUserInput()
        {
            try
            {
                string? userInput = Console.ReadLine();

                if (userInput != null)
                {
                    return new PrimeNumberConsole(userInput);
                }

                throw new Exception("input is null");
            }
            catch (Exception error)
            {
                Console.WriteLine("this was not a valid input, try again");
                return PrimeNumberConsole.initiateByUserInput();
            }
        }
    }
}