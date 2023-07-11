namespace ConsoleToWebApi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddTransient<CustomMiddleware1>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) 
        {
            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Hello from Run");
            //});
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from Use-1 1 \n");
            //    await next();
            //    await context.Response.WriteAsync("Hello from Use-1 2 \n");
            //});

            //app.UseMiddleware<CustomMiddleware1>();

            //app.Map("/nitish", CustomCode);

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from Use-2 1 \n");
            //    await next();
            //    await context.Response.WriteAsync("Hello from Use-2 2 \n");
            //});
            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Request complete \n");

            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Request complete \n");

            //});

            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Hello from Run \n");
            //});

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello from new Web Api app");
            //    });
            //    endpoints.MapGet("/test", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello from new Web Api app test");
            //    });
            //});

        }

        private void CustomCode(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello from nitish \n");
             
            });
        }
    }
}