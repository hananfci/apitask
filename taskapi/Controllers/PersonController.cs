using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task.Model;
using task.Model.repositories;

namespace task.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ITaskRepository<Person> _service;

        public PersonController(ITaskRepository<Person> service)
        {
            this._service = service;
        }

        [HttpGet("Getall")]
        public List<Person> GetAllPerson()
        {
            var query = _service.List();
            return query;
        }

        [HttpPost("InsertPerson")]
        public Person InsertPerson(Person obj)
        {
            var query = _service.Add(obj);
            return query;
        }
        [HttpDelete("DeletePerson")]
        public bool DeletePerson(int id)
        {
            var query = _service.Delete(id);
            return query;
        }

        [HttpPut("UpdatePerson")]
        public Person UpdatePerson(int id, Person obj)
        {
            var query = _service.Update(id,obj);
            return query;
        }

        [HttpGet("DetailsPerson")]
        public Person DetailsPerson(int id)
        {
            var query = _service.Find(id);
            return query;
        }
    }
}
