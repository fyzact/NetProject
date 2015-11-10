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
    public interface IProductService
    {
       IList<ProductItemDto> GetProducts();
    }
}
