using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System;
using TeDo.Libraries;
using Syncfusion.Blazor;
using TeDo.Server.Data;

namespace TeDo.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddHttpClient("TeDo.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
                .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

            // Supply HttpClient instances that include access tokens when making requests to the server project
            builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("TeDo.ServerAPI"));

            builder.Services.AddSingleton<IStorageService, StorageService>();

            builder.Services.AddApiAuthorization();
            builder.Services.AddBlazorBootstrap();
            builder.Services.AddScoped<WordService>();


            await builder.Build().RunAsync();
        }
    }
}