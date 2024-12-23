using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWS1
{
    public partial class GradesForm : Form
    {
        public GradesForm()
        {
            InitializeComponent();
            LoadStudents();
        }
        private void LoadStudents()
        {
            DataTable students = GradesDB.GetStudents(); // Предполагается, что метод для получения студентов уже реализован
            comboStudents.DataSource = students;
            comboStudents.DisplayMember = "full_name";  // Отображаемое имя
            comboStudents.ValueMember = "student_id";  // Идентификатор
        }
        private void LoadGrades(int studentId)
        {
            DataTable grades = GradesDB.GetGrades(studentId);
            dataGridViewGrades.DataSource = grades;
        }

        private void comboStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboStudents.SelectedValue is int studentId)
            {
                LoadGrades(studentId);
                CalculateAverageGrade(studentId);
            }
        }

        private void CalculateAverageGrade(int studentId)
        {
            DataTable grades = GradesDB.GetGrades(studentId);

            if (grades.Rows.Count > 0)
            {
                decimal total = grades.AsEnumerable().Sum(row => row.Field<decimal>("grade"));
                decimal average = total / grades.Rows.Count;
                lblAverageGrade.Text = $"Средняя оценка: {average:F2}";
            }
            else
            {
                lblAverageGrade.Text = "Нет данных об оценках.";
            }
        }

    }
}
