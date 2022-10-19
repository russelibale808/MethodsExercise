using System.ComponentModel;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1

            Console.Write("What is your name? ");
            string firstname = Console.ReadLine();

            Console.WriteLine("Whats your favorite color ");
            string color = Console.ReadLine();

            Console.WriteLine("What's your favorite animal? ");
            string animal = Console.ReadLine();

            Console.WriteLine("Whats your favorite band? ");
            string band = Console.ReadLine();


            Console.WriteLine($"Hi {firstname}, nice to meet you, I'm BOTBOT. {color} is a intresting color, mines orange." +
                              $" {animal}s are my favoirte too. I never hear of that band called {band} before, are they new? ");
            string bottalk = Console.ReadLine();


            // Exercise 2
            var result = Add(10, 20);
            Console.WriteLine($" {result} ");
            
            result = Subtract(10, 20);
            Console.WriteLine($" {result} ");
            
            result = Multiply(10, 20);
            Console.WriteLine($" {result} ");
            
            result = Divide(10, 20);
            Console.WriteLine($" {result} ");
            
            result = Modulus(10, 20);
            Console.WriteLine($" {result} ");
            
               
        }

        public static int Modulus(int num1, int numb2)
        {
            return num1 %= numb2;
        }

        public static int Divide(int num1, int numb2)
        {
            return num1 / numb2;
        }

        public static int Multiply(int num1, int numb2)
        {
            return num1 * numb2;
        }

        public static int Add(int num1, int numb2)
        {
            return num1 + numb2;
        }

        public static int Subtract(int num1, int numb2)
        {
            return num1 - numb2;
        }
    }
}
