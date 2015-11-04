using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetProject.Domain
{
    public class BaseEntity
    {

        public DateTime? InsertedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
