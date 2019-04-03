using Microsoft.VisualStudio.TestTools.UnitTesting;
using QPE.Validator;

namespace Test.NetFramework
{
    [TestClass]
    public class UnitTest1
    {

        public class Order
        {
            public int OrderId { get; set; }
            public string Item { get; set; }
            public decimal Quantity { get; set; }
        }

        enum Comparison
        {
            LessThan = -1, Equal = 0, GreaterThan = 1
        };
        [TestMethod]
        public void TestMethod1()
        {
            Validator v = new Validator();
            v.AddRuleFor<Order>("OrderId", f => f.OrderId, Rules.Required(), Rules.Numeric());
            v.AddRuleFor<Order>("Item", f => f.Item, Rules.Required(), Rules.Numeric());
            v.AddRuleFor<Order>("Quantity", f => f.Quantity, "Required", "Required", "GreaterOrEqual 123");


            



        }
    }
}
