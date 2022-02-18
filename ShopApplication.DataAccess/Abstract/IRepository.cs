using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ShopApplication.DataAccess.Abstract
{

    //bunu generic yapıyorum sonra Iproductdal ve Icategorydal'ı buradan türeteceğim ve onların içi boşalacak tip olarak da category ve product vereceğim!
    public interface IRepository<T> //Generic yaptım!
    {
        T GetById(int id); //geri dönüş tipi product ismi GetById
        T GetOne(Expression<Func<T, bool>> filter); //bulduğu ilk kaydı geri alacak!
        IQueryable<T> GetAll(Expression<Func<T, bool>> filter); //bulduğu bütün kayıtları geri alacak!

        void Create(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
