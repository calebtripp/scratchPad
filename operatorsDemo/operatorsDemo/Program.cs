//using operatorsDemo;
//using System.Security.Cryptography.X509Certificates;

//Console.WriteLine(Methods.Modulus(7, 5));
// above makes the methods example work, uncomment and comment everything else for reference. 



// int x = 10;
// x++
//++x
//increment operator 
//x++;

//int y = 20;
//int test = y++; // =20  ++y = 20
////y++; = 21
//Console.WriteLine(y);

//post increment exercise
//int j = 1;
//int k = 2;

//int i = j++ - ++k;
//Console.WriteLine(i);
//-2 is correct
//new 

//var answer = 5 == 5;
//Console.WriteLine(answer);

//5 = true

//using System.Threading.Channels;

//var answer = true == Convert.ToBoolean("true");
//Console.WriteLine(answer);
////

////
//string password = Console.ReadLine();
//string userName = Console.ReadLine();

//while // needs to go in here somewhere, where??
//if (userName == "sdfds" && password == "sdfsdfds")
//  {
//    Console.WriteLine("you are logged in");
//    break;
//  }
//else 
//{
//    Console.WriteLine("please try again"); 
//}

//int x = 1;
//int y = 2;

//if (x> 0 && y > 0)
//{
//    Console.WriteLine(true);
//    }
//else
//{
//    Console.WriteLine(false);
//}

//

//int a = 5;
//int b = 6;
//a %= b;
//Console.WriteLine(a);
//// comes out to 0r5

//double a = 5;
//double b = 6;
//a %= b;
//Console.WriteLine(a);
//5

////ternary operator (short if else statement)  this is syntax sugar
//int age = 23;
//string answer = age >= 23 ? "you are old enough to vote" : "you are not old enough to vote";
//Console.WriteLine(answer);
////

/////////////////////////////var exampleValue = possiblyNullValue ?? someDefaultValue;
//Console.WriteLine("please enter a whole number");
using System.ComponentModel;
///
///
int? a = null;
int? x = a ?? 100;
Console.WriteLine(x); // outputs 100 because a is null, so the double ?? will go with the other value on the right side
//

var myList = new List<string>();
myList.Add("some string");
myList?.Add("sommestring");
//ternary null (Braydon) unfinished example
//var exampleValue = exampleList?.Add("myString");
