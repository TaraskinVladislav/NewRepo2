using System.Windows;
using WeddingAgency.Models;

namespace WeddingAgency
{
    public partial class AddEmployeeWindow : Window
    {
        private readonly WeddingAgencyContext _context;

        public AddEmployeeWindow(WeddingAgencyContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void RegisterEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            var employee = new Employee
            {
                Name = EmployeeNameTextBox.Text,
                Position = EmployeePositionTextBox.Text
            };

            _context.Employees.Add(employee);
            _context.SaveChanges();

            MessageBox.Show("Employee registered successfully.");
            Close();
        }
    }
}
