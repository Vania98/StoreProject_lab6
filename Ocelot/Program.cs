var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("ocelot.json",optional: false, reloadOnChange: true);


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
