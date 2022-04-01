using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ERMA.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class LoginViewModel : BaseViewModel
    {

        public string WelcomeText { get; set; }
        public Command GotoDashboard { get; }

        public LoginViewModel()
        {
            GotoDashboard = new Command(OnGotoDashboard);
        }


        public async override Task Initialize(object initData)
        {
            this.WelcomeText = "Welcome to South East Zone, Magodo GRA";
            await Task.Delay(100);
        }

        async void OnGotoDashboard()
        {
            await this.CoreMethods.PushPageModel<DashboardViewModel>();
        }
    }
}
