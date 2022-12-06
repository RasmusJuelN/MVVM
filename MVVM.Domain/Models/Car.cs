using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Domain.Models
{
    public class Car : DomainObject
    {
        public string? Model { get; set; }
        public string? LicensePlate { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
