using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApp.DTOs
{
    public class RoleResponseModel
    {
        public string Name {get;set;} = default!;
        public string? Description {get;set;}
    }

    public class RoleResquestModel
    {
        public string Name {get;set;} = default!;
        public string? Description {get;set;}
    }
}