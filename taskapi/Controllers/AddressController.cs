using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task.Model;
using task.Model.repositories;
using task.ViewModel;

namespace taskapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddressController : ControllerBase
    {
        private readonly ITaskRepository<Address> _service;

        public AddressController(ITaskRepository<Address> service)
        {
            this._service = service;
        }

        [HttpGet("Getall")]
        public List<VmDetailsAddrss> GetAllAddress()
        {
            var query = _service.List();
            return query.Select(x=>x.ToViewDetailsModel()).ToList();
        }

        [HttpPost("InsertAddress")]
        public Address InsertAddress(VmAddress obj)
        {
            var ObjAddress = new Address { personId = obj.personId, streetName = obj.streetName };
            var query = _service.Add(ObjAddress);
            return query;
        }
        [HttpDelete("DeleteAddress")]
        public bool DeleteAddress(int id)
        {
            var query = _service.Delete(id);
            return query;
        }

        [HttpPut("UpdateAddress")]
        public Address UpdateAddress(int id, VmAddress obj)
        {
            var ObjAddress = new Address { personId = obj.personId, streetName = obj.streetName };

            var query = _service.Update(id, ObjAddress);
            return query;
        }

        [HttpGet("DetailsAddress")]
        public Address DetailsAddress(int id)
        {
            var query = _service.Find(id);
            return query;
        }
    }
}
