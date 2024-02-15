namespace CatShelter.Model;

public class Cat
{
    public Guid Id { get; }
    public string Name { get; set; }
    public int Age { get; set; }
    public CatBreed Breed { get; set; }
    public bool Vaccinated { get; set; }

    public Cat(string name, int age, CatBreed breed, bool vaccinated)
    {
        Name = name;
        Age = age;
        Breed = breed;
        Vaccinated = vaccinated;
        Id = Guid.NewGuid();
    }
}
