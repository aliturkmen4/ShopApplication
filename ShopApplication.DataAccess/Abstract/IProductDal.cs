using ShopApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ShopApplication.DataAccess.Abstract
{
    public interface IProductDal
    {
        Product GetById(int id); //geri dönüş tipi product ismi GetById
        Product GetOne(Expression<Func<Product, bool>> filter); //bulduğu ilk kaydı geri alacak!
        IQueryable<Product> GetAll(Expression<Func<Product, bool>> filter); //bulduğu bütün kayıtları geri alacak!

        void Create(Product entity);

        void Update(Product entity);

        void Delete(Product entity);
    }
}
