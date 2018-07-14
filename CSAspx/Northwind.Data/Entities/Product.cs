using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
#endregion

namespace Northwind.Data.Entities
{
    //the Table annotation points to the table in the sql
    //    database that this calss definites 
    [Table("Prodcuts")]
    public class Product
    {
        //create a property for each attribute on the 
        //   sql table
        //use C# datatype for the sql attributes
        //Rules:
        // a) if you use the attribute name as your Property name
        //    the order of properties is not important 
        // b) if you do NOT use the attribute name as your Property name
        //    the order of properties must match the order of attributes
        // c) Foriegn Keys do NOT need an annotation if the property name
        //       is the same as the attribute name
        // d) Primary keys are by default treated as IDENTITY. If your 
        //       pkey is not an IDENTITY then you must add a 
        //       .DataGenerated(DataGeneratedOption.xxx) annotation parameter
        // e) Primary key properties are best defaulted to end in ID (Id)
        // f) Compound pkey are described using the Column(Order=n)
        //       annotation parameter; where n is 1, 2, 3 etc. (physical order of sql attributes)

        //[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Key, Column(Order =1)]
        [Key]
        public int ProductID { get; set; } //no ? for not null
        public string ProductName { get; set; }
        public int? SuppplierID { get; set; } //Foreign key 
        public int? CategoryID { get; set; } //Foreign key 
        public string QuantityPerUnit { get; set; } 
        public decimal? UnitPrice { get; set; } //? for null
        public Int16? UnitsInStock { get; set; }
        public Int16? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

        //sometimes you will went another property in your class
        //   that will return a non attribute value to the user
        //example Name which could be created by the first and last
        //        name properties
        //to create these non mapped (non existing sql attributes)
        //   properties use the annotation [Not Mapped]

        [NotMapped]
        public string ProductIDName
        {
            get
            {
                return ProductName + "(" + ProductID.ToString() + ")";
            }
        }
    }
}
