using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementDomainLayer
{
    public class Customer: Person
    {
        public Customer(string firstName, string lastName, string email, int phoneNumber, string address, DateTime dateMembership) 
            : base(firstName, lastName, email, phoneNumber, address)
        {
            DateMembership = dateMembership;
        }

        public DateTime DateMembership { get; set; }

        public List<Order> OrderList { get; set; }

        public int DiscountCalculation()
        {
            if (OrderList.Count > 250 && TotalSpending()>5000.0)
            {
                return 5;
            }
            else
            {
                return 0;
            }
        }

        public double TotalSpending()
        {
            double totalSpending = 0;
            foreach (var order in OrderList)
            {
                foreach (var keyValue in order.Products)
                {
                    totalSpending += keyValue.Value*keyValue.Key.Price;
                }
            }
            return totalSpending;
        }
    }
}
