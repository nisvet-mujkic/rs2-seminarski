using AutoMapper;
using BookDiary.API.Filters;
using BookDiary.API.IService;
using BookDiary.API.Service;
using BookDiary.Infrastructure.Data;
using BookDiary.Model;
using BookDiary.Model.Requests.Books;
using BookDiary.Model.Requests.Quotes;
using BookDiary.Model.Requests.Users;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace BookDiary.API
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
            services.AddMvc(x => x.Filters.Add<ErrorFilter>()).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddAutoMapper();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "BookDiary API", Version = "v1" });
            });

            services.AddScoped<IService<Model.Models.Genre, object>, Service<Model.Models.Genre, object, Infrastructure.Entities.Genre>>();
            services.AddScoped<ICrudService<Model.Models.Quote, QuotesSearchRequest, QuotesUpsertRequest, QuotesUpsertRequest>, QuotesService>();
            services.AddScoped<ICrudService<Model.Models.Book, BooksSearchRequest, BooksUpsertRequest, BooksUpsertRequest>, BooksService>();
            services.AddScoped<ICrudService<Model.Models.User, UsersSearchRequest, UsersUpsertRequest, UsersUpsertRequest>, UsersService>();

            string connectionString = Configuration.GetConnectionString(Global.ConnectionStrings.BookDiaryLocal);
            services.AddDbContext<BookDiaryContext>(options => options.UseSqlServer(connectionString));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "BookDiary API V1");
            });

            app.UseMvc();
        }
    }
}
