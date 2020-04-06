using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ZineClient.Models;
using Microsoft.EntityFrameworkCore;

namespace ZineClient
{
  public class Startup
  {

    public Startup(IHostingEnvironment env)
    {
      var builder = new ConfigurationBuilder()
          .SetBasePath(env.ContentRootPath)
          .AddJsonFile("appsettings.json");
      Configuration = builder.Build();
    }

    public IConfigurationRoot Configuration { get; set; }

    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc();

      services.AddEntityFrameworkMySql()
        .AddDbContext<ZineClientContext>(options => options
        .UseMySql(Configuration["ConnectionStrings:DefaultConnection"]));

      //   services.AddIdentity<ApplicationUser, IdentityRole>()
      //     .AddEntityFrameworkStores<ZineClientContext>()
      //     .AddDefaultTokenProviders();

      //   services.Configure<IdentityOptions>(options =>
      //   {
      //     options.Password.RequireDigit = false;
      //     options.Password.RequiredLength = 0;
      //     options.Password.RequireLowercase = false;
      //     options.Password.RequireNonAlphanumeric = false;
      //     options.Password.RequireUppercase = false;
      //     options.Password.RequiredUniqueChars = 0;
      //   });
    }

    public void Configure(IApplicationBuilder app)
    {
      app.UseStaticFiles();

      app.UseDeveloperExceptionPage();

      //   app.UseAuthentication();

      app.UseMvc(routes =>
      {
        routes.MapRoute(
          name: "default",
          template: "{controller=Home}/{action=Index}/{id?}");
      });

      app.Run(async (context) =>
      {
        await context.Response.WriteAsync("Something went wrong!");
      });
    }
  }
}
