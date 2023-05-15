namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1 Guessing Game
            var r = new Random();
            var favNumber = r.Next(1, 10);


            Console.WriteLine("Guess the number.");
            Console.WriteLine("Pick a number from 1-10.");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("Too low.");
            }
            else if (userInput > favNumber) 
            {
                Console.WriteLine("Too high.");
            }
            else 
            {
                Console.WriteLine("You Guessed It!!!");
            }
        }   
    }
}
