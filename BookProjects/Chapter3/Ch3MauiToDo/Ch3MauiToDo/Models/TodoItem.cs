using System;

namespace Ch3MauiToDo.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Due { get; set; }
        public bool Done { get; set; }
    }
}
