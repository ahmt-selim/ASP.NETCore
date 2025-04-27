using System;

namespace Interfaces.Models
{
    public class MsSqlOperations : Test, ISqlOperations, ITestInterface
    {
        public void Connection()
        {
            Console.WriteLine("MsSql için bağlantı sağlandı.");
        }

        public bool Insert(Products product)
        {
            return true;
        }
    }
    public class MySqlOperation : ISqlOperations
    {
        public void Connection()
        {
            Console.WriteLine("Mysql bağlantısı sağlandı.");
        }

        public bool Insert(Products product)
        {
            return true;
        }
    }
    public interface ISqlOperations
    {
        void Connection();
        bool Insert(Products product);
    }
    public interface ITestInterface
    {

    }
    public class Test
    {

    }
}
