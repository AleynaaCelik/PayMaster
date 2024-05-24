using PayMaster.Application.Dtos.Bill;
using PayMaster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayMaster.Application.Services
{
    public interface IBillService
    {
        List<GetBillDto> GetBillsForUser(int userId);
        GetBillDto GetById(int id);
        void AddBill(AddBillDto addBillDto);
        void UpdateBill(UpdateBillDto updateBillDto);
        void DeleteBill(int billId);

    }
}
