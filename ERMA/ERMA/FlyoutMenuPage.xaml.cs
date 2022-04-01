using ERMA.Helper;
using ERMA.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ERMA
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlyoutMenuPage : ContentPage
    {
        public FlyoutMenuPage()
        {
            InitializeComponent();
            //get the user zone
            lblZone.Text = "Magodo South-East Zone";
        }

        private void Dashboard_Tapped(object sender, EventArgs e)
        {
            MainPage mRootDetailPage = (MainPage)(App.Current.MainPage);
            mRootDetailPage.Detail = PageUtility.CreateDashboardPage();
            mRootDetailPage.IsPresented = false;
        }

        private void Dues_Tapped(object sender, EventArgs e)
        {
            MainPage mRootDetailPage = (MainPage)(App.Current.MainPage);
            mRootDetailPage.Detail = PageUtility.CreateDuesPage();
            mRootDetailPage.IsPresented = false;
        }

        private void Messages_Tapped(object sender, EventArgs e)
        {
            MainPage mRootDetailPage = (MainPage)(App.Current.MainPage);
            mRootDetailPage.IsPresented = false;
        }

        private void Vendors_Tapped(object sender, EventArgs e)
        {
            MainPage mRootDetailPage = (MainPage)(App.Current.MainPage);
            mRootDetailPage.Detail = PageUtility.CreateVendorsPage();
            mRootDetailPage.IsPresented = false;
        }


        private void Complaints_Tapped(object sender, EventArgs e)
        {
            MainPage mRootDetailPage = (MainPage)(App.Current.MainPage);
            mRootDetailPage.IsPresented = false;
        }

        private void BackArrow_Tapped(object sender, EventArgs e)
        {
            MessagingCenter.Send("Open Menu", MessageCenterTypes.M_C_SHOW_SIDE_MENU);
        }

        private void BG_Tapped(object sender, EventArgs e)
        {
            MessagingCenter.Send("Open Menu", MessageCenterTypes.M_C_SHOW_SIDE_MENU);
        }

        private void Content_Tapped(object sender, EventArgs e)
        {

        }
    }
}