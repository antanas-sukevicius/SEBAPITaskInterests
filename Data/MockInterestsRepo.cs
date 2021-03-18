using System.Collections.Generic;
using SEBInterestRate.Models;

namespace SEBInterestRate.Data
{
    public class MockInterestRepo : ICustomersRepo
    {
        public IEnumerable<Customer> GetAppCustomers()
        {
            var customers = new List<Customer>{
                new Customer{name="Goras Trusevičius",id=67812203006, Accounts={
                    new Account{Amount=12000, BaseRateCote="VILIBOR3m",Margin=1.6f,AgreementDuration=60}
                }},
                new Customer{name="Dange Kulkavičiutė",id=78706151287, Accounts={
                    new Account{Amount=8000, BaseRateCote="VILIBOR1y",Margin=2.2f,AgreementDuration=36},
                    new Account{Amount=1000, BaseRateCote="VILIBOR6m",Margin=1.85f,AgreementDuration=24}
                }}
            };

            var interests = new List<Interest>
            {
                new Interest{Id=0, HowTo="do it", Line="for sure", Platform ="my platform"},
                new Interest{Id=0, HowTo="make it", Line="i am sure", Platform ="your platform"},
                new Interest{Id=0, HowTo="finish it", Line="Good sure", Platform ="his platform"}
            };

            return customers;
        }

        public Customer GetInteresById(int id)
        {
            return new  Customer{name="Goras Trusevičius",id=67812203006, Accounts={
                    new Account{Amount=12000, BaseRateCote="VILIBOR3m",Margin=1.6f,AgreementDuration=60}
                }};
        }
    }
}