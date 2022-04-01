﻿using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERMA.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Structure
    {
        public int Number { get; set; }
        public string Name { get; set; }
    }
}
