
//using System.Security.Cryptography.X509Certificates;
////
//int x = -1;

//if (x>0) // (true) (!true) (x == 1 && x > 0)  MUST BE BOOLEAN value
//{
//    Console.WriteLine("x is greater than 0");
//}
////
//else if (x <0) //runs if top is false
//{
//    Console.WriteLine("x is less than 0");
//}
//else
//{
//    Console.WriteLine("x is not greater than 0"); // runs if both top are false
//}

using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
//
//var userName = "";
//switch (userName)
//{
//	case null:
//		Console.WriteLine(	"the username can't be null!");
//		break;
//	case "ed":
//		Console.WriteLine("please enter something for username");
//		break;
//	case "root":
//	case "Root":
//		Console.WriteLine("you are logged in!");
//		break;
//	default: // equal to else
//		Console.WriteLine("invalid login attempt. please try again");
//		break;
//} //dont have to have a else statement in if else or in switch
////
///

//
//int x = 10;
//int y = 20;

//if (x == y || y > x)
//{
//    Console.WriteLine(1);
//}
//else if (y >= x + 10)
//{
//    Console.WriteLine(2);
//}

//else if (x != y)
//{
//    Console.WriteLine(3);
//}

//else
//{
//    Console.WriteLine(4);
//}


//

string userName = "Root";
string dayOfTheWeek = "Saturday";

switch (dayOfTheWeek)//(dayOfTheWeek.ToLower)

{
	case "monday":
		Console.WriteLine("Today is Monday.");
		break;
    case "tuesday":
		Console.WriteLine("Today is Tuesday.");
		break;

		// continue with days of the week. 


    default:
		Console.WriteLine("This is NOT a day of the week");
		break;
}
