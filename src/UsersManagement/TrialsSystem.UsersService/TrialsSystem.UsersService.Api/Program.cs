using System.Reflection;
using FluentValidation;
using MediatR;
using Microsoft.OpenApi.Models;
using TrialsSystem.UsersService.Api.Application.Validation.CityManagementValidators;
using TrialsSystem.UsersService.Api.Application.Validation.UserManagementValidators;
using TrialsSystem.UsersService.Api.Filters;

namespace TrialsSystem.UsersService.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddFluentValidationAutoValidation();

            builder.Services.AddValidatorsFromAssemblyContaining<CreateUserRequestValidator>();
            builder.Services.AddValidatorsFromAssemblyContaining<UpdateUserRequestValidator>();
            builder.Services.AddValidatorsFromAssemblyContaining<GetUserByIdQueryValidator>();

            builder.Services.AddValidatorsFromAssemblyContaining<CreateCityRequestValidator>();
            builder.Services.AddValidatorsFromAssemblyContaining<UpdateCityRequestValidator>();
            builder.Services.AddValidatorsFromAssemblyContaining<GetCityByIdQueryValidator>();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new OpenApiInfo { Title = "TrialsSystem.UsersService", Version = "v1" }

                    );
                var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
            });

            builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
            builder.Services.AddScoped<UserExceptionFilter>();

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