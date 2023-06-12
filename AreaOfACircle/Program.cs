const double PI = 3.14;
Console.WriteLine("Give me the radius and I will give you the area of the cirlce.");
double radius = Convert.ToDouble(Console.ReadLine());
var AreaOfCirlce = radius * radius * PI;
Console.WriteLine("The area of the circle is: " + AreaOfCirlce);
Console.WriteLine("Press any key to exit.");
Console.ReadKey();
