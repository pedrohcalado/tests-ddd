using Store.Domain.Entities;
using Store.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Tests.Repositories
{
    class FakeOrderRepository : IOrderRepository
    {
        public void Save(Order order)
        {
        }
    }
}
