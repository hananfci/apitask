using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task.Model;

namespace task.ViewModel
{
    public class VmAddress
    {
        //public int Id { get; set; }
        public string streetName { get; set; }
        public int personId { get; set; }
    }
    public class VmDetailsAddrss
    {
        public int Id { get; set; }
        public string streetName { get; set; }
        public int personId { get; set; }
       
    }
    public static class AddressExtensions
    {

        public static VmAddress ToViewModel(this Address target)
        {

            return new VmAddress()
            {
               // Id = target.Id,
                streetName = target.streetName,
                personId = target.personId

            };
        }
        public static VmDetailsAddrss ToViewDetailsModel(this Address target)
        {

            return new VmDetailsAddrss()
            {
                 Id = target.Id,
                streetName = target.streetName,
                personId = target.personId,
                
            };
        }
    }
}
