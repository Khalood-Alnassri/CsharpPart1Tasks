namespace CsharpTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to system");
                Console.WriteLine("Select the process you need: ");
                Console.WriteLine(" 1.Calculate the average of five numbers.");
                Console.WriteLine(" 2.Check whether a number is even or odd.");
                
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {

                    case 1:
                        Console.WriteLine("Enter the first number :");
                        float number1 = float.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the secound number :");
                        float number2 = float.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the theird number :");
                        float number3 = float.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the four number :");
                        float number4 = float.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the five number :");
                        float number5 = float.Parse(Console.ReadLine());

                        float result = number1 + number2 + number3 + number4 + number5;
                        Console.WriteLine("The result is :" + result);

                        float avg = result / 5;
                        Console.WriteLine("The avrage is :" + avg);
                        break;

                        case 2:
                        Console.WriteLine("Enter The Number :");
                        float number = float.Parse(Console.ReadLine());

                        if (number % 2 == 0)
                        {
                            Console.WriteLine("even");
                        }
                        else
                        {
                            Console.WriteLine("odd");
                        }
                        break;









                }
            }
        }
    }
}
