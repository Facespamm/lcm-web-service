using System.Numerics;

namespace lsm_web_service;

public class Program
{
    static void Main(string[] args)
    {
        var app = WebApplication.Create(args);
        var URL = "/app/Task3/CalculateLCM/turrin_shura_gmail_com";
        var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
       
        app.MapGet($"{URL}", (string x, string y) =>
        {
            bool xParse = BigInteger.TryParse(x, out BigInteger xValue); 
            bool yParse = BigInteger.TryParse(y, out BigInteger yValue);
            if (xParse && yParse && xValue > 0 && yValue > 0)
            {
                var calculate = new Calculate(xValue, yValue);
                var result = calculate.GetLCM(xValue, yValue);
                return Results.Text(result.ToString(), "text/plain");            }
            else
            {
                return Results.Text("NaN", "text/plain");            }
        });
        
        app.Run();
    }
}