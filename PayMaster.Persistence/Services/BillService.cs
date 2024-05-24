using PayMaster.Application.Dtos.Bill;
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
    public class BillService : IBillService
    {
        private readonly PayMasterDbContext _context;

        public BillService(PayMasterDbContext context)
        {
            _context = context;
        }
        public void AddBill(AddBillDto addBillDto)
        {
            var bill = new Bill
            {
                Description = addBillDto.Description,
                Amount = addBillDto.Amount,
                DueDate = addBillDto.DueDate,
                UserId = addBillDto.UserId
            };

            _context.Bills.Add(bill);
            _context.SaveChanges();
        }

        public void DeleteBill(int billId)
        {
            var bill = _context.Bills.FirstOrDefault(b => b.Id == billId);
            if (bill == null)
            {
                throw new Exception("Bill not found");
            }

            _context.Bills.Remove(bill);
            _context.SaveChanges();
        }

        public List<GetBillDto> GetBillsForUser(int userId)
        {
            return _context.Bills
                 .Where(b => b.UserId == userId)
                 .Select(b => new GetBillDto
                 {
                     Id = b.Id,
                     Description = b.Description,
                     Amount = b.Amount,
                     DueDate = b.DueDate,
                     UserId = b.UserId
                 })
                 .ToList();
        }

        public GetBillDto GetById(int id)
        {
            var bill = _context.Bills
                 .Where(b => b.Id == id)
                 .Select(b => new GetBillDto
                 {
                     Id = b.Id,
                     Description = b.Description,
                     Amount = b.Amount,
                     DueDate = b.DueDate,
                     UserId = b.UserId
                 })
                 .FirstOrDefault();

            if (bill == null)
            {
                throw new Exception("Bill not found");
            }

            return bill;
        }

        public void UpdateBill(UpdateBillDto updateBillDto)
        {
            var bill = _context.Bills.FirstOrDefault(b => b.Id == updateBillDto.Id);
            if (bill == null)
            {
                throw new Exception("Bill not found");
            }

            bill.Description = updateBillDto.Description;
            bill.Amount = updateBillDto.Amount;
            bill.DueDate = updateBillDto.DueDate;
            bill.UserId = updateBillDto.UserId;

            _context.SaveChanges();
        }
    }
}
