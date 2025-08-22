namespace BasicShopAPI
{
    public static class WebApplicationExtensions
    {
        public static WebApplication UseCorsPolicies(this WebApplication app)
        {            
            app.UseRouting();

            if (app.Environment.IsDevelopment())
                app.UseCors("DevAll");
            else
                app.UseCors("WithCreds");

            return app;
        }
    }
}
