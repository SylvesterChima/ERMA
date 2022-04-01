using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERMA.Models
{
    [AddINotifyPropertyChangedInterface]
    public class News
    {
        public int NewsId { get; set; }
        public string Subject { get; set; }
        public string Status { get; set; }
    }
}
