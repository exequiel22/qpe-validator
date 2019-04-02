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
            //Randomizer.Seed = new Random(8675309);

            //var fruit = new[] { "apple", "banana", "orange", "strawberry", "kiwi" };
            //var orderIds = 0;
            //var testOrders = new Faker<Order>()
            //    //Ensure all properties have rules. By default, StrictMode is false
            //    //Set a global policy by using Faker.DefaultStrictMode
            //    .StrictMode(true)
            //    //OrderId is deterministic
            //    .RuleFor(o => o.OrderId, f => orderIds++)
            //    //Pick some fruit from a basket
            //    .RuleFor(o => o.Item, f => f.PickRandom(fruit))
            //    //A random quantity from 1 to 10
            //    .RuleFor(o => o.Quantity, f => f.Random.Number(1, 10));


            //var obj = testOrders.Generate();

            Validator v = new Validator();
            v.AddRuleFor<Order>("OrderId", f => f.OrderId, Rules.Required(), Rules.Numeric());
            v.AddRuleFor<Order>("Item", f => f.Item, Rules.Required(), Rules.Numeric());
            v.AddRuleFor<Order>("Quantity", f => f.Quantity, "Required", "Required", "GreaterOrEqual 123");






        }
    }
}
