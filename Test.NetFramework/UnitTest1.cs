using Microsoft.VisualStudio.TestTools.UnitTesting;
using QPE.Validator;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Test.NetFramework
{
    [TestClass]
    public class UnitTest1
    {
        public class Order
        {
            public DateTime Date { get; set; }
            public int OrderId { get; set; }
            public string Item { get; set; }
            public decimal? Quantity { get; set; }
        }

        [TestMethod]
        public void TestMethod1()
        {
            Validator v = new Validator();
            v.AddRuleFor<Order>("OrderId", f => f.OrderId, Rules.Required(), Rules.Numeric(), Rules.GreaterOrEqual(100));
            v.AddRuleFor<Order>("Item", f => f.Item, Rules.Required(), Rules.Numeric());
            v.AddRuleFor<Order>("Quantity", f => f.Quantity, "Required", "GreaterOrEqual 1");

            Order order1 = new Order();
            order1.OrderId = 999;
            order1.Item = "126545641232";
            order1.Quantity = null;

            var errors = v.ValidateAll(order1);
            Assert.IsInstanceOfType(errors, typeof(IEnumerable<RuleError>));

            //Se esperan dos errores ya que la cantidad no ha sido seteada y es requerida.
            Assert.AreEqual(2, errors.Count()); 

            order1.Item = "asdfasdf";
            errors = v.Validate(order1, "Item");
            Assert.AreEqual(1, errors.Count());
        }
    }
}