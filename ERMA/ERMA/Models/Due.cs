using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERMA.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Due
    {
        public int DueId { get; set; }
        public string Name { get; set; }
    }
}
