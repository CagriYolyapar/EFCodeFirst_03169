using EFCodeFirst_0.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst_0.Models.Entities
{


    //Migration kodlarını

    //enable-migrations -enableautomaticmigrations

    //update-database

    //Akademik Blog DB'yi (Makaleler,Yazarlar,YazarProfilleri,Etiketler,Konular)


    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }

    }
}
