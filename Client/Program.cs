using Blazored.LocalStorage;
using Client;
using ClientLibrary.Helpers;
using ClientLibrary.Services.Contracts;
using ClientLibrary.Services.Implementations;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;
using Syncfusion.Blazor.Popups;
using static Syncfusion.Licensing.SyncfusionLicenseProvider;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
// Registering the custom http handler
builder.Services.AddTransient<CustomHttpHandler>();

builder.Services.AddHttpClient("SystemApiClient", client =>
{
    client.BaseAddress = new Uri("https://localhost:7294");
}).AddHttpMessageHandler<CustomHttpHandler>();
// builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7294") });
builder.Services.AddAuthorizationCore();

// Registering the Blazored local storage
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped<GetHttpClient>();
builder.Services.AddScoped<LocalStorageService>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
builder.Services.AddScoped<IUserAccountService, UserAccountService>();
// Registering the Syncfusion dialog service
string syncfusionLicenseKey = Environment.GetEnvironmentVariable("SYNCFUSION_LICENSE_KEY");
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(syncfusionLicenseKey);
builder.Services.AddSyncfusionBlazor();
builder.Services.AddScoped<SfDialogService>();
// Registering the custom authentication state provider
await builder.Build().RunAsync();
