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
        Task<IEnumerable<Subscription>> GetSubscriptionsForUserAsync(int userId); //belirli bir kullanıcı için abonelikleri almak 
        Task AddSubscriptionAsync(Subscription subscription); //yeni bir abonelik eklemek için
        Task UpdateSubscriptionAsync(Subscription subscription); //mevcut bir aboneliği güncellemek için
        Task DeleteSubscriptionAsync(int subscriptionId);//belirli bir aboneliği silmek için 
    }
}
