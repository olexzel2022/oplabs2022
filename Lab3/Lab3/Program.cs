CityModel kyiv = RetrieveFromConsole();
Console.WriteLine(kyiv);


static CityModel RetrieveFromConsole()
{
    Console.Write("Enter city name: ");
    string name = Console.ReadLine();
    Console.Write("Enter country: ");
    string country = Console.ReadLine();
    Console.Write("Enter population: ");
    int population = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter area: ");
    double area = Convert.ToDouble(Console.ReadLine());
    return new(
        name: name,
        country: country,
        population: population,
        area: area);
}


public class CityModel
{
    public CityModel(string name, string country, int population, double area)
    {
        Name = name;
        Country = country;
        Population = population;
        Area = area;
    }
    public string Name { get; set; }
    public string Country { get; set; }
    public int Population { get; set; }
    public double Area { get; set; }

    public override string ToString()
    {
        return $"\nCity: {Name}\n" +
            $"Country: {Country}\n" +
            $"Population {Population}\n" +
            $"Area: {Area}";
    }
}