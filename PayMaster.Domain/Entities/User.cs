using PayMaster.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayMaster.Domain.Entities
{
    public class User : EntityBase
    {
        //public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}
