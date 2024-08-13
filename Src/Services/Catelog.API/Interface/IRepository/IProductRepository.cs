using Catelog.API.Models;
using MongoRepo.Interfaces.Repository;

namespace Catelog.API.Interface.IRepository
{
    public interface IProductRepository:ICommonRepository<Product>
    {
    }
}
