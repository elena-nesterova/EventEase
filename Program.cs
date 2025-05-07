using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using EventEase;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
});
builder.RootComponents.Add<HeadOutlet>("head::after");

// Add services to the container.
builder.Services.AddSingleton<EventService>(); 
builder.Services.AddSingleton<UserSessionService>();

await builder.Build().RunAsync();
