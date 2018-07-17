using Northwind.Data.Entities;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespace 
using System.Collections.Generic;
using NorthwindSystem.DAL;
#endregion
namespace NorthwindSystem.BLL
{
    //this is the public interface class that will handle
    //  web page service requests for data to the Product sql table
    //Methods in this class can interact with the internal DAL Context class
    public class ProductController
    {
        //this method will return all records from the sql table Products
        //this method will first create a transaction code block which uses
        //     the DAL Context class
        //the Context class has a DbSet<Product> for referencing the sql table
        //The property work with EntityFramework to retrieve the data  
        public List<Product> Products_List()
        {
            using (var context = new NorthwindContext())
            {
                return context.Products.ToList();
            }

        }

        //this method will return a specific record from the sql 
        //     Products table based on the primnary key
        public Product Products_GetProduct(int productid)
        {
            using (var context = new NorthwindContext())
            {
                return context.Products.Find(productid);
            }
        }
    }

    public class CategoryController
    {
        public List<Category> Categories_List()
        {
            using (var context = new NorthwindContext())
            {
                return context.Categories.ToList();
            }

        }
        public Category Categories_GetCategory(int categoryid)
        {
            using (var context = new NorthwindContext())
            {
                return context.Categories.Find(categoryid);
            }
        }
    }

    public class SupplierController
    {
        public List<Supplier> Suppliers_List()
        {
            using (var context = new NorthwindContext())
            {
                return context.Suppliers.ToList();
            }

        }
        public Supplier Suppliers_GetSupplier (int supplierid)
        {
            using (var context = new NorthwindContext())
            {
                return context.Suppliers.Find(supplierid);
            }
        }
    }
}
