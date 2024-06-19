var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "App 2 Home Page");

app.Run();
