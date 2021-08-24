using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NewTicketManager.Data;

[assembly: HostingStartup(typeof(NewTicketManager.Areas.Identity.IdentityHostingStartup))]
namespace NewTicketManager.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<NewTicketManagerContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("NewTicketManagerContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<NewTicketManagerContext>();
            });
        }
    }
}