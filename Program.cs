using System.ComponentModel;

public class pr1
{
    public static int Add(int x, int y)
    {
        return x + y;
    }
    private static bool IsEven(int number)
    {
        return number % 2 == 0;
    }
    public static void Main(string[] args)
    {
        int num1 = 8;
        int num2 = 4;

        int sum = Add(num1, num2);
        Console.WriteLine($"Сумма {num1} и {num2} равна: {sum}");

        bool isEven = IsEven(num1);
        Console.WriteLine($"{num1} {(isEven ? "четное" : "нечетное")} число");
    }  
}