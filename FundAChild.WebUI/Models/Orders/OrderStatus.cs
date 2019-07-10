using FundAChild.Domain.Entities;
using FundAChild.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundAChild.WebUI.Models.Orders
{
   public class OrderStatus
    {
        public OrderStatus() { }

        public OrderStatus(Order Order)
        {
            setFromOrder(Order);
        }


        public int OrderId { get; set; }

        public Status Status { get; set; }


        public Order ParseAsEntity(Order Order)
        {
            if (Order == null)
            {
                Order = new Order();
            }

            Order.Status = Status;
                      
            return Order;

        }

        public void setFromOrder(Order Order)
        {
            this.OrderId = Order.OrderId;
            this.Status = Order.Status;
        }
    }
}
