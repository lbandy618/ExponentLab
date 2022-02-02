namespace ExponentsLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool runProgram = true;
            while (runProgram)
            {
                // intro message
                Console.WriteLine("Learn your squares and cubes");
                Console.WriteLine();
                int num1 = 0;
                while (true)
                {
                    // gathering user input
                    Console.WriteLine("Enter an integer: ");
                    num1 = int.Parse(Console.ReadLine());

                    if (num1 > 0 && num1 <= 1290)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input entered. Please try again.");
                    }
                }
                //formatting
                Console.WriteLine();
                Console.WriteLine(String.Format("{0,6}{1,9}{2,15}" , "Number" , "Squared" , "Cubed"));
                Console.WriteLine(String.Format("{0,6}{1,9}{2,15}" , "======" , "=======" , "====="));
                for (int i = 1; i <= num1; i++)
                {

                    // displaying calculated numbers
                    Console.WriteLine(String.Format("{0,6}{1,9}{2,15}", i , NSquared(i) , NCubed(i)));
                    Console.WriteLine();
                 }
                // outro goodbye message
                while (true)
                {
                    Console.WriteLine("Would you like to continue y/n");
                    string loopCheck = Console.ReadLine();
                    if (loopCheck.ToLower().Trim() == "y")
                    {
                        runProgram = true;
                        break;
                    }
                    else if (loopCheck.ToLower().Trim() == "n")
                    {
                        runProgram = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That was not a valid response");
                    }
                }
            }
        }
        // calculation methods for cubed and squared
        static int NSquared(int ns)
        {
            return ns * ns;
        }
        static int NCubed(int nc)
        {
            return nc * nc * nc;
        }
    }
}
