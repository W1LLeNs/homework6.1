/* -----------------------------------------------------------------------ПРОГРАМА 1
public class Program
{

    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Введіть кількість працівників:");
        int number = int.Parse(Console.ReadLine());
        double sum = 0;

        for (int i=1; i<=number; i++)
        {
            Console.WriteLine($"Введіть зарплату працівника в гривнях {i}: ");
            sum += double.Parse(Console.ReadLine());
        }

        double mid = sum / number;
        Console.WriteLine($"Середній заробіток: {mid}");
    }
}
-----------------------------------------------------------------------*/


/* --------------------------------------------------------------------ПРОГРАМА 2
public class Program
{

    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Введіть кількість рядків:");
        int numberOfStrings = int.Parse(Console.ReadLine());
        Console.WriteLine("Результат:");
        for (int i = 0; i <= numberOfStrings; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
-----------------------------------------------------------------------*/

/* --------------------------------------------------------------------ПРОГРАМА 3 
public class Program
{

    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введіть число, до якого повинні вивестись прості числа: ");
        int lastValue = int.Parse(Console.ReadLine());

        for (int number = 2; number <= lastValue; number++)
        {
            bool primeNumber = true;

            for (int divider = 2; divider * divider <= number; divider++)
            {
                if (number % divider == 0)
                {
                    primeNumber = false;
                    break;
                }
            }
            if (primeNumber)
            {
                Console.WriteLine(number);
            }
        }
    }
}
-----------------------------------------------------------------------*/

/*--------------------------------------------------------------------- ПРОГРАМА 4
public class Program
{

    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введіть пароль (повинен містити прийнамні 8 символів, хочаб один символ - цифра, хочаб один символ - спеціальний (наприклад, !, @, # тощо)");
        var password = Console.ReadLine();

        bool isPasswordCorrect = false;
        bool isPasswordMoreThan8Sym = true;
        bool isPasswordIncludeNum = false;
        bool isPasswordIncludeSpecSym = false;

        if (password.Length < 8)
        {
            isPasswordMoreThan8Sym = false;
            Console.WriteLine("Пароль замалий!");
        } 

        string specSym = "!@#$%^&*(),.?\"{}|<>";
        string nums = "1234567890";
        foreach (char ch in password)
        {
            if (specSym.Contains(ch))
            {
                isPasswordIncludeSpecSym = true;
              
            }
            else if (char.IsDigit(ch))
            {
                isPasswordIncludeNum = true;
            }
        }

        if (isPasswordIncludeNum && isPasswordIncludeSpecSym && isPasswordMoreThan8Sym)
        {
            Console.WriteLine("Пароль підходить");
        }
    }
}
-----------------------------------------------------------------------*/

/* -----------------------------------------------------------------------ПРОГРАМА 5
public class Program
{

    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введіть кінцеве число:");
        if (int.TryParse(Console.ReadLine(), out int num))
        {
            int a = 0; int b = 1;
            Console.WriteLine("Послідовність Фібоначчі: ");
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine(a);
                (a, b) = (b, a + b);
            }
        }
    }
}
----------------------------------------------------------------------------*/

/* -----------------------------------------------------------------------ПРОГРАМА 6
public class Program
{

    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введіть кількість годин:");
        int hours = int.Parse(Console.ReadLine());
        Console.WriteLine("Введіть розмір годинної ставки");
        int moneyPerHour = int.Parse(Console.ReadLine());

        int payDay = hours * moneyPerHour;
        Console.WriteLine($"Ваш денний заробіток становить: {payDay}");
    }
}
----------------------------------------------------------------------------*/

/* -----------------------------------------------------------------------ПРОГРАМА 7
public class Program
{

    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Введіть число, для якого треба вивести таблицю множення:");
        if (int.TryParse(Console.ReadLine(), out int num))
        {
            Console.WriteLine("Результати: ");
            for (int multip = 1; multip <= 10; multip++)
            {
                int result = num * multip;
                Console.WriteLine($"{num} * {multip} = {result}");
            }
        }
    }
}
-----------------------------------------------------------------------*/


/* ---------------------------------------------------------------------ПРОГРАМА 8
public class Program
{

    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("введіть імовірно просте число: ");
        int num = int.Parse(Console.ReadLine());

        bool isNumPrime = false;

            if (num < 2)
            {
                isNumPrime = false;
            }
            else
            {
                for (int i = 2; i < num; i++)
                {
                    if (i % 2 == 0)
                    {
                        isNumPrime = true;
                    }
                    break;
                }
            }
            if (isNumPrime)
            {
                Console.WriteLine($"Число {num} є простим");
            }
            else
            {
                Console.WriteLine($"Число {num} не є простим");
            }
    }
}
------------------------------------------------------------------------*/



