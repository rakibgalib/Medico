using Catelog.API.Interface.IManager;
using Catelog.API.Models;
using Catelog.API.Repository;
using MongoRepo.Manager;
using MongoRepo.Repository;

namespace Catelog.API.Manager
{
    public class ProductManager : CommonManager<Product>, IProductManager
    {
        public ProductManager() : base(new ProductRepository())
        {
        }
    }
}
