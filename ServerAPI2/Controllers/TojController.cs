using Microsoft.AspNetCore.Mvc;
using ServerAPI2.Repositories;
using Shared;

namespace ServerAPI2.Controllers

{
    [ApiController]
    [Route("api/toj")]
    public class TojController : ControllerBase
    {
        private ITojRepository tojRepo;

        public TojController(ITojRepository tojRepo) {
            this.tojRepo = tojRepo;
        }

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