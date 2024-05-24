using PayMaster.Application.Dtos.Subscription;
using PayMaster.Application.Services;
using PayMaster.Domain.Entities;
using PayMaster.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayMaster.Persistence.Services
{
    public class SubscriptionService : ISubscriptionService
    {
        private readonly PayMasterDbContext _context;

        public SubscriptionService(PayMasterDbContext context)
        {
            _context = context;
        }
        public void AddSubscription(AddSubscriptionDto addSubscriptionDto)
        {
            var subscription = new Subscription
            {
                UserId = addSubscriptionDto.UserId,
                Name = addSubscriptionDto.Name,
                MonthlyCost = addSubscriptionDto.MonthlyCost,
                StartDate = addSubscriptionDto.StartDate,
            };

            _context.Subscriptions.Add(subscription);
            _context.SaveChanges();
        }

        public void DeleteSubscription(int subscriptionId)
        {
            var subscription = _context.Subscriptions.FirstOrDefault(x => x.Id == subscriptionId);

            if (subscription == null)
                throw new Exception("Subscription not found");

            _context.Subscriptions.Remove(subscription);
            _context.SaveChanges();
        }

        public GetSubscriptionDto GetById(int id)
        {
            var subscription = _context.Subscriptions.FirstOrDefault(x => x.Id == id);

            if (subscription == null)
                throw new Exception("Subscription not found");

            return new GetSubscriptionDto
            {
                Id = subscription.Id,
                UserId = subscription.UserId,
                Name = subscription.Name,
                MonthlyCost = subscription.MonthlyCost,
                StartDate = subscription.StartDate
            };
        }

        public List<GetSubscriptionDto> GetSubscriptionsForUser(int userId)
        {
            return _context.Subscriptions
                .Where(x => x.UserId == userId)
                .Select(x => new GetSubscriptionDto
                {
                    Id = x.Id,
                    UserId = x.UserId,
                    Name = x.Name,
                    MonthlyCost = x.MonthlyCost,
                    StartDate = x.StartDate
                }).ToList();
        }

        public void UpdateSubscription(UpdateSubscriptionDto updateSubscriptionDto)
        {
            var subscription = _context.Subscriptions.FirstOrDefault(x => x.Id == updateSubscriptionDto.Id);

            if (subscription == null)
                throw new Exception("Subscription not found");

            subscription.Name = updateSubscriptionDto.Name;
            subscription.MonthlyCost = updateSubscriptionDto.MonthlyCost;
            subscription.StartDate = updateSubscriptionDto.StartDate;
            subscription.UserId = updateSubscriptionDto.UserId;

            _context.SaveChanges();
        }
    }
    }

