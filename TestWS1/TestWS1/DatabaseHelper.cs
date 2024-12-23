using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TestWS1
{
    public static class DatabaseHelper
    {
        // Строка подключения к базе данных
        private static string connectionString = "Server=admin;Database=dnevnik;Trusted_Connection=True;";

        // Метод для получения подключения
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Метод для проверки подключения
        public static bool TestConnection()
        {
            using (SqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    return true; // Успешное подключение
                }
                catch (Exception)
                {
                    return false; // Ошибка подключения
                }
            }
        }

        public static string AuthenticateUser(string username, string password)
        {
            // Запрос для извлечения роли пользователя
            string query = "SELECT role FROM Users WHERE username = @username AND password = @password";

            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Добавляем параметры для предотвращения SQL-инъекций
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    connection.Open();

                    // Выполняем запрос
                    object result = command.ExecuteScalar();

                    // Проверяем результат
                    if (result != null)
                    {
                        return result.ToString(); // Возвращаем роль пользователя
                    }
                    else
                    {
                        return null; // Если пользователь не найден, возвращаем null
                    }
                }
            }
        }

        public static DataTable GetUsers()
        {
            string query = "SELECT user_id, username, password, role FROM Users";
            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        public static void AddUser(string username, string password, string role)
        {
            string query = "INSERT INTO Users (username, password, role) VALUES (@username, @password, @role)";
            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@role", role);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateUser(int userId, string username, string password, string role)
        {
            string query = "UPDATE Users SET username = @username, password = @password, role = @role WHERE user_id = @userId";
            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@role", role);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteUser(int userId)
        {
            string query = "DELETE FROM Users WHERE user_id = @userId";
            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
