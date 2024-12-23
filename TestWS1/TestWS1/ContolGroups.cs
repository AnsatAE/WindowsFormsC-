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
    public partial class ContolGroups : Form
    {
        public ContolGroups()
        {
            InitializeComponent();
            LoadGroups();
            LoadCurators();
        }

        private void LoadGroups()
        {
            DataTable groups = controlGroupsDB.GetGroups();
            dataGridViewGroups.DataSource = groups;
        }

        private void LoadCurators()
        {
            DataTable curators = controlGroupsDB.GetCurators();
            comboCurators.DataSource = curators;
            comboCurators.DisplayMember = "username"; // Отображаемое имя
            comboCurators.ValueMember = "user_id"; // Значение для использования
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string groupName = txtGroupName.Text;
            int curatorId = Convert.ToInt32(comboCurators.SelectedValue);

            controlGroupsDB.AddGroup(groupName, curatorId);
            MessageBox.Show("Группа добавлена.");
            LoadGroups(); // Обновить таблицу
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewGroups.SelectedRows.Count > 0)
            {
                int groupId = Convert.ToInt32(dataGridViewGroups.SelectedRows[0].Cells["group_id"].Value);
                string groupName = txtGroupName.Text;
                int curatorId = Convert.ToInt32(comboCurators.SelectedValue);

                controlGroupsDB.UpdateGroup(groupId, groupName, curatorId);
                MessageBox.Show("Группа обновлена.");
                LoadGroups(); // Обновить таблицу
            }
            else
            {
                MessageBox.Show("Выберите группу для редактирования.");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewGroups.SelectedRows.Count > 0)
            {
                int groupId = Convert.ToInt32(dataGridViewGroups.SelectedRows[0].Cells["group_id"].Value);

                controlGroupsDB.DeleteGroup(groupId);
                MessageBox.Show("Группа удалена.");
                LoadGroups(); // Обновить таблицу
            }
            else
            {
                MessageBox.Show("Выберите группу для удаления.");
            }
        }
    }
}
