using MauiReactor;
using CasterApp.Resources.Styles;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Hosting;
using CasterApp.Components;
using CasterApp.Application;

namespace CasterApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiReactorApp<AppNavigation>(app =>
                {
                    app.UseTheme<ApplicationTheme>();
                },
                unhandledExceptionAction: e => 
                {
                    System.Diagnostics.Debug.WriteLine(e.ExceptionObject);
                })
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            return builder.Build();
        }
    }
}
