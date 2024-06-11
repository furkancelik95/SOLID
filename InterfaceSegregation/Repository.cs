using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class Product
    {

    }

    public class Order
    {

    }

    public interface IRepository<T> where T : class
    {
        T GetById(int id);
        IList<T> GetAll();
        void Add(T entity);

    }

    public interface ISearchable<T> where T : class
    {
        IList<T> SearchByName(string name);
    }

    public class ProductRepository : IRepository<Product>, ISearchable<Product>
    {
        public void Add(Product entity)
        {
            Console.WriteLine("Product Added");
        }

        public IList<Product> GetAll()
        {
            return new List<Product>();
        }

        public Product GetById(int id)
        {
            return new Product();
        }

        public IList<Product> SearchByName(string name)
        {
            return new List<Product>();
        }
    }

    public class OrderRepository : IRepository<Order>
    {
        public void Add(Order entity)
        {
            Console.WriteLine("Order Added");
        }

        public IList<Order> GetAll()
        {
            return new List<Order>();
        }

        public Order GetById(int id)
        {
            return new Order();
        }
    }

    public class SearcherComponent<T> where T : class
    {
        public void Search(ISearchable<T> searchable, string name)
        {
            searchable.SearchByName(name);
        }
    }

}

