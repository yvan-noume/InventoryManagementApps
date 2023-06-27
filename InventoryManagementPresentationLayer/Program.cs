using InventoryManagementApplicationLayer.API;
using InventoryManagementApplicationLayer.Services;
using InventoryManagementDataAccessLayer;
using InventoryManagementPresentationLayer.ViewModels;
using InventoryManagementPresentationLayer.Views;
using Microsoft.Extensions.DependencyInjection;

namespace InventoryManagementPresentationLayer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
           
            var services = new ServiceCollection();
            services.AddTransient<ICustomerServices, CustomerDataOperations>();
            services.AddTransient<IAdminServices, AdminDataOperations>();
            services.AddTransient<ICategoryServices, CategoryDataOperations>();
            services.AddTransient<IOrderServices, OrderDataOperations>();
            services.AddTransient<IProductServices, ProductDataOperations>();
            services.AddTransient<CustomerServices>();
            services.AddTransient<AdminServices>();
            services.AddTransient<CategoryServices>();
            services.AddTransient<OrderServices>();
            services.AddTransient<ProductServices>();

            using (var serviceProvider = services.BuildServiceProvider())
            {
                var customerService = serviceProvider.GetRequiredService<ICustomerServices>();
                Application.Run(new HomeForm(customerService));
            }
        }
    }
}