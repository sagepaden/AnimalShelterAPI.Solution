using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASApi.Models;

namespace ASApi.Controllers.v2
{ 
  [ApiController] 
  [Route("api/v{version:apiVersion}/[controller]")]
  [ApiVersion("2.0")]
  
  public class AnimalsController : ControllerBase
  {
    private readonly ASApiContext _db;

    public AnimalsController(ASApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<List<Animal>> Get(int pageNumber, int pageSize, string name, string species, string breed, int age, bool random = false)
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
      if (pageNumber > 0 && pageSize > 0)
      {
        query = query.Skip((pageNumber - 1) * pageSize).Take(pageSize); 
      }

      if (random)
      {
        Random randomInt = new Random();
        int id = randomInt.Next(1, _db.Animals.ToList().Count);
        query = query.Where(a => a.AnimalId == id);
      }
      return await query.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Animal>> GetAnimal(int id)
    {
      Animal animal = await _db.Animals
                            .FirstOrDefaultAsync(animal => animal.AnimalId == id);
      if (animal == null)
      {
        return NotFound();
      }
      return animal;
    }

    [HttpPost]
    public async Task<ActionResult<Animal>> Post([FromBody] Animal animal)
    {
      _db.Animals.Add(animal);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetAnimal), new { id = animal.AnimalId }, animal);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Animal animal)
    {
      if (id != animal.AnimalId)
      {
        return BadRequest();
      }

      _db.Animals.Update(animal);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!AnimalExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAnimal(int id)
    {
      Animal animal = await _db.Animals.FindAsync(id);
      if (animal == null)
      {
        return NotFound();
      }

      _db.Animals.Remove(animal);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool AnimalExists(int id)
    {
      return _db.Animals.Any(e => e.AnimalId == id);
    }

  }
}

