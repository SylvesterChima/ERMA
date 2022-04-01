using ERMA.Utilities;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ERMA
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = PageUtility.CreateRootPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
