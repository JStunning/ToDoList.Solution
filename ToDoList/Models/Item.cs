using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ToDoList.Models
{
    public class Item
    {
        public Item()
        {
            this.Categories = new HashSet<CategoryItem>();
        }
        public int ItemId {get; set;}
        public int Description { get; set; }
        public  ICollection<CategoryItem> Categories { get; }
    }
}