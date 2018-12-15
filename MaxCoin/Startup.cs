using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maxtrain.MaxCoin.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Maxtrain.MaxCoin {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {

            var connStr = @"server=localhost\sqlexpress;database=MaxCoinDb;trusted_connection=true;";
            services.AddDbContext<MaxCoinDbContext>(opt => opt.UseSqlServer(connStr));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddCors(option => {
                option.AddPolicy("AllowAllAccess",
                    builder => builder.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin()
                );
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env) {
            if(env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
