// See https://aka.ms/new-console-template for more information

//simple speedint ticket program
//assume anything going over 120 is speeding
Console.WriteLine("Provide Speed: ");
double speed = Double.Parse(Console.ReadLine());

if (speed > 120)
{
    Console.WriteLine("Speeding ticket!");
}
else
{
    Console.WriteLine("Carry on ahead");
}
Console.ReadLine();


