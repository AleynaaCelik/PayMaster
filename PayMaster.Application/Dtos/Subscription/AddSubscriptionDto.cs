using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayMaster.Application.Dtos.Subscription
{
    public class AddSubscriptionDto
    {
        public string Name { get; set; }
        public decimal MonthlyCost { get; set; }
        public DateTime StartDate { get; set; }
        public int UserId { get; set; }
    }
}
