using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTestApp
{
    /// <summary>
    /// Class that represents a customer
    /// </summary>
    public class Customer
    {       
        /// <summary>
        /// Property that contains the unique database identifier for the customer instance
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Property that contains the first name of the customer
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Property that contains the last name of the customer
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Default constructor that initializes the customer object
        /// </summary>

        public string imgUrl { get; set; }
        public Customer()
        {
            this.FirstName = string.Empty;
            this.LastName = string.Empty;
            this.imgUrl = string.Empty;
        }
    }
}

