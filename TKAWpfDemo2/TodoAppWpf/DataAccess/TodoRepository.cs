using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAppWpf.Models;

namespace TodoAppWpf.DataAccess
{
    public class TodoRepository
    {
        private readonly TodoContext _db;
        public TodoRepository()
        {
            _db = new TodoContext();
            _db.Database.EnsureCreated();
        }

        public List<TodoItem> GetAll()
        {
            var query = from item in _db.TodoItems
                        orderby item.DueDate
                        select item;
            return  query.ToList();
        }

        public List<TodoItem> FilterByStatus(bool isCompleted = false)
        {
            var query = from item in _db.TodoItems
                        where item.IsCompleted == isCompleted
                        orderby item.DueDate
                        select item;
            return query.ToList();
        }

        public void Add(TodoItem item)
        {
            _db.TodoItems.Add(item);
            _db.SaveChangesAsync();
        }

        public void Update(TodoItem item)
        {
            _db.TodoItems.Update(item);
            _db.SaveChanges();
        }
    }
}
