using System.Collections.Immutable;
using Shared;

namespace ServerAPI2.Repositories;

public class TojRepository : ITojRepository
{
    private readonly List<Toj> _tojItems = new();

    public List<Toj> GetAll()
    {
        return _tojItems;
    }

    public void Add(Toj tojItem)
    {
        int maxId = _tojItems.Any() ? _tojItems.Max(t => t.Id) : 0;
        tojItem.Id = maxId + 1;
        _tojItems.Add(tojItem);
    }

    public void UpdateById(int id, Toj tojItem)
    {
        var existingToj = _tojItems.FirstOrDefault(t => t.Id == id);
        if (existingToj != null)
        {
            existingToj.Type = tojItem.Type;
            existingToj.farve = tojItem.farve;
            existingToj.size = tojItem.size;
            existingToj.status = tojItem.status;
            existingToj.image = tojItem.image;
            existingToj.pris = tojItem.pris;
        }
    }


    public void DeleteById(int id)
    {
        var tojToRemove = _tojItems.FirstOrDefault(t => t.Id == id);

        if (tojToRemove != null)
        {
            _tojItems.Remove(tojToRemove);
        }
    }
}