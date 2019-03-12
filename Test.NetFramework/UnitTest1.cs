using Microsoft.VisualStudio.TestTools.UnitTesting;
using QPE.Validator;

namespace Test.NetFramework
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var x = Validator.Validate("45646546.54", Rules.As(typeof(double)));
        }
    }
}
