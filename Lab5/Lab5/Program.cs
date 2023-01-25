var x = new ConsoleWebServer() as IWebServer;
x.Populate();
x.ShowInfo();

public class ConsoleWebServer : IWebServer
{
    string Name { get; set; }
    string Url { get; set; }
    int Port { get; set; }

    public void Populate()
    {
        Console.WriteLine("Enter name:");
        Name = Console.ReadLine();
        Console.WriteLine("Enter url:");
        Url = Console.ReadLine();
        Console.WriteLine("Enter port:");
        var x = int.TryParse(Console.ReadLine(), out var port);
        Port = port;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Server: {Name}, url: {Url}, port: {Port}");
    }
}

public interface IWebServer
{
    void Populate();
    void ShowInfo();
}