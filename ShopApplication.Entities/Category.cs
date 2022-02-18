using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApplication.Entities
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }

        #region bireçokilişkiiçin
        //public List<Product> Products { get; set; } //category üzerinden productlara ulaşmak için! 
        #endregion
    }
}
