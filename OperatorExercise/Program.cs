//////////////////////////////// Exercise 1/////////////////////////////////////////////////////////////////////////////////////////////////
////int x = 20;
////int y = 10;

////x += y; // 30
////x -= y; // 10
////x *= y; // 200
////x %= y; // 0


//int a = 17;
//int b = 4;

//var q = a / b;
//var r = a % b;  

//if (a == 17 && b == 4)
//{
//    Console.WriteLine($"{a} / {b} is {q} remainder {r}");
//}
//else
//{
//    Console.WriteLine("fix variables to correct intigers");
//}

////////////////////////////////// Exercise 2 //////////////////////////////////////////////////////////////////////////////////////////////////////


using OperatorExercise;

Console.WriteLine("what is the radius of the circle?");
var radius = Convert.ToDouble(Console.ReadLine());
var area = Methods.AreaOfCircle(radius);
Console.WriteLine(area);
