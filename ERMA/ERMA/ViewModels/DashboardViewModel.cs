using ERMA.Models;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ERMA.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class DashboardViewModel: BaseViewModel
    {
        public string Username { get; set; }
        public int VisitorsCount { get; set; }
        public int MessageCount { get; set; }
        public string OutstandingAmount { get; set; }
        public List<News> EstateNewsFlash { get; set; }
        public Command GotoProfile { get; set; }
        public Command VisitorsCommand { get; set; }
        public Command OutstandingCommand { get; set; }

        public DashboardViewModel()
        {
            TitleButtonCommand = new Command(ExecuteTitleButtonCommand);
            GotoProfile = new Command( async () =>
            {
                await this.CoreMethods.PushPageModel<ProfileViewModel>();
            });
            VisitorsCommand = new Command(async () =>
            {
                await this.CoreMethods.PushPageModel<VendorsViewModel>();
            });
            OutstandingCommand = new Command(async () =>
            {
                await this.CoreMethods.PushPageModel<DuesMakePaymentViewModel>();
            });
            Title = "Dashboard";
            TitleButonText = "Generate Token";
            IsTitleButtonVisible = true;
        }
        public async override Task Initialize(object initData)
        {
            Username = "Hello Ifeoluwa";
            VisitorsCount = 301;
            MessageCount = 24;
            OutstandingAmount = "350,000 NGN";
            this.EstateNewsFlash = new List<News>
            {
                new News
                {
                    NewsId = 1,
                    Subject = "Why excess deaths during the pandemic",
                    Status = "Read"
                },
                new News
                {
                    NewsId = 2,
                    Subject = "What is this new variant",
                    Status = "Unread"
                },
                new News
                {
                    NewsId = 3,
                    Subject = "How is the UK preparing for Omicron?",
                    Status = "Unread"
                }
            };
            await Task.Delay(100);
        }

        private async void ExecuteTitleButtonCommand()
        {
            await this.CoreMethods.PushPageModel<TokenViewModel>();
        }
    }
}
