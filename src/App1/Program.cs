var builder = WebApplication.CreateBuilder(args);
builder.Services.AddLogging(x => x.AddSimpleConsole(c => c.SingleLine = true));
var app = builder.Build();

app.MapGet("/", () => "App 1 Home Page");
app.MapGet("/health/alive", () => "alive");
app.MapGet("/health/ready", () => "ready");

app.Run();
