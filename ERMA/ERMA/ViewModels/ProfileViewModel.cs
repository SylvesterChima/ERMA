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
    public class ProfileViewModel: BaseViewModel
    {
        public User User { get; set; }

        public ProfileViewModel()
        {
            Title = "Profile";
            IsTitleButtonVisible = false;
        }

        public async override Task Initialize(object initData)
        {
            this.User = new User
            {
                UserID = 1,
                Fullname = "Oluwafemi John",
                ApartmentInfo = "Four bed room",
                ApartmentType = "Duplex",
                DateOfBirth = DateTime.Now.AddYears(-25).Date,
                Gender = "Male",
                HouseAddress = "20 Alagomeji, Yaba",
                MaritalStatus = "Single",
                Phone = "08036496516",
                ResidenceID = "B-007",
                Zone = "33021"
            };
            await Task.Delay(100);
        }

    }
}
