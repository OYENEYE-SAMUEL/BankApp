using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApp.Models
{
    public class AccountType
    {
        public string Id = Guid.NewGuid().ToString();
        public string Name {get; set;} = default!;
        public string? Description {get; set;}
        public decimal Limit {get; set;}
        public decimal DailyTransferLimit {get; set;}
        public decimal OpeningBalance {get; set;}
        public int AgeLimit {get; set;}
        public bool IsDeleted {get; set;}
    }
}