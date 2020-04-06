using BillingManagement.UI.ViewModels;
using System.Windows;

namespace Inventaire
{
    public partial class MainWindow : Window
    {

        CustomersViewModel vm = new CustomersViewModel();

        public MainWindow()
        {

            InitializeComponent();

            DataContext = vm;

        }


         private void CustomerNew_Click(object sender, RoutedEventArgs e)
         {

            vm.New_Customer();

         }

         private void CustomerDelete_Click(object sender, RoutedEventArgs e)
         {
             int currentIndex = vm.Customers.IndexOf(vm.SelectedCustomer);

             if (currentIndex > 0)
                 currentIndex--;

             vm.Customers.Remove(vm.SelectedCustomer);

             lvCustomers.SelectedIndex = currentIndex;

         }
    }
}
