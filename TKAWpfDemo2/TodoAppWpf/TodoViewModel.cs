using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TodoAppWpf
{
    public  partial class TodoViewModel: ObservableObject
    {
        public ObservableCollection<string> Todos { get; } = new ObservableCollection<string>();

        [ObservableProperty]
        private string title;

        [RelayCommand]
        private void AddTodo()
        {
            Todos.Add(Title);
            MessageBox.Show($"Todo '{Title}' added successfully!");
        }
    }
}
