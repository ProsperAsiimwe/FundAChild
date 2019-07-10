using FundAChild.Domain.Entities;
using FundAChild.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundAChild.Domain.Abstract
{
    public interface IOrderProcessor
    {
        void ProcessorOrder(Cart cart, Order order);

        void SendUserPassword(string email, string password);

        void storeOrder(string orderDetails, string orderAddress, string clientName, DateTime dueDate);

        void appender(StringBuilder builder, Order order);
    }
}
