namespace learningcsharp3;
class Program
{
    
    static void Main(string[] args)
    {
       AgeCalculator();
       Console.ReadKey(true);
    }

    static void AgeCalculator()
    {
        string name;
        int yearOfBirth;
        string birthdayThisYear;
        int age;
        int currentYear;

        Console.WriteLine("What is your name?");
        name = Console.ReadLine();

        Console.WriteLine("What is your year of birth?");
        yearOfBirth = Convert.ToInt32( Console.ReadLine() );

        Console.WriteLine("Have you had a birthday yet this year?");
        birthdayThisYear = Console.ReadLine().ToLower();
        currentYear = DateTime.Now.Year;

        if(birthdayThisYear == "yes" || birthdayThisYear == "y")
        {
            age = currentYear - yearOfBirth;
        }
        else
        {
            age = currentYear - yearOfBirth - 1;
        }
        Console.WriteLine($"You are {age} years old");

        if(age < 18)
        {
            Console.WriteLine($"You are a junior, {name}");
        } else if(age >= 18 && age < 30)
        {
            Console.WriteLine($"You are a young adult, {name}");
        } else if(age >= 30 && age < 60)
        {
            Console.WriteLine($"You are an adult, {name}");
        }
        else
        {
            Console.WriteLine($"You are a senior, {name}");
        }
    }

    static void Conditions()
    {
        //Check if x is larger than y
        int x = 20;
        int y = 20;
        int z = 5;

        if (x == y && z < 10) 
        {
            Console.WriteLine("x and y are equal and z is less than 10"); 
        }
        else if(y > x || z < 10)
        {
            Console.WriteLine("y is greater than x or z < 10"); 
        }
        else
        {
           Console.WriteLine("x is greater than y");
        }
    }

    static void swapNumbers()
    {
        string num1, num2, temp;

        Console.WriteLine("Input the first number: ");
        num1 = Console.ReadLine().ToLower();
        Console.WriteLine("Input the second number: ");
        num2 = Console.ReadLine();
        temp = num1;
        num1 = num2;
        num2 = temp;
        Console.WriteLine("After Swapping :");
        Console.WriteLine($"First Number : {num1}");
        Console.WriteLine($"Second Number : {num2}");
    }
}
