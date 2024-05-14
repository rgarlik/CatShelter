using CatShelter.Model;

namespace CatShelter.Persistence;

public class InMemoryCatStorage : ICatStorage
{
    public IList<Cat> Cats { get => _catList; }

    private readonly List<Cat> _catList;
    public InMemoryCatStorage() {
        _catList =
        [
            // Populate with dummy data
            .. new[]
            {
                new Cat("Sunshine", 1, CatBreed.Ragdoll, true),
                new Cat("Sasha", 1, CatBreed.Sphynx, false),
                new Cat("Alex", 1, CatBreed.MaineCoon, false),
                new Cat("Mordor", 1, CatBreed.Siamese, true),
                new Cat("Power", 2, CatBreed.Sphynx, true),
                new Cat("Money", 2, CatBreed.Sphynx, true),
                new Cat("Kitty", 2, CatBreed.Ragdoll, true),
                new Cat("Cutie", 2, CatBreed.Ragdoll, false),
                new Cat("Veronika", 2, CatBreed.Sphynx, false),
                new Cat("Princess", 3, CatBreed.Sphynx, true),
                new Cat("Sova", 3, CatBreed.Ragdoll, true),
                new Cat("Lesia", 3, CatBreed.Siamese, false),
                new Cat("Mason", 3, CatBreed.Ragdoll, true),
                new Cat("King", 3, CatBreed.MaineCoon, false),
                new Cat("Caroline", 4, CatBreed.Siamese, false),
                new Cat("Sharpie", 4, CatBreed.MaineCoon, false),
                new Cat("Meowie", 4, CatBreed.Sphynx, true),
                new Cat("Pancake", 5, CatBreed.Ragdoll, true),
                new Cat("Flippie", 5, CatBreed.MaineCoon, false),
                new Cat("Crow", 5, CatBreed.MaineCoon, true),
                new Cat("Martin", 6, CatBreed.Ragdoll, false),
                new Cat("Noodle", 6, CatBreed.Ragdoll, true),
                new Cat("Stanley", 7, CatBreed.Siamese, true),
                new Cat("President", 7, CatBreed.Sphynx, false),
                new Cat("Lilly", 7, CatBreed.MaineCoon, true),
                new Cat("Pho", 8, CatBreed.Sphynx, false),
                new Cat("Tina", 9, CatBreed.MaineCoon, true),
                new Cat("Mimi", 9, CatBreed.Siamese, false),
            },
        ];
    }
}
