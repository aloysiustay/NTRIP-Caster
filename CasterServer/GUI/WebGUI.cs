using System.Threading;
using CasterServer.Client;
using CasterServer.Mountpoint;
using Microsoft.AspNetCore.Builder;
using Microsoft.OpenApi.Models;

namespace CasterServer.GUI
{
    public class WebGUI
    {
        private IHost? m_Host;
        public WebGUI(ILoggerFactory _loggerFactory, MountpointManager _mountpointManager, ClientManager _clientManager, CancellationTokenSource _cancel)
        {
            m_Host = Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseUrls("http://0.0.0.0:18080");

                    webBuilder.ConfigureServices(services =>
                    {
                        services.AddSingleton(_loggerFactory);
                        services.AddSingleton(_mountpointManager);
                        services.AddSingleton(_clientManager);
                        services.AddCors(options =>
                        {
                            options.AddPolicy("AllowAll", builder =>
                            {
                                builder
                                    .AllowAnyOrigin()
                                    .AllowAnyMethod()
                                    .AllowAnyHeader();
                            });
                        });
                        services.AddControllers();
                        services.AddEndpointsApiExplorer();    // Required
                        services.AddSwaggerGen();
                        //services.AddSignalR();
                    });

                    webBuilder.Configure(app =>
                    {
                        var env = app.ApplicationServices.GetRequiredService<IHostEnvironment>();

                        if (env.IsDevelopment())
                        {
                            app.UseDeveloperExceptionPage();
                        }

                        app.UseRouting();
                        app.UseCors("AllowAll");

                        app.UseSwagger();

                        app.UseSwaggerUI(c =>
                        {
                            c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                            c.RoutePrefix = "";
                        });

                        app.UseEndpoints(endpoints =>
                        {
                            //endpoints.MapHub<CasterHub>("/casterHub/mountpoint");
                            endpoints.MapControllers();
                        });
                    });


                })
            .Build();

            m_Host.StartAsync(_cancel.Token);
        }
        public async Task StopAsync()
        {
            if (m_Host != null)
            {
                await m_Host.StopAsync();
                m_Host.Dispose();
            }
        }
    }
}
