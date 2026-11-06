using System;
using System.Collections.Generic;
using System.Text;

namespace ArakanLink.ViewModels
{
    public class MainPageVM : BaseViewModel
    {
        private int _count = 0;

        public MainPageVM()
        {
            Title = "Main Page";
        }        
       
        public string CounterButtonText => _count == 1 ? $"Clicked {_count} time" : $"Clicked {_count} times";

        public Command IncrementCommand => new Command(IncrementCount);

        public void IncrementCount()
        {
            _count++;
            OnPropertyChanged(nameof(CounterButtonText));
        }
    }
}
