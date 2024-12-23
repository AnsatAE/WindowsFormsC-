using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWS1
{
    public static class controlGroupsDB
    {
        public static DataTable GetGroups()
        {
            string query = @"
                SELECT g.group_id, g.group_name, u.username AS curator_name
                FROM Groups g
                LEFT JOIN Users u ON g.curator_id = u.user_id";

            using (SqlConnection connection = DatabaseHelper.GetConnection())
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

        public static void AddGroup(string groupName, int curatorId)
        {
            string query = "INSERT INTO Groups (group_name, curator_id) VALUES (@groupName, @curatorId)";
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@groupName", groupName);
                    command.Parameters.AddWithValue("@curatorId", curatorId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateGroup(int groupId, string groupName, int curatorId)
        {
            string query = "UPDATE Groups SET group_name = @groupName, curator_id = @curatorId WHERE group_id = @groupId";
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@groupId", groupId);
                    command.Parameters.AddWithValue("@groupName", groupName);
                    command.Parameters.AddWithValue("@curatorId", curatorId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteGroup(int groupId)
        {
            string query = "DELETE FROM Groups WHERE group_id = @groupId";
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@groupId", groupId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static DataTable GetCurators()
        {
            string query = "SELECT user_id, username FROM Users WHERE role = 'Teacher'";
            using (SqlConnection connection = DatabaseHelper.GetConnection())
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


    }
}
