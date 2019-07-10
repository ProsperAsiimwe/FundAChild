using FundAChild.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FundAChild.WebUI.Models.Orders
{
    public class OrderListViewModel
    {
        public IEnumerable<Order> Orders { get; set; }
    }
}