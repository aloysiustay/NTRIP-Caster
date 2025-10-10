using CasterServer.Network;
using CasterServer.Application;
using CasterServer.Mountpoint;
class Program
{
    static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllers();
        builder.Services.AddCors(options =>
        {
            options.AddPolicy("AllowFrontend", policy =>
            {
                policy.AllowAnyOrigin()
                      .AllowAnyMethod()
                      .AllowAnyHeader();
            });
        });

        App appInstance = new App();
        appInstance.Init();
        builder.Services.AddSingleton(appInstance);

        Console.CancelKeyPress += async (sender, e) =>
        {
            e.Cancel = true;
            await appInstance.ShutdownAsync();
        };

        await appInstance.RunAsync();
        //appInstance.Run();
    }
}