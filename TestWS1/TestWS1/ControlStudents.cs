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
    public partial class ControlStudents : Form
    {
        public ControlStudents()
        {
            InitializeComponent();
            LoadStudents();
            LoadGroups();
        }
        private void LoadStudents()
        {
            DataTable students = ControlStudentsDB.GetStudents();
            dataGridViewStudents.DataSource = students;
        }

        private void LoadGroups()
        {
            DataTable groups = ControlStudentsDB.GetGroups();
            comboGroups.DataSource = groups;
            comboGroups.DisplayMember = "group_name"; // Отображаемое имя
            comboGroups.ValueMember = "group_id"; // Значение для использования
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string firstNm = firstName.Text;
            string lastNm = lastName.Text;
            int groupId = Convert.ToInt32(comboGroups.SelectedValue);

            ControlStudentsDB.AddStudent(firstNm, lastNm, groupId);
            MessageBox.Show("Студент добавлен.");
            LoadStudents();

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                int studentId = Convert.ToInt32(dataGridViewStudents.SelectedRows[0].Cells["student_id"].Value);
                string firstNm = firstName.Text;
                string lastNm = lastName.Text;
                int groupId = Convert.ToInt32(comboGroups.SelectedValue);

                ControlStudentsDB.UpdateStudent(studentId, firstNm, lastNm, groupId);
                MessageBox.Show("Студент обновлен.");
                LoadStudents();
            }
            else
            {
                MessageBox.Show("Выберите студента для редактирования.");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                int studentId = Convert.ToInt32(dataGridViewStudents.SelectedRows[0].Cells["student_id"].Value);

                ControlStudentsDB.DeleteStudent(studentId);
                MessageBox.Show("Студент удален.");
                LoadStudents();
            }
            else
            {
                MessageBox.Show("Выберите студента для удаления.");
            }
        }
    }
}
