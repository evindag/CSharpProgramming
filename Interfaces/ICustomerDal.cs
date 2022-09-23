using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Added");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Updated");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
