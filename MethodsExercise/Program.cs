namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");

            //string? name = Console.ReadLine();

            //Console.WriteLine("I like your name, now what is your favorite color?");

            //string? faveColor = Console.ReadLine();

            //Console.WriteLine("That's a great color! What is your favorite animal?");

            //string? faveAnimal = Console.ReadLine();

            //Console.WriteLine("I love that animal, too! Now, last question - what is your favorite band?");

            //string? faveBand = Console.ReadLine();

            //Console.WriteLine($"Meet, {name}. This fabulous person loves to pet {faveColor} {faveAnimal}s while jamming out to {faveBand}!");

            Console.WriteLine("Give me a number to add.");
            int addend1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me another number to add to that number.");
            int addend2 = int.Parse(Console.ReadLine());

            int sum = Sum(addend1, addend2);

            Console.WriteLine($"The sum of {addend1} and {addend2} is: {sum}.");

            Console.WriteLine("Give me a number");
            int factor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me another number to multiply the first number by.");
            int factor2 = int.Parse(Console.ReadLine());

            int product = Multiply(factor1, factor2);

            Console.WriteLine($"The answer to the multiplication problem is {product}");
        }
        //INSIDE THE CLASS BUT OUTSIDE OF THE PREVIOUS METHOD
        public static int Sum(params int[] list)
        {
            int sum = 0; //declaring sum, initializing sum
            for (int i = 0; i < list.Length; i++) 
            {
                sum = sum + list[i];
            }
            return sum;
        }

        public static int Multiply(int factor1, int factor2)
        {
            return factor1 * factor2;
        }
    }
}
