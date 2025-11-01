
using EmployeDetails.Data;
using Microsoft.EntityFrameworkCore;

namespace EmployeDetails
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            
            builder.Services.AddControllers();

            
            builder.Services.AddDbContext<DbFirstContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            


            var app = builder.Build();

            
            app.Run();
        }
    }
}
