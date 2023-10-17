using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst_0.Models.Entities
{

    //Birebir ve cokacok ilişkiler, birecok gibi tek fazda ifade edilemez...Bunlar öncelikle class ilişkilerinde tanımlanmalı sonra Veritabanı yaratılma ayarlarında özellikle belirtilmelidirler...
    public class AppUserProfile:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Relational Properties
        public virtual AppUser AppUser { get; set; }


    }
}
