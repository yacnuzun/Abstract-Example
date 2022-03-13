using CoffeStar.Abstract;
using CoffeStar.Entites;
using CoffeStar.MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeStar.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client=new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityId), customer.Name.ToUpper(), customer.Surname.ToUpper(), 
                customer.DateOfBirth.Year);
        }
    }
}
