using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace TestWS1
{
    public partial class Form1 : Form
    {
         public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbLogin.Text.Trim();
            string password = tbPassword.Text.Trim();

            // Проверка заполненности полей
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Вызов метода авторизации
            string role = DatabaseHelper.AuthenticateUser(username, password);

            if (role != null)
            {
                MessageBox.Show($"Пользователь авторизован с ролью: {role}");
                // Открытие главной формы после успешной авторизации
                MainForm mainForm = new MainForm(role);
                mainForm.Show();
                this.Hide(); // Скрыть форму авторизации
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.");
            }
        }
    }
}