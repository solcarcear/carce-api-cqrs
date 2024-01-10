using CARCE.API;

internal class Program
{
    private static void Main(string[] args)
    {     
        var builder = WebApplication.CreateBuilder(args);
        {
            builder.Services
                .AddPresentation();
                //.AddApplication()
                //.AddInfrastructure(builder.Configuration);
        }

        // Configure the HTTP request pipeline.

        var app = builder.Build();
        {
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.UseSwagger();
            app.UseSwaggerUI();
            app.Run();  
        }
    }
}