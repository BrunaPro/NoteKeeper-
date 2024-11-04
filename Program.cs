using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NoteKeeper.Data;
using NoteKeeper.Repository;
using NoteKeeper.Repository.Interface;

namespace NoteKeeper
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            builder.Services.AddDbContext<NoteSystemDBContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase")));

             builder.Services.AddScoped<IUserRepository, UserRepository>();

            builder.Services.AddScoped<INotesRepository, NotesRepository>();

          
            
            
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}