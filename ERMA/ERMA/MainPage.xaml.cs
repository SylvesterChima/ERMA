using ERMA.Helper;
using ERMA.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ERMA
{
    public partial class MainPage : FlyoutPage
    {
        public MainPage()
        {
            InitializeComponent();
            SetupInterface();
        }

        public void SetupInterface()
        {
            Flyout = new FlyoutMenuPage();
            Detail = PageUtility.CreateLoginPage();
        }

        protected override void OnAppearing()
        {
            MessagingCenter.Subscribe<string>(this, MessageCenterTypes.M_C_SHOW_SIDE_MENU, (arg) =>
            {
                try
                {
                    IsPresented = !IsPresented;

                }
                catch (Exception ex)
                {
                    
                }

            });
        }

        protected override void OnDisappearing()
        {

            MessagingCenter.Unsubscribe<string>(this, MessageCenterTypes.M_C_SHOW_SIDE_MENU);
        }

    }
}
