using System;

class Program
{
    static void Main(string[] args)
    {
      List<int> numbers = new List<int>();
       int userNumber = -1;
        while (userNumber != 0)
        {
             Console.Write("Enter a number (0 to quit): ");
            
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
            int sum = 0;
            
            foreach (int number in numbers)
             {
             sum += number;
             }
            Console.WriteLine($"The sum is: {sum}");

            //Part 2
            float average = ((float)sum) / numbers.Count;
            Console.WriteLine($"The average is: {average}");

            //Part 3
            int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");

        }
    }
}