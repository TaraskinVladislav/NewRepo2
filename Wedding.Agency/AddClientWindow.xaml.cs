using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using Wedding.Agency;
using WeddingAgency.Models;

namespace WeddingAgency
{
    public partial class AddClientWindow : Window
    {
        private readonly WeddingAgencyContext _context;

        public AddClientWindow(WeddingAgencyContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void RegisterClientButton_Click(object sender, RoutedEventArgs e)
        {
            var client = new Client
            {
                Name = ClientNameTextBox.Text,
                ContactDetails = ClientContactDetailsTextBox.Text
            };

            _context.Clients.Add(client);
            _context.SaveChanges();

            MessageBox.Show("Client registered successfully.");
            Close();
        }
    }
}

