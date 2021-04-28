using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using TestLibrary;

namespace Customer
{
    [TestFixture]
    public class Tests
    {
        [TestCase]
        public void TestCase_SMTPService()
        {
            var smtpClient = new Mock<IMailSender>();
            smtpClient.Setup(x => x.SendMail("CTS20DN013@gmail.com", "Welcome User")).Returns(true);
            TestLibrary.Customer component = new TestLibrary.Customer(smtpClient.Object);
            Assert.AreEqual(true, component.SendMailToCustomer());
        }
    }
}
