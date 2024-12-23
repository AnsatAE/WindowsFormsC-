using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWS1
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            string reportType = cmbReportType.SelectedItem.ToString(); // Тип отчета
            DateTime startDate = dtpStartDate.Value; // Начало периода
            DateTime endDate = dtpEndDate.Value; // Конец периода

            DataTable reportData = GenerateReport(reportType, startDate, endDate);

            if (reportData != null)
            {
                dgvReport.DataSource = reportData; // Отображение данных в DataGridView
            }
            else
            {
                MessageBox.Show("Данные для отчета не найдены.", "Отчет", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private DataTable GenerateReport(string reportType, DateTime startDate, DateTime endDate)
        {
            string query = string.Empty;

            // Генерация SQL-запроса на основе типа отчета
            switch (reportType)
            {
                case "Успеваемость":
                    query = @"
                        SELECT s.first_name + ' ' + s.last_name AS StudentName,
                               sub.subject_name AS Subject,
                               g.grade AS Grade,
                               g.grade_date AS Date
                        FROM Grades g
                        JOIN Students s ON g.student_id = s.student_id
                        JOIN Subjects sub ON g.subject_id = sub.subject_id
                        WHERE g.grade_date BETWEEN @startDate AND @endDate";
                    break;

                case "Активность преподавателей":
                    query = @"
                        SELECT t.first_name + ' ' + t.last_name AS TeacherName,
                               COUNT(g.grade_id) AS TotalGradesGiven
                        FROM Grades g
                        JOIN Teachers t ON g.teacher_id = t.teacher_id
                        WHERE g.grade_date BETWEEN @startDate AND @endDate
                        GROUP BY t.first_name, t.last_name";
                    break;

                default:
                    MessageBox.Show("Выберите корректный тип отчета.");
                    return null;
            }

            // Подключение к базе данных
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    return table;
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvReport.DataSource == null)
            {
                MessageBox.Show("Нет данных для экспорта.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                Title = "Сохранить отчет"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                ExportToExcel(filePath, (DataTable)dgvReport.DataSource);
                MessageBox.Show("Отчет успешно сохранен!", "Экспорт", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ExportToExcel(string filePath, DataTable data)
        {
            using (var workbook = new ClosedXML.Excel.XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Отчет");
                for (int i = 0; i < data.Columns.Count; i++)
                {
                    worksheet.Cell(1, i + 1).Value = data.Columns[i].ColumnName; // Заголовки
                }

                for (int i = 0; i < data.Rows.Count; i++)
                {
                    for (int j = 0; j < data.Columns.Count; j++)
                    {
                        worksheet.Cell(i + 2, j + 1).Value = data.Rows[i][j]?.ToString() ?? string.Empty; // Безопасное преобразование в строку

                    }
                }

                workbook.SaveAs(filePath);
            }
        }
    }
}
