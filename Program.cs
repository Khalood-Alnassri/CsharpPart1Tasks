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
                Console.WriteLine(" 3.Find the Smallest Number in a List.");
                Console.WriteLine(" 4.Count Positive and Negative Numbers.");
                Console.WriteLine(" 5.Remove Duplicates from a List.");
                Console.WriteLine(" 6.Find All Prime Numbers Up to N.");
                Console.WriteLine(" 7.Merge Two Sorted Lists.");
                Console.WriteLine(" 8.Find the Second Largest Number.");
                Console.WriteLine(" 9.Check if a String is a Palindrome.");
                Console.WriteLine(" 10.Generate Fibonacci Sequence.");
                
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

                      

                        
                       




                }
            }
        }
    }
}
