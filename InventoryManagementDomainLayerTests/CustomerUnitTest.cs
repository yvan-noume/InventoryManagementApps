using InventoryManagementDomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementDomainLayerTests
{
    [TestClass]
    public class CustomerUnitTest
    {
        private Product product1;
        private Product product2;
        private Order order1;
        private Order order2;
        private Order order3;
        private Customer customer;

        [TestInitialize]
        public void Initialize()
        {
            product1 = new Product { Name="Product1",Price=25.0  };
            product2 = new Product { Name="Product2",Price=35.0  };
            order1 = new Order { Products = new Dictionary<Product, int>() };
            order2 = new Order { Products = new Dictionary<Product, int>() { { product1, 4 } } };
            order3 = new Order { Products = new Dictionary<Product, int>() { { product1, 4 }, { product2, 3 } } };
            customer = new Customer("yvan", "Robert", "yvan@", 455666, "address", DateTime.Now);           
        }

        [TestMethod]
        public void TotalSpendingTest()
        {
            customer.OrderList = new List<Order>();
            customer.OrderList.Add(order1);
            Assert.AreEqual(0.0, customer.TotalSpending());
            customer.OrderList.Add(order2);
            Assert.AreEqual(100.0, customer.TotalSpending());
            customer.OrderList.Add(order3);
            Assert.AreEqual(305.0, customer.TotalSpending());
        }

        [TestMethod]
        public void CalculationDiscountTest()
        {
            customer.OrderList = new List<Order>();
            customer.OrderList.Add(order1);
            Assert.AreEqual(0, customer.DiscountCalculation());
            customer.OrderList.Add(order2);
            Assert.AreEqual(0, customer.DiscountCalculation());
        }
    }
}
