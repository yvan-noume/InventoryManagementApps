using InventoryManagementApplicationLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using InventoryManagementApplicationLayer.API;

namespace InventoryManagementDataAccessLayer
{
    public class CustomerDataOperations: ICustomerServices
    {
        static string connectionString = "Data Source=DESKTOP-52GF5V4\\SQLEXPRESS;Initial Catalog=InventoryManagement; Integrated Security=True";

        public bool CreateCustomer(CustomerDTO customer)
        {
            string insertQuery = "INSERT INTO Customer (FirstName, LastName, Email, PhoneNumber, Addrss, DateMembership) " +
                     "VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @Addrss, @DateMembership)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    // Set parameter values
                    command.Parameters.AddWithValue("@FirstName", customer.FirstName);
                    command.Parameters.AddWithValue("@LastName", customer.LastName);
                    command.Parameters.AddWithValue("@Email", customer.Email);
                    command.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);
                    command.Parameters.AddWithValue("@Addrss", customer.Address);
                    command.Parameters.AddWithValue("@DateMembership", customer.DateMembership);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public bool DeleteCustomer(CustomerDTO customer)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = $"DELETE FROM Customer WHERE Email = '{customer.Email}'";
                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public bool UpdateCustomer(CustomerDTO customer)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string updateQuery = $"UPDATE Customer SET FirstName = @FirstName, LastName = @LastName, " +
                                     $"PhoneNumber = @PhoneNumber, Addrss = @Address " +
                                     $"WHERE Email = @Email";
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    // Set parameter values
                    command.Parameters.AddWithValue("@FirstName", customer.FirstName);
                    command.Parameters.AddWithValue("@LastName", customer.LastName);
                    command.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);
                    command.Parameters.AddWithValue("@Address", customer.Address);
                    command.Parameters.AddWithValue("@Email", customer.Email);

                    // Execute the UPDATE query
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public List<CustomerDTO> GetAllCustomers()
        {
            List<CustomerDTO> customers = new List<CustomerDTO>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM Customer";
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CustomerDTO customer = new CustomerDTO
                            {
                                FirstName = Convert.ToString(reader["FirstName"]),
                                LastName = Convert.ToString(reader["LastName"]),
                                Email = Convert.ToString(reader["Email"]),
                                PhoneNumber = Convert.ToInt32(reader["PhoneNumber"]),
                                Address = Convert.ToString(reader["Addrss"]),
                                DateMembership = Convert.ToDateTime(reader["DateMembership"])
                            };

                            customers.Add(customer);
                        }
                    }
                }
            }

            return customers;

        }

        public async Task<List<CustomerDTO>> GetAllCustomersAsync()
        {
            return await Task.Run(() => GetAllCustomers());
        }
    }
}
