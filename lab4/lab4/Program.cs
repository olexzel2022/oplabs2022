Console.Write("Enter x: ");
int x = Convert.ToInt32(Console.ReadLine()), y = 3;

int z = x * y;

Console.WriteLine($"x * y = {x} * {y} = {z}");

if (z > 15)
    Console.WriteLine("Bigger than 15");
else if (!(z > 15))
    Console.WriteLine("Not bigger than 15");
