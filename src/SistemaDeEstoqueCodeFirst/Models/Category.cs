using System.Collections.Generic;

namespace SistemaDeEstoqueCodeFirst.Models
{
    public class Category
    {
        protected Category() => 
            Products = new List<Product>();
        public Category(int iD, string name, string description)
        {
            ID = iD;
            Name = name;
            Description = description;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}