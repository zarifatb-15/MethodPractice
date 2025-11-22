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
        // int[] array = { 3, 7, 8 };
        // Console.WriteLine(SumOfArrayElements(array));
        
        // int [] result =AddElementTwoArray(new int[] { 33, 44 }, 66);
        // foreach (int num in result)
        //     Console.WriteLine(num);
       // PrintArrayElements("Zarifa","Babayeva","Telman");
       // Console.WriteLine(Sum(8));
       int num = 70;
       ChangeNum(ref num);
       Console.WriteLine(num);



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

    public static int SumOfArrayElements(int[] array)
    {
        int sum = 0;
        foreach (int num in array)
            sum += num;
        return sum;
    }


    public static string RemoveSpace(String text)
    {
        string newText=String.Empty;
        foreach (char symbol in text)
        {
            if (symbol != ' ')
               newText+=symbol; 
        }

        return newText;
    }

    public static int [] AddElementTwoArray(int[] array, int num)
    {
        int[] newArray = new int [array.Length + 1];
        for (int i=0; i<array.Length; i++)
            newArray[i] = array[i];
        newArray[newArray.Length-1] = num;
        return newArray;

    }

    public static void PrintArrayElements(params string[] names)
    {
        foreach (string name in names)
            Console.WriteLine(name);
    }

    public static int Sum(int e, int r=66)
    {
        return e + r;
    }


    public static void ChangeNum(ref int n)
    {
        
        Console.WriteLine(n);
    }

    public static void ChangeArr(int[] numbers)
    {
       
        Console.WriteLine(numbers[0]);
    }
}