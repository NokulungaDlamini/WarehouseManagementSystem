using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.DataAccess;
using Warehouse.Entity;

namespace Warehouse.Business
{
    public class ProductBusiness
    {
  
        ProductRepository _productRepository = new ProductRepository();


        public int productinsertDetails(ProductEntity productEntity)
        {
            return _productRepository.productinsert(productEntity);
        }
        public int productupdateDetails(ProductEntity productEntity)
        {
            return _productRepository.productUpdate(productEntity);
        }
        public int productdeleteDetails(ProductEntity productEntity)
        {
            return _productRepository.productDelete(productEntity);
        }
    }
}
