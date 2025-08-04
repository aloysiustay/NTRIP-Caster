using CasterServer.Network;
using CasterServer.Application;
using CasterServer.Mountpoint;
class Program
{
    static void Main(string[] args)
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
        appInstance.Run();
        appInstance.Shutdown();
    }
}