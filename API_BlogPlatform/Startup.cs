using API_BlogPlatform.Domain.IRepositories;
using API_BlogPlatform.Domain.IServices;
using API_BlogPlatform.Persistence.Context;
using API_BlogPlatform.Persistence.Repositories;
using API_BlogPlatform.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.IO;

namespace API_BlogPlatform
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Adding 
            services.AddDbContext<ApiDbContext>(options => options.UseInMemoryDatabase(Configuration.GetConnectionString("Conexion")));
            services.AddScoped<IBlogPostRepository, BlogPostRepository>();
            services.AddScoped<IBlogPostService, BlogPostService>();
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API_BlogPlatform", Version = "v1" });
                var filePath = Path.Combine(System.AppContext.BaseDirectory, "API_BlogPlatform.xml");
                c.IncludeXmlComments(filePath);


            });
            var filePath = Path.Combine(System.AppContext.BaseDirectory, "MyApi.xml");
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API_BlogPlatform v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
