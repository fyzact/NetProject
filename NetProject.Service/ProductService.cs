using NetProject.Domain;
using NetProject.Repository;
using NetProject.Service.Dto;
using NetProject.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;


namespace NetProject.Service
{

    public class ProductService : IProductService
    {
        IRepository<Product> _productRepository;
        public ProductService()
        {
            _productRepository = new Repository.Repository<Product>();
        }

        public IList<ProductItemDto> GetProducts()
        {
           return _productRepository.GetAll().Select(p => new ProductItemDto
            {

            }).ToList();
           
        }
    }
}
