using Syncronaut.Server.Services;

namespace Syncronaut.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            // Add services to the container.
            builder.Services.AddGrpc();

            var app = builder.Build();

            app.UseHttpsRedirection();

            app.UseAuthentication();

            app.MapControllers();

            // Configure the HTTP request pipeline.
            app.MapGrpcService<SyncronautService>();


            app.Run();
        }
    }
}