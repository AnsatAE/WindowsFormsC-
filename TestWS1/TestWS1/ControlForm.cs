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
    public partial class ControlForm : Form
    {
        public ControlForm()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = comboRole.SelectedItem.ToString();

            DatabaseHelper.AddUser(username, password, role);
            MessageBox.Show("Пользователь добавлен.");
            LoadUsers(); // Обновить таблицу
        }

        private void LoadUsers()
        {
            DataTable users = DatabaseHelper.GetUsers();
            dataGridViewUsers.DataSource = users;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells["user_id"].Value);
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string role = comboRole.SelectedItem.ToString();

                DatabaseHelper.UpdateUser(userId, username, password, role);
                MessageBox.Show("Пользователь обновлен.");
                LoadUsers(); // Обновить таблицу
            }
            else
            {
                MessageBox.Show("Выберите пользователя для редактирования.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells["user_id"].Value);

                DatabaseHelper.DeleteUser(userId);
                MessageBox.Show("Пользователь удален.");
                LoadUsers(); // Обновить таблицу
            }
            else
            {
                MessageBox.Show("Выберите пользователя для удаления.");
            }
        }
    }
}
