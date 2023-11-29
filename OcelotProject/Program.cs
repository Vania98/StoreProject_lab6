using Microsoft.Extensions.Configuration;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using OcelotProject.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);
builder.Services.AddOcelot(builder.Configuration);
builder.Services.AddHttpClient();

builder.Services.AddHttpClient<IStore_1Service, Store_1Service>
    (c => c.BaseAddress = new Uri("http://localhost:5263"));
builder.Services.AddHttpClient<IStoreProgram_Service, StoreProgram_Service>
    (c => c.BaseAddress = new Uri("http://localhost:5050"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapControllers();
await app.UseOcelot();

app.Run();
