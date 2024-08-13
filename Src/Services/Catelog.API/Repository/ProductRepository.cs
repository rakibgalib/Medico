using Catelog.API.Context;
using Catelog.API.Interface.IRepository;
using Catelog.API.Models;
using MongoRepo.Context;
using MongoRepo.Repository;
using System.ComponentModel;

namespace Catelog.API.Repository
{
    public class ProductRepository : CommonRepository<Product>, IProductRepository
    {
        public ProductRepository() : base(new CatalogDbContext())
        {
        }
    }
}
