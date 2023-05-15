using Microsoft.Extensions.FileProviders;

namespace Shopping.Web.Middlewares
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseNodeModules(this IApplicationBuilder app, string root)
        {
            var path = Path.Combine(root, "wwwroot");
            var provider = new PhysicalFileProvider(path);

            var  options =new StaticFileOptions();
            options.RequestPath = "/wwwroot";
            options.FileProvider = provider;

            app.UseStaticFiles(options);

            return app;
        }
    }
}
