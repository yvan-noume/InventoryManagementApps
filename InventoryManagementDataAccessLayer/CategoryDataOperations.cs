using InventoryManagementApplicationLayer;
using InventoryManagementApplicationLayer.API;
using InventoryManagementApplicationLayer.Data_Transfer_Objects;
using InventoryManagementDomainLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementDataAccessLayer
{
    public class CategoryDataOperations : ICategoryServices
    {
        static string connectionString = "Data Source=DESKTOP-52GF5V4\\SQLEXPRESS;Initial Catalog=InventoryManagement; Integrated Security=True";

        public bool CreateCategory(CategoryDTO category)
        {
            string insertQuery = "INSERT INTO Category (Name, Description) " +
         "VALUES (@Name, @Description)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    // Set parameter values
                    command.Parameters.AddWithValue("@Name", category.Name);
                    command.Parameters.AddWithValue("@Description", category.Description);


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

        public bool DeleteCategory(CategoryDTO category)
        {
            throw new NotImplementedException();
        }

        public List<CategoryDTO> GetAllCategories()
        {
            List<CategoryDTO> customers = new List<CategoryDTO>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM Category";
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CategoryDTO customer = new CategoryDTO
                            {
                                Name = Convert.ToString(reader["Name"]),
                                Description = Convert.ToString(reader["Description"]),
                            };

                            customers.Add(customer);
                        }
                    }
                }
            }

            return customers;
        }

        public List<ProductDTO> GetAllProducts(CategoryDTO category)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCategory(CategoryDTO category)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string updateQuery = $"UPDATE Category SET Name = @Name, Description = @Description " +
                                     $"WHERE Name = @Name";
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    // Set parameter values
                    command.Parameters.AddWithValue("@Name", category.Name);
                    command.Parameters.AddWithValue("@Description", category.Description);

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
    }
}
