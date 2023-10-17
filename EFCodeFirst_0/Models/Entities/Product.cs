using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst_0.Models.Entities
{

    //1 Category            n  Product
    //1 Product             1  Category
    public class Product:BaseEntity
    {
        //Birecok ilişkilerde class'ların birbirlerini tanıyarak (cogul ve tekillik durumlarına dikkat edilip) ilişkinin ifade edilmesi mümkündür...Lakin ilişkiyi gekil olarak alan tarafta ek olarak Foreign Key tanımlaması yapılması en saglıklısıdır...

        //Yapmazsanız yine ilişkiyi kurarsınız ancak Entity Framework Foreign Key'i kendisi tanıtır...Ve bu sadece SQL tarafında tanımlanmıs olur...Yani Ram'de, yani kullandıgınız programlama dilinde  asla tanımlanmadıgı icin o Foreign Key'e ulasamazsınız...Dolayısıyla direkt ilişkinin  nesnesi tarafından haberkesmek zorunda kalırsınız...

        //Bu nedenle dolayı en saglıklısı Foreign Key'i elle ve uygun standartlarda tanımlamak gerekir...Uygun standart da ilişki property'sinin isminin sonuna ID takısının getirilerek yeni bir isim yaratılmasıdır (CategoryID)

        //Bu yontem yapıldıgı takdirde otomatik olarak bire cok ilişki kurulur...

        //Bir nedenden dolayı eger kendi verdiginiz ismin Foreign Key olmasını istiyorsanız bu da mümkündür ancak tavsiye edilmez...

        //public int ASd { get; set; }



        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int CategoryID { get; set; }

        //Relational Properties
        public virtual Category Category { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }




    }
}
