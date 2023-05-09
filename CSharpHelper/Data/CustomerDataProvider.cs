using CSharpHelper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHelper.Data
{
    public class CustomerDataProvider : ICustomerDataProvider
    {
        public IEnumerable<Customer> LoadAsync()
        {
            Customer[] customers;
            customers = new Customer[]
            {
                new Customer() {CustID=1, FirstName="Ansh", LastName="Sinha", IsDeveloper=false },
                new Customer() {CustID=2, FirstName="Ben", LastName="Aflec", IsDeveloper=false },
                new Customer() {CustID=3, FirstName="Kenne", LastName="soon", IsDeveloper=false },
                new Customer() {CustID=4, FirstName="Sarthak", LastName="Mishra", IsDeveloper=true },
                new Customer() {CustID=5, FirstName="Sophie", LastName="Staalwart", IsDeveloper=true },
            };
            return customers;
        }
    }
}
