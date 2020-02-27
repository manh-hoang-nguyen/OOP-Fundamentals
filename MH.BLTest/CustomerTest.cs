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
        [TestMethod]
        public void StaticTest()
        {
            Customer customer = new Customer();
            Customer.InstanceCount += 1;
            customer.FirstName = "Nguyen";

            Customer customer1 = new Customer();
            Customer.InstanceCount += 1;

            Assert.AreEqual(2, Customer.InstanceCount);
        }
        [TestMethod]
        public void ValidateValid()
        {
            Customer customer = new Customer
            {
                LastName="Baggin",
                EmailAddress ="test@gmail.com"
            };

            var actual = customer.Validate();

            var expected = true;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateMissingLastName()
        {
            Customer customer = new Customer
            {
                
                EmailAddress = "test@gmail.com"
            };
            
            var actual = customer.Validate();

            var expected = false;

            Assert.AreEqual(expected, actual);
        }
    }
}
