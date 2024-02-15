using CatShelter.Model;

namespace CatShelter.Services;

public interface ICatRepository
{
    Cat? GetById(Guid id);
    IEnumerable<Cat> GetAll(bool? onlyVaccinated, int? olderThan);
    void Add(Cat entity);
    bool Delete(Guid id);
}
