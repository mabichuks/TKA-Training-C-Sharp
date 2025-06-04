using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TKAWpfDemo2
{
    public partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private string userNameText;

        [RelayCommand]
        private void Greet()
        {
            MessageBox.Show($"Hello, {UserNameText}");
        }
    }

    //public class RelayCommand : ICommand
    //{
    //    private readonly Action _execute;
    //    public event EventHandler? CanExecuteChanged;

    //    public RelayCommand(Action execute)
    //    {
    //        _execute = execute;
    //    }
    //    public bool CanExecute(object? parameter)
    //    {
    //        return true;
    //    }

    //    public void Execute(object? parameter)
    //    {
    //        _execute();
    //    }
    //}
}
