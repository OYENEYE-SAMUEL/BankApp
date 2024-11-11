using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApp.Models
{
    public class Role
    {
        public string Id = Guid.NewGuid().ToString();
        public string Name {get;set;} = default!;
        public string? Description {get;set;}
        public bool IsDeleted {get;set;}
    }
}