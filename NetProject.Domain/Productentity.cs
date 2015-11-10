using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetProject.Domain
{
    public class ProductEntity : BaseEntity
    {
        public int Id{ get; set; }
        public string ProductName { get; set; }
        public int BrandId{ get; set; }

        public BrandEntity Brand { get; set; }
    }

    
}
