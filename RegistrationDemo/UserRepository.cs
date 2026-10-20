using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System.Configuration;

namespace RegistrationDemo
{
    public class UserRepository
    {
        private readonly string _connectionString =
            ConfigurationManager.ConnectionStrings["RegistrationDemoDB"].ConnectionString;

        public User? GetByEmail(string email)
        {
            const string sql = "SELECT UserId, FullName, PasswordHash FROM dbo.Users WHERE Email = @Email;";
            using var conn = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Email", email);
            conn.Open();
            using var reader = cmd.ExecuteReader();
            if (!reader.Read())
                return null;

            return new User
            {
                UserId = (int)reader["UserId"],
                FullName = (string)reader["FullName"],
                PasswordHash = (string)reader["PasswordHash"]
            };
        }
    }
}