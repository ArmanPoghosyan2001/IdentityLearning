using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityLearning.Models
{
    public class Student : User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Faculty { get; set; }

    }
}
