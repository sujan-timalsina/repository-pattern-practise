using TodoApp.Repository;
using TodoApp.Services;

namespace TodoApp.Api
{
    public class Startups
    {
        public IConfiguration Configuration { get; }
        public Startups(IConfiguration configuration, IWebHostEnvironment environment)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            RepositoryModule.Register(services,
                Configuration.GetConnectionString("DefaultConnection"));
            ServiceModule.Register(services);
            services.AddControllers();
            services.AddSwaggerGen();
            // services.AddMvc(option => option.EnableEndpointRouting = false).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddCors(allowsites =>
            {
                allowsites.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin());
            });
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapDefaultControllerRoute();
            });

            // app.UseStaticFiles();
            // app.UseMvc();
            app.UseCors(options => options.AllowAnyOrigin());
        }
    }
}