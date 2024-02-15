using CatShelter.Dtos;
using CatShelter.Model;
using CatShelter.Services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.Filters;

namespace CatShelter.Controllers;
[Route("api/cats")]
[ApiController]
public class CatsController : ControllerBase
{
    private readonly ICatRepository _catRepository;

    public CatsController(ICatRepository catRepository)
    {
        _catRepository = catRepository;
    }

    /// <summary>
    /// Gets all cats from the database with optional filters
    /// </summary>
    /// <response code="200">Collection of all cats from the database with optional filtering</response>
    [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(IEnumerable<Cat>))]
    [HttpGet]
    public ActionResult<IEnumerable<Cat>> Get(bool? onlyVaccinated, int? olderThan)
    {
        return Ok(_catRepository.GetAll(onlyVaccinated, olderThan));
    }

    /// <summary>
    /// Gets a cat by its ID
    /// </summary>
    /// <response code="200">The desired cat object</response>
    /// <response code="404">Cat not found</response>
    [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(Cat))]
    [SwaggerResponse(StatusCodes.Status404NotFound)]
    [HttpGet("{id}")]
    public IActionResult Get(Guid id)
    {
        return Ok(_catRepository.GetById(id));
    }

    /// <summary>
    /// Adds a new cat into the database
    /// </summary>
    /// <response code="201">The cat has been added</response>
    [SwaggerResponse(StatusCodes.Status201Created)]
    [SwaggerRequestExample(typeof(CreateCatDto), typeof(CreateCatDtoExample))]
    [HttpPost]
    public IActionResult Post([FromBody] CreateCatDto value)
    {
        var cat = new Cat(value.Name, value.Age, value.Breed, value.Vaccinated);
        _catRepository.Add(cat);
        return Ok();
    }

    /// <summary>
    /// Deletes an already existing cat from the database
    /// </summary>
    /// <response code="204">The cat has been removed</response>
    /// <response code="404">Cat not found</response>
    [HttpDelete("{id}")]
    [SwaggerResponse(StatusCodes.Status204NoContent)]
    [SwaggerResponse(StatusCodes.Status404NotFound)]
    public IActionResult Delete(Guid id)
    {
        if(_catRepository.Delete(id))
        {
            return NoContent();
        } else
        {
            return NotFound();
        }
        
    }
}
