using CatShelter.Dtos;
using CatShelter.Model;
using CatShelter.Persistence;

namespace CatShelter.Services;

public class CatRepository : ICatRepository
{
    private readonly InMemoryCatStorage _catStorage;
    public CatRepository(InMemoryCatStorage catStorage)
    {
        _catStorage = catStorage;
    }

    /// <returns>null if no cat with this ID exists, the desired cat object otherwise</returns>
    public Cat? GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    /// <returns>A collection of the desired cats. If no cats fulfill the filter criteria, an empty array</returns>
    public IEnumerable<Cat> GetAll(bool? onlyVaccinated, int? olderThan)
    {
        // TODO
        throw new NotImplementedException();
    }

    public void Add(Cat createCatDto)
    {
        // TODO
        throw new NotImplementedException();
    }

    /// <returns>true if the cat has been found and deleted, false if the cat could not be found</returns>
    public bool Delete(Guid id)
    {
        // TODO
        throw new NotImplementedException();
    }
}
