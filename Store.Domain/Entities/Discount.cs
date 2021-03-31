using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Entities
{
    public class Discount : Entity
    {
        public Discount(decimal amount, DateTime expireDate)
        {
            Amount = amount;
            ExpireDate = expireDate;
        }

        public decimal Amount { get; private set; }
        public DateTime ExpireDate { get; private set; }

        public bool Valid()
        {
            return DateTime.Compare(DateTime.Now, ExpireDate) < 0;
        }
        
        // ajuda a fazer algumas verificações, evita fazer verificações no código (cupom nulo do banco, por exemplo)
        public decimal Value()
        {
            if (Valid())
                return Amount;
            return 0;
        }
    }
}
