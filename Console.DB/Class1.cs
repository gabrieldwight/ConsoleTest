using System;
using System.Data.SqlClient;

namespace Console.DB
{
    public class Class1 : IDataInterface
    {
        private SqlConnection cnn;

        // you can instatiate the connection in the class constructor (optional)
        public Class1()
        {
        }
        // Implemetation of the database CRUD methods on your tables
        public void insert(string query)
        {
            throw new NotImplementedException();
        }

        public void select(string query)
        {
            throw new NotImplementedException();
        }

        public void update(string query)
        {
            throw new NotImplementedException();
        }

        public void connect()
        {
            string connetionString;
            connetionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EFOnlineShopping;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            System.Console.WriteLine("Connection Open  !");
            cnn.Close();
        }

        public string display()
        {
            return "Hello World";
        }
    }
}
