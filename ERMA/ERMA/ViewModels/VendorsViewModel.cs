using ERMA.Models;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ERMA.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class VendorsViewModel: BaseViewModel
    {
        public List<Vendor> Vendors { get; set; }

        public VendorsViewModel()
        {
            Title = "Vendors";
            IsTitleButtonVisible = false;
        }

        public async override Task Initialize(object initData)
        {
            this.Vendors = new List<Vendor>
            {
                new Vendor
                {
                    VendorId = 1,
                    VendorType ="Electrician",
                    Name = "Vensolad Ventures",
                    Contact = "Jimoh Oluwaseun",
                    Phone = "08056733822",
                    Email = "jimoholuw2@gmail.com"
                },
                new Vendor
                {
                    VendorId = 1,
                    VendorType ="Plumber",
                    Name = "Adex Limited",
                    Contact = "Oyewale Tommy",
                    Phone = "09193445664",
                    Email = "oyewaletoo@gmail.com"
                },
                new Vendor
                {
                    VendorId = 1,
                    VendorType ="Furniture",
                    Name = "Woodcrafter",
                    Contact = "Steven wood",
                    Phone = "08034338233",
                    Email = "woodsteve@gmail.com"
                },
                new Vendor
                {
                    VendorId = 1,
                    VendorType ="Carpenter",
                    Name = "Capwood",
                    Contact = "John Friday",
                    Phone = "09079623456",
                    Email = "JohnFriday@gmail.com"
                },
                new Vendor
                {
                    VendorId = 1,
                    VendorType ="Software Consultant",
                    Name = "Softcodes",
                    Contact = "Festus Okesade",
                    Phone = "09034794292",
                    Email = "sotyy@gmail.com"
                }
            };
            await Task.Delay(100);
        }
    }
}
