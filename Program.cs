
using Microsoft.AspNetCore.Builder;

internal class Program
{
    public static void Main( string[] args )
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", () => "index.html");

        app.Run();
    }
}
