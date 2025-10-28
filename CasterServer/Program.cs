using CasterServer.Network;
using CasterServer.Application;
using CasterServer.Mountpoint;
class Program
{
    static async Task Main(string[] args)
    {
        App appInstance = new App();
        appInstance.Init();

        Console.CancelKeyPress += async (sender, e) =>
        {
            e.Cancel = true;
            await appInstance.ShutdownAsync();
        };

        await appInstance.RunAsync();
        //appInstance.Run();
    }
}