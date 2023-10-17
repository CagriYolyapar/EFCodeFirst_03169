using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst_0.Models.Entities
{
    //1 AppUser n Orders
    //1 Order   1 AppUser

    //1 Order             n  Products
    //1 Product           n  Orders
    public class Order:BaseEntity
    {
        public string ShippingAddress { get; set; }
        public int AppUserID { get; set; }


        //Relational Properties
        public virtual AppUser AppUser { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }



    }
}
