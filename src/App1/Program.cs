var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "App 1 Home Page");

app.Run();
