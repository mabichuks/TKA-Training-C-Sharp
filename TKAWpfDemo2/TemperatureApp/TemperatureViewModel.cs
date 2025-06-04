using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureApp
{
    public partial class TemperatureViewModel : ObservableObject
    {
        [ObservableProperty]
        private string celsius;
        [ObservableProperty]
        private string fahrenheit;

        [RelayCommand]
        private void Convert()
        {

           if (double.TryParse(Celsius, out double celsiusValue))
            {
                Fahrenheit = ((celsiusValue * 9 / 5) + 32).ToString("F2");
            }
            else
            {
                Fahrenheit = "Invalid input";
            }
        }
    }
}
