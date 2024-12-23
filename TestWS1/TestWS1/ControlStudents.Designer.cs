namespace TestWS1
{
    partial class ControlStudents
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
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.comboGroups = new System.Windows.Forms.ComboBox();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(25, 12);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.RowTemplate.Height = 29;
            this.dataGridViewStudents.Size = new System.Drawing.Size(567, 317);
            this.dataGridViewStudents.TabIndex = 0;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(608, 214);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(151, 29);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(608, 36);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(378, 27);
            this.firstName.TabIndex = 2;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(608, 89);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(378, 27);
            this.lastName.TabIndex = 3;
            // 
            // comboGroups
            // 
            this.comboGroups.FormattingEnabled = true;
            this.comboGroups.Location = new System.Drawing.Point(608, 154);
            this.comboGroups.Name = "comboGroups";
            this.comboGroups.Size = new System.Drawing.Size(378, 28);
            this.comboGroups.TabIndex = 4;
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(852, 214);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(134, 29);
            this.editBtn.TabIndex = 5;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(498, 354);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(94, 29);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // ControlStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 450);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.comboGroups);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dataGridViewStudents);
            this.Name = "ControlStudents";
            this.Text = "ControlStudents";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewStudents;
        private Button addBtn;
        private TextBox firstName;
        private TextBox lastName;
        private ComboBox comboGroups;
        private Button editBtn;
        private Button deleteBtn;
    }
}