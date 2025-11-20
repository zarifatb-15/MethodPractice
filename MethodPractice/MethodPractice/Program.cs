namespace MethodPractice;

class Program
{
    static void Main(string[] args)
    {
        // PrintHello();
        // PrintNameAndSurname("Lorem","Ipsumov"); //arguments
        // SumTwoElements(10, 15);
        // Console.WriteLine(SumTwoElements(10, 15));
        // int result =SumTwoElements(10, 15);
        // Console.WriteLine(result);
        // Console.WriteLine(SumTwoElements(10, 15));
        // Console.WriteLine(SumThreeElements(10, 20, 30));
        // Console.WriteLine(CompareTwoElements(20,15));
        // Console.WriteLine(CompareTwoElements(10, 2));
    }

    public static void PrintHello()
    {
        Console.WriteLine("Hello, World!");
    }

    public static void PrintNameAndSurname(string firstName, string surname) //parametrs
    {
        Console.WriteLine($"Hello, {firstName}, {surname}");
    }

    public static int SumTwoElements(int a, int b)
    {
        return a + b;
    }

    public static int SumThreeElements(int a, int b, int c)
    {
        return SumTwoElements(2,4) + c;
    }

    // public static bool CompareTwoElements(double a, double b)
    // {
    //     if (a > b)
    //         return true;
    //     else
    //         return false;
    // }
    public static bool CompareTwoElements(int a, int b)
    {
        return a > b;
    }
}