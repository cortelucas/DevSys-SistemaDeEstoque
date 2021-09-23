using System;

namespace SistemaDeEstoqueCodeFirst.Models
{
    public class Product
    {
        public Product() => 
            DateCreated = DateTime.Now;
        public Product(int iD, string name, string description, int quantity, string image, decimal price, DateTime lastUpdate, int status, int userID, int categoryID) : this()
        {
            ID = iD;
            Name = name;
            Description = description;
            Quantity = quantity;
            Image = image;
            Price = price;
            LastUpdate = lastUpdate;
            Status = status;
            UserID = userID;
            CategoryID = categoryID;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastUpdate { get; set; }
        public int Status { get; set; }
        public int UserID { get; set; }
        public int CategoryID { get; set; }
    
    }
}