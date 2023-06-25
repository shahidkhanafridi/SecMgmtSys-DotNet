global using SMSApi.Data;
global using SMSApi.Data.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SMSApi.BLL;
using SMSApi.Helpers;
using System.Text;

namespace SMSApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Adding Automapper
            builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

            // adding JWT
            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    string secKey = builder.Configuration["Jwt:Key"].ToString();
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidIssuer = builder.Configuration["Jwt:Issuer"],
                        ValidAudience = builder.Configuration["Jwt:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secKey))
                    };
                });

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();

            var connectionString = builder.Configuration.GetConnectionString("AppDb");
            //builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(connectionString, sqlServerOptions => sqlServerOptions.MigrationsAssembly("")));
            builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(connectionString));
            builder.Services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            //builder.Services.AddScoped(typeof(IBaseService), typeof(BaseService));
            //builder.Services.AddScoped(typeof(IUserRepository), typeof(UserRepository));

            builder.Services.AddScoped<IUserService, UserService>();

            builder.Services.AddSwaggerGen();
            builder.Services.AddMvc(opt => opt.Filters.Add(new GlobalFilterAttribute()));
            //builder.Services.AddScoped<GlobalFilterAttribute>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseAuthentication();//using authentication
            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}