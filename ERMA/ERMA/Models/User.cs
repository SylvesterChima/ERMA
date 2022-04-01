using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERMA.Models
{
    [AddINotifyPropertyChangedInterface]
    public class User
    {
        public int UserID { get; set; }
        public string Fullname { get; set; }
        public string ResidenceID { get; set; }
        public string Phone { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public string ApartmentType { get; set; }
        public string ApartmentInfo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string HouseAddress { get; set; }
        public string Zone { get; set; }
    }
}
