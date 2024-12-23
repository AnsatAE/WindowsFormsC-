using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWS1
{
    public partial class MainForm : Form
    {
        private string userRole;

        public MainForm(string role)
        {
            InitializeComponent();
            userRole = role; // Сохраняем роль

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            // Используем роль для управления интерфейсом
            if (userRole == "admin")
            {
                label1.Text = "Добро пожаловать, администратор!";
                // Дать доступ к функциям управления
            }
            else if (userRole == "student")
            {
                label1.Text = "Добро пожаловать, студент!";
                // Ограничить доступ
            }
            else if (userRole == "teacher")
            {
                label1.Text = "Добро пожаловать, учитель!";
            }
        }

        private void controlUsers_Click(object sender, EventArgs e)
        {
            ControlForm controlForm = new ControlForm();
            controlForm.Show();
        }

        private void controlGroups_Click(object sender, EventArgs e)
        {
            ContolGroups contolGroups = new ContolGroups();
            contolGroups.Show();
        }

        private void controlStudents_Click(object sender, EventArgs e)
        {
            ControlStudents contolStudents = new ControlStudents();
            contolStudents.Show();
        }

        private void mtrBtn_Click(object sender, EventArgs e)
        {
            GradesForm gradeForm = new GradesForm();
            gradeForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
