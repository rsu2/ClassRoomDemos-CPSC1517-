﻿using Northwind.Data.Entities;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region
using System.Collections.Generic;
using NorthwindSystem.DAL;
#endregion

namespace NorthwindSystem.BLL
{
    public class SupplierController
    {
        public List<Supplier> Suppliers_List()
        {
            using (var context = new NorthwindContext())
            {
                return context.Suppliers.ToList();
            }

        }
        public Supplier Suppliers_GetSupplier(int supplierid)
        {
            using (var context = new NorthwindContext())
            {
                return context.Suppliers.Find(supplierid);
            }
        }
    }
}
