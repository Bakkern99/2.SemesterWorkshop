using Shared;

namespace ServerAPI2.Repositories;

public interface ITojRepository
{
    List<Toj> GetAll();
    void Add(Toj tojItem);
    void UpdateById(int id);
    void DeleteById(int id);
}