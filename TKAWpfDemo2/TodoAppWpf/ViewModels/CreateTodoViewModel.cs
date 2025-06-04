using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TodoAppWpf.DataAccess;
using TodoAppWpf.Models;

namespace TodoAppWpf.ViewModels
{
    public partial class CreateTodoViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title;
        [ObservableProperty]
        private DateTime dueDate = DateTime.Now;
        private readonly TodoRepository _repo;

        public CreateTodoViewModel()
        {
                _repo = new TodoRepository();
        }

        [RelayCommand]
        private void Add()
        {
            if (!string.IsNullOrWhiteSpace(Title))
            {
                var newItem = new TodoItem
                {
                    Title = Title,
                    DueDate = dueDate,
                    IsCompleted = false
                };
                _repo.Add(newItem);
                var result = MessageBox.Show($"{Title} added");
                if (result == MessageBoxResult.OK)
                {
                    Title = string.Empty;
                }
                Title = string.Empty;
            }
        }
    }
}
