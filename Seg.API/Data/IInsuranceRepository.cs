using System.Collections.Generic;
using System.Threading.Tasks;
using Seg.API.Models;

namespace Seg.API.Data
{
    public interface IInsuranceRepository
    {
         void Add<T>(T entity) where T : class;
         void Delete<T>(T entity) where T : class;         
         void Edit<T>(T entity) where T : class;
         Task<Insurance> GetInsurance(int id);
         Task<List<Insurance>> GetAllInsurances();
         Task<bool> SaveAll();
    }
}