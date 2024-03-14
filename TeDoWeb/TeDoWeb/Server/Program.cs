using Microsoft.AspNetCore.ResponseCompression;
using Syncfusion.Blazor;

namespace TeDoWeb
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllersWithViews();
			builder.Services.AddRazorPages();
			builder.Services.AddServerSideBlazor().AddHubOptions(o => { o.MaximumReceiveMessageSize = 102400000; });
			builder.Services.AddSyncfusionBlazor();
			builder.Services.AddMemoryCache();
			var app = builder.Build();

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBPh8sVXJwS0d+WFBPd11dXmJWd1p/THNYflR1fV9DaUwxOX1dQl9nSX1SckVgXXxdcHRUQ2A=;Mgo+DSMBMAY9C3t2UVhhQlVFfV5AQmBIYVp/TGpJfl96cVxMZVVBJAtUQF1hTX5Qd0FjWntdc3RVRWBa;MzE1ODgzOUAzMjM0MmUzMDJlMzBTcjVlZTMvVTBURitwWUJtVjJ2WHJ5MUhKcUxvTWp2bmpCZmd5VDhIclBNPQ==");
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
			{
				app.UseWebAssemblyDebugging();
			}
			else
			{
				app.UseExceptionHandler("/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();

			app.UseBlazorFrameworkFiles();
			app.UseStaticFiles();

			app.UseRouting();


			app.MapRazorPages();
			app.MapControllers();
			app.MapFallbackToFile("index.html");

			app.Run();
		}
	}
}