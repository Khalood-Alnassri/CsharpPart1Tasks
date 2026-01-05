using System.ComponentModel;

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
                Console.WriteLine(" 6. Find All Prime Numbers Up to N.");
                Console.WriteLine(" 7. Merge Two Sorted Lists.");

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

                    case 3:
                        Console.WriteLine("Enter how many numbers you need :");
                        int n = int.Parse(Console.ReadLine());
                        int[] numbers = new int[n];


                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine(" Enter number :");
                            numbers[i] = int.Parse(Console.ReadLine());
                        }

                        int smallest = numbers[1];
                        for (int i = 0; i < n; i++)
                        {
                            if (smallest > numbers[i])
                            {
                                smallest = numbers[i];
                            }
                        }
                        Console.WriteLine(" The smallest number is :" + smallest);
                        Console.Read();


                        break;

                    case 4:
                        Console.WriteLine("Enter how many numbers you need :");
                        int nr = int.Parse(Console.ReadLine());
                        int[] array = new int[nr];


                        for (int i = 0; i < nr; i++)
                        {
                            Console.WriteLine(" Enter number :");
                            array[i] = int.Parse(Console.ReadLine());
                        }

                        int positive = 0;
                        int negative = 0;
                        for (int i = 0; i < nr; i++)
                        {

                            if (array[i] > 0)
                            {
                                positive = positive + 1;
                            }
                            else
                            {
                                negative = negative + 1;
                            }
                        }

                        Console.WriteLine("The positive numbers =" + positive);
                        Console.WriteLine("The negative numbers =" + negative);
                        Console.Read();


                        break;

                    case 5:
                        Console.WriteLine("Enter the list of numbers:");
                        int List = int.Parse(Console.ReadLine());
                        int[] Lists = new int[List];

                        int newList = List;
                        for (int i = 0; i < List; i++)
                        {
                            Console.WriteLine(" Enter the number :");
                            Lists[i] = int.Parse(Console.ReadLine());
                        }

                        bool Duplicate = false;
                        for (int i = 0; i < newList; i++)
                        {
                            for (int j = i + 1; j < newList; j++)
                            {
                                if (Lists[i] == Lists[j])
                                {
                                    Duplicate = true;

                                    for (int m = j; m < newList - 1; m++)
                                    {

                                        Lists[m] = Lists[m + 1];

                                    }
                                    newList--;
                                    j--;

                                }

                            }

                        }

                        Console.WriteLine("The List after remoing duplicate:");
                        for (int i = 0; i < newList; i++)
                        {
                            Console.WriteLine(Lists[i] + " ");
                        }





                        break;

                    case 6:
                        Console.WriteLine("Enter how many number :");
                        int B = int.Parse(Console.ReadLine());
                        int[] num = new int[B];

                        for (int i = 0; i < B; i++)
                        {
                            Console.WriteLine(" Enter the number:");
                            num[i] = int.Parse(Console.ReadLine());
                        }


                        int Prime_count = 0;
                        for (int i = 0; i < B; i++)
                        {
                            bool Prime_num = true;
                            if (num[i] <= 1)
                            {
                                Prime_num = false;
                            }
                            else
                            {
                                for (int S = 2; S < num[i]; S++)
                                {

                                    if (num[i] % S == 0)
                                    {
                                        Prime_num = false;
                                        break;
                                    }

                                 

                               

                                }

                            }

                            if (Prime_num)
                            {
                                Prime_count++;
                            }

                        }
                        Console.WriteLine("The prime count is =" + Prime_count);

                        break;

                        case 7:
                        Console.WriteLine("Write list 1:");
                        string A = Console.ReadLine();
                        string[] list1 = A.Split(' ');
                        Console.WriteLine("Write list 2");
                        string R = Console.ReadLine();
                        string[] list2 = R.Split(' ');











                        break;



























                }
            }
        }
    }
}
