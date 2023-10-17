using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst_0.Models.Entities
{
    //Bİre cok ilişkilerde ilişkiyi cogul olarak alan tarafa sadece Relational Property yazılır...
    public class Category:BaseEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }

        //Relational Properties

        //Virtual keyword'u EntityFramework'deki Relational Property'lerde Lazy Loading anlamına gelir...Polymorphism ile karıstırmayın.
        public virtual List<Product> Products { get; set; }




    }
}
