using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using DameraAPI.DameraSOA.UserNS.Model;
using DameraAPI.DameraSOA.TokenNS.Model;
using DameraAPI.DameraSOA.UserNS.Service;
using DameraAPI.DameraSOA.TokenNS.Service;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace DameraAPI
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
            services.AddCors();
            services.AddHttpContextAccessor();
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IUserQueryHandler, UserQueryHandler>();
            services.AddScoped<IUserCommandHandler, UserCommandHandler>();
            services.AddScoped<ITokenQueryHandler, TokenQueryHandler>();
            services.AddScoped<ITokenCommandHandler, TokenCommandHandler>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ITokenRepository, TokenRepository>();
            services.AddDbContext<UserContext>(opt =>
                                               opt.UseSqlServer("Data Source=(local);Initial Catalog=Damera_DB;Integrated Security=True"));
            services.AddDbContext<TokenContext>(opt =>
                                               opt.UseSqlServer("Data Source=(local);Initial Catalog=Damera_DB;Integrated Security=True"));
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Damera API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors(builder => builder
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowAnyOrigin());

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Damera API v1"));
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
