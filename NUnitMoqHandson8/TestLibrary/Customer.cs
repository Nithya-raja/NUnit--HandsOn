using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{

        public class Customer
        {
            IMailSender _mailSender;

            public Customer(IMailSender mailSender)
            {
                this._mailSender = mailSender;
            }

            public bool SendMailToCustomer()
            {
                _mailSender.SendMail("abcd@gmal.com", "Hallo User");
                return true;
            }
        }
    }
