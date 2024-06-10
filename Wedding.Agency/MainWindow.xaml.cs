using System.Windows;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System.IO;
using WeddingAgency.Models;

namespace WeddingAgency
{
    public partial class MainWindow : Window
    {
        private readonly WeddingAgencyContext _context;

        public MainWindow()
        {
            InitializeComponent();

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();
            _context = serviceProvider.GetService<WeddingAgencyContext>();

            LoadClients();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            var config = LoadConfiguration();
            services.AddDbContext<WeddingAgencyContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
        }

        private IConfiguration LoadConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            return builder.Build();
        }

        private void LoadClients()
        {
            _context.Clients.Load();
            ClientsDataGrid.ItemsSource = _context.Clients.Local.ToObservableCollection();
        }

        private void AddClientButton_Click(object sender, RoutedEventArgs e)
        {
            var addClientWindow = new AddClientWindow(_context);
            addClientWindow.ShowDialog();
            LoadClients();
        }
    }
}

