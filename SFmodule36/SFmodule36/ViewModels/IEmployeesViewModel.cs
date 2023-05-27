using SFmodule36.Models;
using System.Collections.ObjectModel;

namespace SFmodule36.ViewModel
{
    public interface IEmployeesViewModel
    {
        ObservableCollection<Employee> Employees { get; set; }
        string Filter { get; set; }
        string FilterMessage { get; set; }
    }
}
