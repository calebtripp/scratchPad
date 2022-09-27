//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

////interpolation
//var circles = 10;
//Console.WriteLine($"run around in circles {circles} times");

////add a line (hit enter or + )
//var circles2= 11;
//var circles3= 12;
//Console.WriteLine($"run around in circles {circles2} times,\n" +
//          $"run around in circles {circles2} times");

//var myInt = 14;
//if (myInt > 10 && "Hey" == "Hey") 
//{
//    Console.WriteLine();

//}


//var myInt = 14;
//if (myInt > 10 && "Hey" == "Hey") { Console.WriteLine("It works it works, he's alive!"); }

////for (int i = 0; i < numbers.length; i++) { Console.WriteLine(numbers[i]); }

//namespace ScratchPad
//{

//    var t1 = new Teacher();
//    t1.Name = "John";
//t1.Subject = "Software Engineering";
//Teacher.teacherCount++;
//Console.WriteLine();
//        }
//static void main(string[] args)
//{ 

//}


//internal class Teacher
//{
//    //public static int teacherCount;
//    //public string Name { get; set; }
//    //public string Subject { get; set; }




//    }
//abstract example ...dynamic poly... only at runtime do we know what it is going to be. 

using scratchPad;


//Vehicle vehicle;
//Console.WriteLine("Please enter which vehicle you would like");
//var userInput = Console.ReadLine().ToLower();


//if (userInput == "plane")
//{
//     vehicle = new Plane();
//}
//else if (userInput == "boat")
//{
//    vehicle = new Boat();
//}

Console.WriteLine(vehicle.GetType());
var b1 = new Boat();
b1.PrintVehicleInfo();