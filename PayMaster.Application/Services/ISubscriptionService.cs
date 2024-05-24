using PayMaster.Application.Dtos;
using PayMaster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayMaster.Application.Services
{
    public interface ISubscriptionService
    {
        List<GetSubscriptionDto> GetSubscriptionsForUser(int userId);
        GetSubscriptionDto GetById(int id);
        void AddSubscription(AddSubscriptionDto addSubscriptionDto);
        void UpdateSubscription(UpdateSubscriptionDto updateSubscriptionDto);
        void DeleteSubscription(int subscriptionId);
    }
}
