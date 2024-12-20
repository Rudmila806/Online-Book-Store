﻿namespace DOT_NET_inventory_project.Models
{
    public class BookItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Category { get; set; }
        public string Name { get; internal set; }
        public string ImageUrl { get; internal set; }
        public double Ratings { get; internal set; }
    }
}
