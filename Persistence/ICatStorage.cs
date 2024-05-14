using CatShelter.Model;

namespace CatShelter.Persistence;

public interface ICatStorage
{
    IList<Cat> Cats { get; }
}
