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

            // �������� ������������� �����
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("������� ����� � ������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ����� ������ �����������
            string role = DatabaseHelper.AuthenticateUser(username, password);

            if (role != null)
            {
                MessageBox.Show($"������������ ����������� � �����: {role}");
                // �������� ������� ����� ����� �������� �����������
                MainForm mainForm = new MainForm(role);
                mainForm.Show();
                this.Hide(); // ������ ����� �����������
            }
            else
            {
                MessageBox.Show("�������� ����� ��� ������.");
            }
        }
    }
}