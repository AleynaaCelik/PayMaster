using PayMaster.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayMaster.Domain.Entities
{
    public class Subscription : EntityBase
    {
        //public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public decimal MonthlyCost { get; set; }
        public DateTime StartDate { get; set; }
        public User User { get; set; }
    }
}
