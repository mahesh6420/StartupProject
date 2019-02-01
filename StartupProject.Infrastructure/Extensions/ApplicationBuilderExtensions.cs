using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartupProject.Infrastructure.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static void UseMvcWithCustomizedRoute(this IApplicationBuilder app)
        {
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "AdminRoute",
                    template: "{user}/{controller=Dashboard}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                   name: "LoginRoute",
                   template: "{area=user}/{controller=Account}/{action=Login}");

            });
        }
    }
}
