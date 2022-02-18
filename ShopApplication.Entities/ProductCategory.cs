using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApplication.Entities
{
    public class ProductCategory //junction table(birleşim tablosu)
    {
        public int CategoryId { get; set; } //1.anahtar olarak işaretlemem gerekiyor (FluentAPI ile)

        public Category Category { get; set; } //navigation property
        //tek bir category e karşılık geldiği için tekil isim ver!
        public int ProductId { get; set; } //1.anahtar olarak işaretlemem gerekiyor (FluentAPI ile)

        public Product Product { get; set; } //navigation property
    }
}
