using CoffeStar.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeStar.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
