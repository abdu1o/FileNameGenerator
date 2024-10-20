namespace FileNameGenerator
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddSingleton<FileNameGeneratorService>();
        }
    }
}
