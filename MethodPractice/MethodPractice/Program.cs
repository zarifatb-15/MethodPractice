using System.Globalization;
using System.Text;

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
       // int num = 70;
       // ChangeNum(ref num);
       // Console.WriteLine(num);
       //String Methods
       string str ="Hello, Zarifa!";
       // string str2 = str;
       // str2 = " ";
       // Console.WriteLine(str);
       // ReverseStr("Zarifa");
       // Console.WriteLine(ReverseStr("Zarifa"));
       // Console.WriteLine(ReverseStr("Zarifa!"));
       // Console.WriteLine(str.Length);
       // CultureInfo cultureInfo=new CultureInfo("az-Latn-AZ");
       // Console.WriteLine(str.ToUpper(cultureInfo));
       // Console.WriteLine(str.ToLower());
       // Console.WriteLine(str.ToUpperInvariant());
       // Console.WriteLine(str.ToLowerInvariant());
       // Console.WriteLine("Zarifa" == "zarifa");
       // Console.WriteLine("Zarifa".ToUpper() == "zarifa".ToUpper());
       // Console.WriteLine(str.Contains('Z'));
       // Console.WriteLine(str.Contains("zari",StringComparison.OrdinalIgnoreCase));
       // Console.WriteLine(str.StartsWith('A'));
       // Console.WriteLine(str.StartsWith("he",StringComparison.OrdinalIgnoreCase));
       // Console.WriteLine(str.EndsWith("he",StringComparison.OrdinalIgnoreCase));
       // Console.WriteLine(str.Trim());
       // Console.WriteLine(str.TrimStart());
       // Console.WriteLine(str.TrimEnd());
       // Console.WriteLine(str.Replace(',','.'));
       // Console.WriteLine(str.Replace("Zarifa","Zarifaaaaa"));
       // Console.WriteLine(str.IndexOf('Z'));
       // Console.WriteLine(str.LastIndexOf('a'));
       // Console.WriteLine(str.IndexOf("Za",4));
       // Console.WriteLine(str.CompareTo());
       Console.WriteLine(str.Equals("Hello"));
       string text = "  Hello   World  !  ";
       Console.WriteLine(RemoveSpace(text));
       
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

    // public static string ReverseStr(string str)
    // {
    //     string newStr = "";
    //     for (int i = str.Length - 1; i >= 0; i--)
    //     {
    //         newStr += str[i];
    //     }
    //
    //     return newStr;
    // }
    
    public static string ReverseStr(string str)
    {
        StringBuilder stringbuilder= new StringBuilder();
        for (int i = str.Length - 1; i >= 0; i--)
        {
            stringbuilder.Append(str[i]);
        }

        return stringbuilder.ToString();
    }
}