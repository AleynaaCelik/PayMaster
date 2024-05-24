using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayMaster.Application.RequestParameters
{
    public class Pagination
    {
        public int PageCount { get; set; } = 0;
        public int PageSize { get; set; } = 5;
    }
}
