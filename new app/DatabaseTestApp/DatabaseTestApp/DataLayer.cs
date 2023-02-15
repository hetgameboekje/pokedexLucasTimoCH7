using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vista.DatabaseConnector;

namespace DatabaseTestApp
{
    public class DataLayer
    {
        public string ConnectionString { get; set; }

        public DataLayer(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        public List<Customer> LoadAllCustomers()
        {
            //List<Customer> data = SqlServerDb.LoadData<Customer, dynamic>("SELECT * FROM Customer", new {}, this.ConnectionString);
            List<Customer> data = MySqlDb.LoadData<Customer, dynamic>("SELECT * FROM Customer", new {}, this.ConnectionString);

            return data;
        }

        public void SaveCustomer(Customer customer)
        {
            //SqlServerDb.SaveData<Customer>("UPDATE Customer SET FirstName = @FirstName, LastName = @LastName WHERE Id = @Id", customer, this.ConnectionString);
            MySqlDb.SaveData<Customer>("UPDATE Customer SET FirstName = @FirstName, LastName = @LastName, imgUrl = @imgUrl WHERE Id = @Id", customer, this.ConnectionString);
        }

        public void AddCustomer(Customer customer)
        {
            //SqlServerDb.SaveData<Customer>("INSERT INTO Customer (FirstName, LastName) VALUES (@FirstName, @LastName)", customer, this.ConnectionString);
            MySqlDb.SaveData<Customer>("INSERT INTO Customer (FirstName, LastName , imgUrl) VALUES (@FirstName, @LastName, @imgUrl)", customer, this.ConnectionString);
        }

        public void DeleteCustomer(Customer customer)
        {
            //SqlServerDb.SaveData<Customer>("DELETE FROM Customer WHERE Id = @Id", customer, this.ConnectionString);
            MySqlDb.SaveData<Customer>("DELETE FROM Customer WHERE Id = @Id", customer, this.ConnectionString);
        }
    }
}
