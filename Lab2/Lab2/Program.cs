CityModel kyiv = new(
    name: "Kyiv",
    country: "Ukraine",
    population: 5000000,
    area: 838.9,
    localTime: DateTime.Now);

Console.WriteLine(kyiv);


public class CityModel
{
    public CityModel(string name, string country, int population, double area, DateTime localTime)
    {
        Name = name;
        Country = country;
        Population = population;
        Area = area;
        LocalTime = localTime;
    }
    public string Name { get; set; }
    public string Country { get; set; }
    public int Population { get; set; }
    public double Area { get; set; }
    public DateTime LocalTime { get; set; }

    public override string ToString()
    {
        return $"City: {Name}\n" +
            $"Country: {Country}\n" +
            $"Population {Population}\n" +
            $"Area: {Area}\n" +
            $"Local time: {LocalTime}";
    }
}