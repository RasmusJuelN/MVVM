using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Domain.Models
{
    public class Admin : DomainObject
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}
