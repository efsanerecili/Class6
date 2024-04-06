using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Store
    {
        public int Id { get; set; }
        private int _id;
        public Store()
        {
            _id++;
            Id = _id;
        }
        Product[] Products = new Product[0];
        public void RemoveProductByNo(int no)
        {
            Products = no != no ? Products : new Product[0];
        }
        public Product GetProduct(int no)
        {
             Products=no==no ? Products : new Product[0];
            return Products[no];
        }

        public Product[] FilterProductsByType(string type)
        {
            return Products;
        }

        public void FilterProductsByType(int type, Product[] Products)
        {
            Products = new Product[type];
        }
         
        public Product[] FilterProductsByName( string name )
        {
            return Products;
        }
        public void Sale( int no, Person person) 
        {
            Product Product = GetProduct(no);
            if (Product.Count <= 0)
            {
                return;
            }
            else
            {
                 Product.Count--;
                 person.Cash -= Product.Price;
            }
        }

     public void AddProduct( Product product )
        {
            if (product.Price > 0)
            {
                Array.Resize(ref Products,Products.Length);
                Products[Products.Length - 1] = product;
            }
        }



















    }
}
