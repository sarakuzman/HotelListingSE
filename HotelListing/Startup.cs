using AspNetCoreRateLimit;
using HotelListing.Core;
using HotelListing.Core.IRepository;
using HotelListing.Core.Repository;
using HotelListing.Core.Services;
using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace HotelListing
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {


            services.AddDbContext<DatabaseContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("sqlConnection"))
            );

            services.AddMemoryCache();

            services.ConfigureRateLimiting();
            services.AddHttpContextAccessor();


            services.ConfigureHttpCacheHeaders();



            services.AddAuthentication();
            services.ConfigureIdentity();
            services.ConfigureJWT(Configuration);

            services.AddCors(o =>
             {
                 o.AddPolicy("AllowAll", builder =>
                 builder.AllowAnyOrigin()
                 .AllowAnyMethod()
                 .AllowAnyHeader());
             });

            services.ConfigureAutoMapper();

            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IAuthManager, AuthManager>();

            services.ConfigureSwaggerDoc();

            services.AddControllers(
                ).AddNewtonsoftJson(op =>
            op.SerializerSettings.ReferenceLoopHandling =
            Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.ConfigureVersioning();

        }

       

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
                {
                    if (env.IsDevelopment())
                    {
                        app.UseDeveloperExceptionPage();
                    }



                    app.UseSwagger();

                    app.UseSwaggerUI(c =>
                    {
                        string swaggerJsonBasePath = string.IsNullOrWhiteSpace(c.RoutePrefix) ? "." : "..";
                        c.SwaggerEndpoint($"{swaggerJsonBasePath}/swagger/v1/swagger.json", "Hotel Listing API");

                    });


                    app.ConfigureExceptionHandler();

                    app.UseHttpsRedirection();

                    app.UseCors("AllowAll");

                    app.UseResponseCaching();
                    app.UseHttpCacheHeaders();
                    app.UseIpRateLimiting();


                    app.UseRouting();

                    app.UseAuthentication();
                    app.UseAuthorization();

                    app.UseEndpoints(endpoints =>
                    {

                        endpoints.MapControllers();
                    });
                }

    }
}


