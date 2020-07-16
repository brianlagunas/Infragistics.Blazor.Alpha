using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Infragistics.Blazor.Controls;
using IgBlazorSamples.Data.Services;

namespace igBlazorSamples.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            //register Infragistics Blazor
            builder.Services.AddInfragisticsBlazor();

            builder.Services.AddScoped<IFinancialDataService, FinancialDataService>();
            builder.Services.AddScoped<CategoryChartService>();
            builder.Services.AddScoped<StockService>();
            builder.Services.AddScoped<ChartItemService>();

            await builder.Build().RunAsync();
        }
    }

    public static class ServiceCollectionExtensions
    {
        public static void AddInfragisticsBlazor(this IServiceCollection services)
        {
            services.AddScoped(typeof(IInfragisticsBlazor), typeof(InfragisticsBlazor));
        }
    }
}
