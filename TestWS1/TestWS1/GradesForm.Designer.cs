namespace TestWS1
{
    partial class GradesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewGrades = new System.Windows.Forms.DataGridView();
            this.comboStudents = new System.Windows.Forms.ComboBox();
            this.lblAverageGrade = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGrades
            // 
            this.dataGridViewGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrades.Location = new System.Drawing.Point(12, 55);
            this.dataGridViewGrades.Name = "dataGridViewGrades";
            this.dataGridViewGrades.RowHeadersWidth = 51;
            this.dataGridViewGrades.RowTemplate.Height = 29;
            this.dataGridViewGrades.Size = new System.Drawing.Size(776, 373);
            this.dataGridViewGrades.TabIndex = 0;
            // 
            // comboStudents
            // 
            this.comboStudents.FormattingEnabled = true;
            this.comboStudents.Location = new System.Drawing.Point(12, 12);
            this.comboStudents.Name = "comboStudents";
            this.comboStudents.Size = new System.Drawing.Size(255, 28);
            this.comboStudents.TabIndex = 1;
            this.comboStudents.Text = "Выберите студента";
            this.comboStudents.SelectedIndexChanged += new System.EventHandler(this.comboStudents_SelectedIndexChanged);
            // 
            // lblAverageGrade
            // 
            this.lblAverageGrade.AutoSize = true;
            this.lblAverageGrade.Location = new System.Drawing.Point(305, 15);
            this.lblAverageGrade.Name = "lblAverageGrade";
            this.lblAverageGrade.Size = new System.Drawing.Size(152, 20);
            this.lblAverageGrade.TabIndex = 2;
            this.lblAverageGrade.Text = "Средняя оценка:  0.0";
            // 
            // GradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.lblAverageGrade);
            this.Controls.Add(this.comboStudents);
            this.Controls.Add(this.dataGridViewGrades);
            this.Name = "GradesForm";
            this.Text = "GradesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewGrades;
        private ComboBox comboStudents;
        private Label lblAverageGrade;
    }
}