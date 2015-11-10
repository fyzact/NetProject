using NetProject.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace NetProject.Service.Interface
{
    [ServiceContract]
<<<<<<< HEAD
    public interface IProductService
=======
     interface IProductService
>>>>>>> origin/master
    {
       IList<ProductItemDto> GetProducts();
    }
}
