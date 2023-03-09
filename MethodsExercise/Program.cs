namespace MethodsExercise
{
    public class Program
    {
        static int Sum(int sum1, int sum2)
        {
            return sum1 + sum2;
        }
        static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }
        static int Sum(params int[] list)
        {
            int sum = 0;

            for(int i = 0; i< list.Length; i++)
            {
                sum = sum + list[i];
            }

            return sum; 
        }
        static void Main(string[] args)
        {
            Console.WriteLine("--Exercise One--");
            Console.WriteLine("----------------");
            Console.WriteLine(" ");
            Console.WriteLine("What is your name?");
            string? userName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            string? userAge = Console.ReadLine();

            Console.WriteLine("What is a name for a dog?");
            string? userDogName = Console.ReadLine();

            Console.WriteLine("What color is the dog?");
            string? userDogColor = Console.ReadLine();

            Console.WriteLine($"There once was a person named {userName}, they were {userAge} years old.");
            Console.WriteLine($"They had a {userDogColor} dog named {userDogName}.");
            Console.WriteLine($"{userName} loved {userDogName} but they did not love being {userAge} years old.");
            Console.WriteLine(" ");

            Console.WriteLine("--Exercise Two--");
            Console.WriteLine("----------------");
            Console.WriteLine(" ");
            Console.WriteLine($"{userName}, do you know why 6 was afraid of 7?");
            Console.ReadLine();

            int sum = Sum(394, 395);

            Console.WriteLine($"Because {sum}!!!");
            Console.WriteLine(" ");

            Console.WriteLine("--Exercise Three--");
            Console.WriteLine("----------------");
            Console.WriteLine(" ");
            
            int mul = Multiply(12,33,65);

            Console.WriteLine($"{userName}, please multiply 12, 33, & 65.");
            Console.ReadLine();
        
            Console.WriteLine($"The correct answer is {mul}!!");
        }
    }
}
