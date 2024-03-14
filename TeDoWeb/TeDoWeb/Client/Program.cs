using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;
using TeDoWeb.Library.Services;

namespace TeDoWeb.Client
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBPh8sVXJwS0d+WFBPd11dXmJWd1p/THNYflR1fV9DaUwxOX1dQl9nSX1SckVgXXxdcHRUQ2A=;Mgo+DSMBMAY9C3t2UVhhQlVFfV5AQmBIYVp/TGpJfl96cVxMZVVBJAtUQF1hTX5Qd0FjWntdc3RVRWBa;MzE1ODgzOUAzMjM0MmUzMDJlMzBTcjVlZTMvVTBURitwWUJtVjJ2WHJ5MUhKcUxvTWp2bmpCZmd5VDhIclBNPQ==");
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
			builder.Services.AddMemoryCache();
			builder.RootComponents.Add<App>("#app");
			builder.RootComponents.Add<HeadOutlet>("head::after");

			builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

			builder.Services.AddSingleton<IStorageService, StorageService>();
			builder.Services.AddSingleton<ITestDocumentService, TestDocumentService>();
            builder.Services.AddSyncfusionBlazor();

            await builder.Build().RunAsync();
		}
	}
}