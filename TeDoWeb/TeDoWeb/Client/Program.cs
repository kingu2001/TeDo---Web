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
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NAaF1cXmhKYVJ/WmFZfVpgcl9CYVZQRmYuP1ZhSXxXdkZiW39YdHVURGFUV0Q=");
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
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