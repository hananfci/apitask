using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task.Model;

namespace task.ViewModel
{
    public class VmPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
    }

    public static class PersonExtensions
    {

        public static VmPerson ToViewModel(this Person target)
        {

            return new VmPerson()
            {
                Id = target.Id,
                Name = target.Name,
                email = target.email,
                phone = target.phone

            };
        }
    }
}
