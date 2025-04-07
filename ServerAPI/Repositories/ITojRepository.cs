using Shared;

namespace ServerAPI.Repositories;

public interface ITojRepository
{
    List<Toj> GetAll();
    void Add(Toj tojItem);
    void Update(Toj tojItem);
    void Delete(string title);
}