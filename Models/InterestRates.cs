using System.Collections.Generic;

namespace SEBInterestRate.Models
{
    public class Interest
    {
        public int Id { get; set; }
        public string HowTo { get; set; }
        public string Line { get; set; }
        public string Platform { get; set; }

    }

    public class Customer
    {
        public Customer()
        {
            _accounts = new List<Account>();
        }

        public ulong id { get; set; }
        public string name { get; set; }

        public List<Account> Accounts
        {
            get { return _accounts; }
            set { _accounts = value; }
        }

        private List<Account> _accounts;
    }

    public class Account
    {
        public float Amount { get; set; }
        public string BaseRateCote { get; set; }
        public float Margin { get; set; }
        public int AgreementDuration { get; set; }
    }
}