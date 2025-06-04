using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAppWpf.DataAccess;
using TodoAppWpf.Models;

namespace TodoAppWpf.ViewModels
{
    public partial class ViewTodosViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title;

        [ObservableProperty]
        private DateTime dueDate = DateTime.Now;

        [ObservableProperty]
        private string filterText;

        public ObservableCollection<TodoItem> Items { get; } = new();
        private readonly TodoRepository _repo;


        public ViewTodosViewModel()
        {
            _repo = new TodoRepository();
            FilterText = string.Empty;
            LoadTodos();
        }

        private void LoadTodos()
        {
            Items.Clear();
            var todos = _repo.GetAll();
            foreach (var item in todos)
            {
                Items.Add(item);
            }
        }

        [RelayCommand]
        private void ToggleComplete(TodoItem item)
        {
            _repo.Update(item);
            LoadTodos();
        }
    }
}
