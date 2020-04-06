using app_models;
using BillingManagement.UI.ViewModels.Commands;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;

namespace BillingManagement.UI.ViewModels
{
    public class CustomersViewModel : BaseViewModel
    {
        public NewCustomerCommand NewCustomer { get; private set; }

        CustomersDataService customersDataService = new CustomersDataService();

        private ObservableCollection<Customer> customers;
        private Customer selectedCustomer;

        public ObservableCollection<Customer> Customers
        {
            get => customers;
            private set
            {
                customers = value;
                OnPropertyChanged();
            }
        }

        public Customer SelectedCustomer
        {
            get => selectedCustomer;
            set
            {
                selectedCustomer = value;
                OnPropertyChanged();
            }
        }

        public CustomersViewModel()
        {

            NewCustomer = new NewCustomerCommand(New_Customer);

            InitValues();

        }

        private void InitValues()
        {
            Customers = new ObservableCollection<Customer>(customersDataService.GetAll());
            Debug.WriteLine(Customers.Count);
        }

        public void New_Customer()
        {
            Customer temp = new Customer() { Name = "Undefined", LastName = "Undefined" };
            Customers.Add(temp);
            SelectedCustomer = temp;
        }

    }
}
