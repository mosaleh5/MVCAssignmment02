namespace MVCDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseRouting();
            app.UseStaticFiles();
            /*            app.UseEndpoints(endpoints =>
                        {
                            endpoints.MapGet("/", async context =>
                            {
                                await context.Response.WriteAsync("hello world");
                            }); 
                            endpoints.MapGet("/Home", async context =>
                            {
                                await context.Response.WriteAsync("it is your home");
                            });

                            endpoints.MapGet("/Products", async context =>
                            {
                                await context.Response.WriteAsync("It Is your Products");
                            });

                            endpoints.MapGet("/Products/{id:int?}", async context =>
                            {
                                var idData = context.Request.RouteValues["id"];
                                if (idData != null) {
                                    int id = Convert.ToInt32(context.Request.RouteValues["id"]);
                                    await context.Response.WriteAsync($"It Is your Products with {id}");
                                }

                            });

                            endpoints.MapGet("/Books/{id?}/{author}", async context =>
                            {
                                int id = Convert.ToInt32( context.Request.RouteValues["id"]);
                                string author = Convert.ToString( context.Request.RouteValues["author"]);
                                await context.Response.WriteAsync($"It Is your Products with {id} and {author}");
                            });
                        });
                        app.Run(async (HttpContext) =>
                        {
                            await HttpContext.Response.WriteAsync("Your Requested Page Not Found");
                        });*/

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            app.Run();
        }
    }
}
