using CatShelter.Model;

namespace CatShelter.Persistence;

public interface ICatStorage
{
    IQueryable<Cat> Cats { get; }
}
