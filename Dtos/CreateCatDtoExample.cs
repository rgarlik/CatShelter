using Swashbuckle.AspNetCore.Filters;

namespace CatShelter.Dtos;

public class CreateCatDtoExample : IExamplesProvider<CreateCatDto>
{
    public CreateCatDto GetExamples()
    {
        return new CreateCatDto
        {
            Name = "Name",
            Age = 3,
            Breed = Model.CatBreed.MaineCoon,
            Vaccinated = true
        };
    }
}

