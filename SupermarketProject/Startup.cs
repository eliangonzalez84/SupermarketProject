using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Plugins.DataStore.InMemory;
using Plugins.DataStore.SQL;
using SupermarketProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UseCases;
using UseCases.DataStorePluginInterfaces;
using UseCases.PluginInterfaces;
using UseCases.ProductsUseCases;

namespace SupermarketProject
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();

            services.AddAuthorization(options =>
            {
                options.AddPolicy("AdminOnly", p => p.RequireClaim("Position", "Admin"));
                options.AddPolicy("CashierOnly", p => p.RequireClaim("Position", "Cashier"));
            });

            //Voy a usar los repos con EF, no los de In Memory
            services.AddScoped<ICategoryRepository, Plugins.DataStore.InMemory.CategoryRepository>();
            services.AddScoped<IProductRepository, Plugins.DataStore.InMemory.ProductRepository>();
            services.AddScoped<ITransactionRepository, Plugins.DataStore.InMemory.TransactionRepository>();

            services.AddTransient<IViewCategoriesUseCase, ViewCategoriesUseCase>();
            services.AddTransient<IAddCategoryUseCase, AddCategoryUseCase>();
            services.AddTransient<IEditCategoryUseCase, EditCategoryUseCase>();
            services.AddTransient<IGetCategoryByIdUseCase, GetCategoryByIdUseCase>();
            services.AddTransient<IDeleteCategoryUseCase, DeleteCategoryUseCase>();
            services.AddTransient<IViewProductsUseCase, ViewProductUseCase>();
            services.AddTransient<IAddProductUseCase, AddProductUseCase>();
            services.AddTransient<IEditProductUseCase, EditProductUseCase>();
            services.AddTransient<IGetProductByIdUseCase, GetProductByIdUseCase>();
            services.AddTransient<IDeleteProductUseCase, DeleteProductUseCase>();
            services.AddTransient<IViewProductByCategoryId, ViewProductByCategoryId>();
            services.AddTransient<ISellProductUseCase, SellProductUseCase>();
            services.AddScoped<IRecordTransactionUseCase, RecordTransactionUseCase>();
            services.AddScoped<IGetTodayTransactionsUseCase, GetTodayTransactionsUseCase>();
            services.AddScoped<IGetTransactionsUseCase, GetTransactionsUseCase>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
