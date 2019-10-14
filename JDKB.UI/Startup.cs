using JDKB.DI;
using JDKB.UI.Logging;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace JDKB.UI
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // Context Dependence Injection
            services.AddDI();

            // Authentication
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme =
                options.DefaultSignInScheme =
                options.DefaultChallengeScheme =
                    CookieAuthenticationDefaults.AuthenticationScheme;

            }).AddCookie(options => options.LoginPath = "/auth/signin");
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            // Logging
            //var path = Configuration.GetValue<string>("LogPath:Path");

            //loggerFactory.AddProvider(new CustomLoggerProvider(new CustomLoggerProviderConfiguration
            //{
            //    LogLevel = LogLevel.Error

            //}, path));

            // Log4Net
            //var loggingOptions = this.Configuration.GetSection("Log4NetCore").Get<Log4NetProviderOptions>();
            //loggerFactory.AddLog4Net(loggingOptions);

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=BaseConhecimento}/{action=Index}/{id?}");
            });
        }
    }
}
