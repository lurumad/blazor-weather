using BlazorWeather.Client.State;
using Microsoft.AspNetCore.Blazor.Browser.Rendering;
using Microsoft.AspNetCore.Blazor.Browser.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorWeather.Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new BrowserServiceProvider(configure =>
            {
                configure.AddSingleton<AppState>();
            });

            new BrowserRenderer(serviceProvider).AddComponent<App>("app");
        }
    }
}
