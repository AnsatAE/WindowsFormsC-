using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWS1
{
    public static class GradesDB
    {
        public static DataTable GetGrades(int studentId)
        {
            string query = @"
                            SELECT grade_id, subject_id, grade, grade_date
                            FROM Grades
                            WHERE student_id = @studentId";

            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@studentId", studentId);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        public static DataTable GetStudents()
        {
            string query = "SELECT student_id, first_name + ' ' + last_name AS full_name FROM Students";

            using (SqlConnection connection = DatabaseHelper.GetConnection()) // Метод Database.GetConnection() уже реализован
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable; // Возвращаем DataTable с данными студентов
                    }
                }
            }
        }
    }
}
