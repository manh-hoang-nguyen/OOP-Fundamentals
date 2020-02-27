namespace MH.BLTest
{
    using MH.BL;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CustomerTest
    {
        /// <summary>
        /// The FullNameTestValid
        /// </summary>
        [TestMethod]
        public void FullNameTestValid()
        {
            Customer customer = new Customer();
            customer.FirstName = "Nguyen";
            customer.LastName = "Hoang";

            string expected = "Hoang, Nguyen";

            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            Customer customer = new Customer();
            customer.FirstName = "Nguyen";
             

            string expected = "Nguyen";

            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }
    }
}
