////// See https://aka.ms/new-console-template for more information
////using System.Runtime.ExceptionServices;

////Console.WriteLine("Hello, World!");


//////CountdownEvent by three from 3 999

//////for (int i = 3; i <= 999; i+=3)
//////{
//////    Console.WriteLine(i);
//////}
//internal class Methods
//{

//    public static string equalOrNot(int num1, int num2)
//    {

////        if (num1 == num2)
////        {
////            return Convert.ToString(Console.WriteLine("equal"));
////        }
////        else
////        {
////            return Convert.ToString(Console.WriteLine("not equal");)
////        }

////    }
////}

////public static void CanVote()
////{
////    Console.Write("Please enter your age: "); //write has curser blinking...?
////    bool couldParseAge = int.TryParse(Console.ReadLine()), out int xage);
////    if (AggregateException >= 18)
////    {
////       Console.WriteLine("you can vote");
////    }
////    else
////    {
////    Console.WriteLine("you can not vote");
////    }


////}

//// Method Overloading
//using System.Reflection.Metadata.Ecma335;

//internal class Methods
//{

//    public static int Add(params int[] numbers)
//    {
//        int sum = 0;
//        foreach (var item in collection)
//        {

//        }
//    }
//    public static double Add(params double;[] numbers)

//    public static int Add(int x, int y)
//    {
//        return x + y;
//    }

//    public static double Add(int x, int y)
//    {
//        return x + y
//    }
//    //param signature.  for example to handle different variables in same array from calling only one method. the compiler will know what to use
//    //based on the method that has the appropriate variable signature.
//    //signature = param type
//    //nice to have different methods for ints, doubles, decimals - handles all. 
//}

//see EXAMPLE BELOW - BASICALLY, THE SIGNATURE MUST HAVE DIFFERENT VARIABLES TO OVERLOAD
internal class Methods
{ 
public static int Add(int x, int y)
{
    return x + y;
}

public static int Add(int x, double y)
{
    return (int)(x + y);
}
}
//essentially doing the same process to different data types.
//in example above, adding both, but 