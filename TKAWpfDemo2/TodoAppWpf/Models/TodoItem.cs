﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoAppWpf.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }

        public TodoItem()
        {
                
        }
        public TodoItem(int id, string title, string description, DateTime dueDate, bool isCompleted)
        {
            Id = id;
            Title = title;
            DueDate = dueDate;
            IsCompleted = isCompleted;
        }
    }
}
