using CatShelter.Model;

namespace CatShelter.Dtos;

public class CreateCatDto
{
    public string Name { get; set; }
    public int Age { get; set; }
    public CatBreed Breed { get; set; }
    public bool Vaccinated { get; set; }
}
