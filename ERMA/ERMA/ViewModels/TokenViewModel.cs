using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ERMA.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class TokenViewModel: BaseViewModel
    {
        public TokenViewModel()
        {
            Title = "Token";
            IsTitleButtonVisible = false;
        }

        public async override Task Initialize(object initData)
        {

        }

    }
}
