using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERMA.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Vendor
    {
        public int VendorId { get; set; }
        public string VendorType { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
