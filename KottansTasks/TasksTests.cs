using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CreditCardTests
{
    [TestClass]
    public class TasksTests
    {
        [TestMethod]
        public void GetCreditVendorTest()
        {
            Assert.AreEqual("VISA", KottansTasks.KottansTasks.GetCreditCardVendor("4916 3385 0608 2832"));
            Assert.AreEqual("VISA", KottansTasks.KottansTasks.GetCreditCardVendor("4539 048040151731"));
            Assert.AreEqual("JCB", KottansTasks.KottansTasks.GetCreditCardVendor("3528 000000000000"));
            Assert.AreEqual("JCB", KottansTasks.KottansTasks.GetCreditCardVendor("3529 000000000000"));
            Assert.AreEqual("JCB", KottansTasks.KottansTasks.GetCreditCardVendor("3589 000000000000"));
            Assert.AreEqual("MasterCard", KottansTasks.KottansTasks.GetCreditCardVendor("5442 1796 1969 0834"));
            Assert.AreEqual("MasterCard", KottansTasks.KottansTasks.GetCreditCardVendor("5259474113320034"));
            Assert.AreEqual("MasterCard", KottansTasks.KottansTasks.GetCreditCardVendor("5331113404316994"));
            Assert.AreEqual("Maestro", KottansTasks.KottansTasks.GetCreditCardVendor("5893000000000000"));
            Assert.AreEqual("Maestro", KottansTasks.KottansTasks.GetCreditCardVendor("6763000000000000"));
            Assert.AreEqual("Maestro", KottansTasks.KottansTasks.GetCreditCardVendor("5020000000000000"));
            Assert.AreEqual("AMERICAN EXPRESS", KottansTasks.KottansTasks.GetCreditCardVendor("345936346788903"));
            Assert.AreEqual("AMERICAN EXPRESS", KottansTasks.KottansTasks.GetCreditCardVendor("371095063560404"));
        }

        [TestMethod]
        public void IsCardNumberValid()
        {
            Assert.AreEqual(true, KottansTasks.KottansTasks.IsCreditCardNumberValid("4532 2271 9926 9513"));
            Assert.AreEqual(true, KottansTasks.KottansTasks.IsCreditCardNumberValid("5540 8724 4673 5415"));
            Assert.AreEqual(true, KottansTasks.KottansTasks.IsCreditCardNumberValid("6011976648160021"));
            Assert.AreEqual(true, KottansTasks.KottansTasks.IsCreditCardNumberValid("373471048530507"));
            Assert.AreEqual(true,KottansTasks.KottansTasks.IsCreditCardNumberValid("5168 7572 0868 6966"));
            Assert.AreEqual(false, KottansTasks.KottansTasks.IsCreditCardNumberValid("516833540 7572 0868 6966"));
            Assert.AreEqual(false, KottansTasks.KottansTasks.IsCreditCardNumberValid("5168500ssssas0 7592 0868 6966"));


        }

        [TestMethod]
        public void GenerateNextNumber()
        {
            Assert.AreEqual(3, KottansTasks.KottansTasks.GenerateNextCreditCardNumber("4532 2271 9926 951"));
            Assert.AreEqual(5, KottansTasks.KottansTasks.GenerateNextCreditCardNumber("554087244673541"));
            Assert.AreEqual(1,KottansTasks.KottansTasks.GenerateNextCreditCardNumber("601197664816002"));
            Assert.AreEqual(7,KottansTasks.KottansTasks.GenerateNextCreditCardNumber("37347104853050"));
            Assert.AreEqual(6, KottansTasks.KottansTasks.GenerateNextCreditCardNumber("5168 7572 0868 696"));

        }
    }
}
