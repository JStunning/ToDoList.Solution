using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ToDoList.Models
{
    public class Item
    {
        public string Name {get; set;}
        public int ItemId {get; set;}
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}