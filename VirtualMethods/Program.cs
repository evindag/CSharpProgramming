using System;

namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            Console.ReadLine();
        }
    }

    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added");
        }

        public virtual void Delete()
        {
            Console.WriteLine("Deleted");
        }
    }

    class SqlServer:Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by Sql Code");
            base.Add();
        }
    }
}
