using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApp.DTOs
{
    public class AccountTypeResponseModel
    {
        public string Name {get; set;} = default!;
        public string? Description {get; set;}
        public decimal Limit {get; set;}
        public decimal DailyTransferLimit {get; set;}
        public decimal OpeningBalance {get; set;}
        public int AgeLimit {get; set;}
    }

    public class AccountTypeRequestModel
    {
        public string Name {get; set;} = default!;
        public string? Description {get; set;}
        public decimal Limit {get; set;}
        public decimal DailyTransferLimit {get; set;}
        public decimal OpeningBalance {get; set;}
        public int AgeLimit {get; set;}
    }
}