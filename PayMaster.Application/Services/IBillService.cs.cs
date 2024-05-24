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
        Task<IEnumerable<Bill>> GetBillsForUserAsync(int userId);//faturaları almak için 
        Task AddBillAsync(Bill bill);//yeni bir fatura eklemek için
        Task UpdateBillAsync(Bill bill);//mevcut bir faturayı güncellemek için
        Task DeleteBillAsync(int billId); //belirli bir faturayı silmek için 

    }
}
