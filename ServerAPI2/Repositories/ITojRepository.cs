using Shared;

namespace ServerAPI2.Repositories;

public interface ITojRepository
{
    List<Toj> GetAll();
    void Add(Toj tojItem);
    void UpdateById(int id, Toj tojItem);

    void DeleteById(int id);
}