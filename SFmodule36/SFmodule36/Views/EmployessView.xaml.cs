using SFmodule36.Models;
using SFmodule36.ViewModel;
using SFmodule36.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SFmodule36.Views
{
    /// <summary>
    /// Логика взаимодействия для EmployessView.xaml
    /// </summary>
    public partial class EmployessView : Window
    {

        IEmployeeViewModel _employeeViewModel;
        IEmployeesViewModel _employeesViewModel;
        public EmployessView(IEmployeesViewModel employeesViewModel, IEmployeeViewModel employeeViewModel)
        {

            _employeeViewModel = employeeViewModel;
            _employeesViewModel = employeesViewModel;

            InitializeComponent();
            DataContext = _employeesViewModel;
        }

        private void ListView_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = (sender as ListView).SelectedItem;

            if (item is null)
            {
                return;
            }


            var employee = item as Employee;

            _employeeViewModel.Employee = employee;

            var employeeView = new EmployeeView(
                _employeeViewModel);

            employeeView.Show();
        }

        private string Message(Employee employee)
        {

            return "Имя: " + employee.FirstName + "\n" +
                "Фамилия: " + employee.LastName + "\n" +
                "Возраст: " + employee.Age + "\n" +
                "Должность: " + employee.Position + "\n" +
                "Компания: " + employee.CompanyName + "\n" +
                "Город: " + employee.CityName;
        }
    }
}
