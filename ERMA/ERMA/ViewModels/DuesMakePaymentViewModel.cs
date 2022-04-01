using ERMA.Models;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ERMA.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class DuesMakePaymentViewModel : BaseViewModel
    {
        public List<Structure> Structures { get; set; }
        public List<Due> Dues { get; set; }

        public DuesMakePaymentViewModel()
        {
            Title = "Dues";
            IsTitleButtonVisible = false;
        }

        public async override Task Initialize(object initData)
        {
            this.Structures = new List<Structure>
            {
                new Structure
                {
                    Number = 2223414,
                    Name = "Building A"
                },
                new Structure
                {
                    Number = 3325463,
                    Name = "Building B"
                },
                new Structure
                {
                    Number = 4437465,
                    Name = "Building C"
                },
                new Structure
                {
                    Number = 1173634,
                    Name = "Building D"
                },
                new Structure
                {
                    Number = 8845322,
                    Name = "Building E"
                }
            };

            this.Dues = new List<Due>
            {
                new Due
                {
                    DueId = 2223414,
                    Name = "Due A"
                },
                new Due
                {
                    DueId = 3325463,
                    Name = "Due B"
                },
                new Due
                {
                    DueId = 4437465,
                    Name = "Due C"
                },
                new Due
                {
                    DueId = 1173634,
                    Name = "Due D"
                },
                new Due
                {
                    DueId = 8845322,
                    Name = "Due E"
                }
            };
            await Task.Delay(100);
        }
    }
}
