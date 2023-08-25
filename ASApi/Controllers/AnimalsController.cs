using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASApi.Models;

namespace ASApi.Controllers.v1
{ 
  [ApiController] 
  [Route("api/v{version:apiVersion}/[controller]")]
  [ApiVersion("1.0")]
  
  public class AnimalsController : ControllerBase
  {
    private readonly ASApiContext _db;

    public AnimalsController(ASApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<List<Animal>> Get(string name, string species, string breed, int age, bool random = false)
    {
      IQueryable<Animal> query = _db.Animals
                                  .AsQueryable();
      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (species != null)
      {
        query = query.Where(entry => entry.Species == species);
      }

      if (breed != null)
      {
        query = query.Where(entry => entry.Breed == breed);
      }

      if (age > 0)
      {
        query = query.Where(entry => entry.Age == age);
      }

      if (random)
      {
        Random randomInt = new Random();
        int id = randomInt.Next(1, _db.Animals.ToList().Count);
        query = query.Where(a => a.AnimalId == id);
      }
      return await query.ToListAsync();
    }
  }
}