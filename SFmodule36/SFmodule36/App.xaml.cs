using SFmodule36.Models;
using SFmodule36.ViewModel;
using SFmodule36.Views;
using System.Windows;
using Unity;

namespace SFmodule36
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            IUnityContainer unityContainer = new UnityContainer();


            unityContainer.RegisterType<IEmployeesViewModel, EmployeesViewModel>();
            unityContainer.RegisterType<IEmployeeRepository, EmployeeRepository>();

            unityContainer.Resolve<EmployessView>().Show();
        }
    }
}
