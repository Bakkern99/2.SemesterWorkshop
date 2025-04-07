using Microsoft.AspNetCore.Mvc;
using Shared;
namespace ServerAPI2.Controllers;

public class TojController
{
    [ApiController]
    [Route("api/toj")]
    public class BikeController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Toj> Get()
        {
            return tojRepo.GetAll();
        }

        [HttpPost]
        public void Add(Toj toj)
        {
            tojRepo.Add(toj);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public void DeleteById(int id)
        {
            Console.WriteLine($"Sletter item med id {id}");
            tojRepo.DeleteById(id);
        }
        
        [HttpPut]
        [Route("{id:int}")]
        public void UpdateById(int id)
        {
            tojRepo.UpdateById(id);
        }

    }
}