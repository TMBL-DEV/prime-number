namespace primeProgram
{
    class PrimeNumberConsole
    {
        const int defaultPrimeNumber = 2;
        public List<int> primeNumbers = new List<int>();
        private int inputNumber = 2;
        private int possiblePrimeNumber = 0;
        public PrimeNumberConsole(string inputNumberToCovert)
        {
            this.inputNumber = Int32.Parse(s: inputNumberToCovert);
            this.primeNumbers.Add(2);
        }

        public void check()
        {
            List<Thread> slaves = new List<Thread>();
            for (int i = 2; i < this.inputNumber; i++)
            {
                this.possiblePrimeNumber = i + 1;
                this.checkIfPrime();
            }
        }

        void checkIfPrime()
        {
            // get the sqrt and  of the possiblePrime and round it up
            Double maxInt = Math.Ceiling(Math.Sqrt(this.possiblePrimeNumber));
            // check all the prime numbers we have with the current number
            foreach (int primeNumber in this.primeNumbers)
            {
                if (primeNumber <= maxInt)
                {
                    double dividedResult = (double)this.possiblePrimeNumber / primeNumber;
                    if ((dividedResult == Math.Floor(dividedResult)))
                    {
                        return;
                    }
                }
            }
            this.primeNumbers.Add(this.possiblePrimeNumber);
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