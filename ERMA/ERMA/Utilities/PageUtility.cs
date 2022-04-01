using ERMA.Helper;
using ERMA.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ERMA.Utilities
{
    public class PageUtility
    {
        public static Page CreateRootPage()
        {
            return new MainPage();
        }

        public static Page CreateLoginPage()
        {
            Page page = FreshMvvm.FreshPageModelResolver.ResolvePageModel<LoginViewModel>();
            NavigationPage nav = new FreshMvvm.FreshNavigationContainer(page) as NavigationPage;

            nav.BarBackgroundColor = Color.FromHex(PageConstants.PrimaryColor);
            nav.BarTextColor = Color.FromHex(PageConstants.White);

            return nav;
        }

        public static Page CreateDashboardPage()
        {
            Page page = FreshMvvm.FreshPageModelResolver.ResolvePageModel<DashboardViewModel>();
            NavigationPage nav = new FreshMvvm.FreshNavigationContainer(page) as NavigationPage;

            nav.BarBackgroundColor = Color.FromHex(PageConstants.PrimaryColor);
            nav.BarTextColor = Color.FromHex(PageConstants.White);

            return nav;
        }

        public static Page CreateVendorsPage()
        {
            Page page = FreshMvvm.FreshPageModelResolver.ResolvePageModel<VendorsViewModel>();
            NavigationPage nav = new FreshMvvm.FreshNavigationContainer(page) as NavigationPage;

            nav.BarBackgroundColor = Color.FromHex(PageConstants.PrimaryColor);
            nav.BarTextColor = Color.FromHex(PageConstants.White);

            return nav;
        }

        public static Page CreateDuesPage()
        {
            Page page = FreshMvvm.FreshPageModelResolver.ResolvePageModel<DuesMakePaymentViewModel>();
            NavigationPage nav = new FreshMvvm.FreshNavigationContainer(page) as NavigationPage;

            nav.BarBackgroundColor = Color.FromHex(PageConstants.PrimaryColor);
            nav.BarTextColor = Color.FromHex(PageConstants.White);

            return nav;
        }

    }
}
