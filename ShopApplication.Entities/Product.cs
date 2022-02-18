using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApplication.Entities
{
    public class Product
    {

        //her category birden fazla ürün alabilsin ve her ürünün birden fazla category si olabilsin diye çoka-çok ilişki !!!!

        public int Id { get; set; }

        public string Name { get; set; }

        public string ImgUrl { get; set; }

        public decimal Price { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }

        #region bireçokilişkiiçin
        //public int CategoryId { get; set; }

        //public Category Category { get; set; } 
        #endregion
    }
}
