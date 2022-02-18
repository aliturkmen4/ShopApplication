using ShopApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ShopApplication.DataAccess.Abstract
{
    public interface ICategoryDal
    {
        Category GetById(int id); //geri dönüş tipi product ismi GetById
        Category GetOne(Expression<Func<Category, bool>> filter); //bulduğu ilk kaydı geri alacak!
        IQueryable<Category> GetAll(Expression<Func<Category, bool>> filter); //bulduğu bütün kayıtları geri alacak!

        void Create(Category entity);

        void Update(Category entity);

        void Delete(Category entity);
    }
}
