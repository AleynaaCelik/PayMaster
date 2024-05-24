using PayMaster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayMaster.Application.Dtos
{
    public class SubscriptionDto
    {
        //Abonelik verileri 


        public int Id { get; set; }
        public string Name { get; set; }
        public decimal MonthlyCost { get; set; }
        public DateTime StartDate { get; set; }

        // DTO'ya dönüşüm metodu
        public static SubscriptionDto FromModel(Subscription subscription)
        {
            return new SubscriptionDto
            {
                Id = subscription.Id,
                Name = subscription.Name,
                MonthlyCost = subscription.MonthlyCost,
                StartDate = subscription.StartDate
            };
        }
    }
}
