using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAppWpf.Views;

namespace TodoAppWpf.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject
    {
        private static bool _isCreateTodoWindowOpen = false;
        private static bool _isViewTodoWindowOpen = false;

        [RelayCommand]
        private void ShowCreateTodoPage()
        {
            if (!_isCreateTodoWindowOpen)
            {
                _isCreateTodoWindowOpen = true;
                var window = new CreateTodoWindow();
                window.Closed += (obj, args) => _isCreateTodoWindowOpen = false;
                window.Show();
            }
        }

        [RelayCommand]
        private void ShowViewTodoPage()
        {
            if (!_isViewTodoWindowOpen)
            {
                _isViewTodoWindowOpen = true;
                var window = new ViewTodosWindow();
                window.Closed += (obj, args) => _isViewTodoWindowOpen = false;
                window.Show();
            }
        }
    }
}
