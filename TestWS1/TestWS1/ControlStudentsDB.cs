using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWS1
{
    public static class ControlStudentsDB
    {

        public static DataTable GetStudents()
        {
            string query = @"
                SELECT s.student_id, s.first_name, s.last_name, g.group_name
                FROM Students s
                LEFT JOIN Groups g ON s.group_id = g.group_id";

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

        public static DataTable GetGroups()
        {
            string query = "SELECT group_id, group_name FROM Groups";

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

        public static void AddStudent(string first_name, string last_name, int group_id)
        {
            string query = @"
                        INSERT INTO Students (first_name, last_name, group_id)
                        VALUES (@firstName, @lastName, @groupId)";

            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@firstName", first_name);
                    command.Parameters.AddWithValue("@lastName", last_name);
                    command.Parameters.AddWithValue("@groupId", group_id);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateStudent(int studentId, string first_name, string last_name, int group_id)
        {
            string query = @"
                            UPDATE Students 
                            SET first_name = @firstName, last_name = @last_name, group_id = @group_id
                            WHERE student_id = @studentId";

            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@studentId", studentId);
                    command.Parameters.AddWithValue("@firstName", first_name);
                    command.Parameters.AddWithValue("@last_name", last_name);
                    command.Parameters.AddWithValue("@group_id", group_id);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteStudent(int studentId)
        {
            string query = "DELETE FROM Students WHERE student_id = @studentId";

            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@studentId", studentId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }





    }
}
