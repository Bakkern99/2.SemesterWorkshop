using Shared;
namespace SemesterWorkshop.Service;


public interface ITojService2
{
    Task<Toj[]> GetAll();
    Task DeleteById(int id);
    Task Add(Toj item); 
}

