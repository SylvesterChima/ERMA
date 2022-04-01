using ERMA.Helper;
using FreshMvvm;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ERMA.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class BaseViewModel : FreshBasePageModel
    {
        public string Title { get; set; }
        public bool IsBusy { get; set; }
        public string TitleButonText { get; set; }
        public bool IsTitleButtonVisible { get; set; }
        public Command ShowFlyout { get; }
        public Command TitleButtonCommand { get; set; }

        public BaseViewModel()
        {
            ShowFlyout = new Command(OnShowFlyout);
        }

        protected virtual void Setup()
        {

        }

        public async override void Init(object initData)
        {
            //overriden to allow task based Initialize method
            base.Init(initData);
            await Initialize(initData);
        }

        public async override void ReverseInit(object returnedData)
        {
            //overriden to allow task based ReverseInitialize method
            base.ReverseInit(returnedData);
            await ReverseInitialize(returnedData);
        }

        public virtual Task Initialize(object initData)
        {
            return Task.CompletedTask;
        }

        public virtual Task ReverseInitialize(object returnedData)
        {
            return Task.CompletedTask;
        }

        void OnShowFlyout()
        {
            MessagingCenter.Send("Open Menu", MessageCenterTypes.M_C_SHOW_SIDE_MENU);
        }
    }
}
