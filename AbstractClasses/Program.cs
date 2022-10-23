using System;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database database = new SqlServer();
            database.Delete();
            database.Add();
        }
    }
    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added");
        }
        public abstract void Delete();
    }
    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Sql");     
        }
    }
    
}
