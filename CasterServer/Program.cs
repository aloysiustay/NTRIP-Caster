using CasterServer.Network;
class Program
{
    static async Task Main(string[] args)
    {
        // Your code starts here
        Console.WriteLine("Hello, NTRIP Caster!");
        NetworkInterface networkInterface = new();
        await networkInterface.UseSourceTableAsync();

    }
}