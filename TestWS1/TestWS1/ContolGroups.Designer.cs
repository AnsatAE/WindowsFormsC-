namespace TestWS1
{
    partial class ContolGroups
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
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridViewGroups = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.comboCurators = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(701, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Группа";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(848, 225);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(207, 185);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "Редактировать: \nНужно сначала выбрать строку которую вы хотите редактировать и вн" +
    "ести новые данные в поля для ввода и нажать кнопку редактировать чтобы внести но" +
    "вые данные выбранной строке";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(502, 400);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(166, 38);
            this.deleteBtn.TabIndex = 13;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(864, 164);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(166, 38);
            this.editBtn.TabIndex = 14;
            this.editBtn.Text = " Редактировать";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(701, 56);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(329, 27);
            this.txtGroupName.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(701, 165);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(138, 37);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridViewGroups
            // 
            this.dataGridViewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroups.Location = new System.Drawing.Point(27, 12);
            this.dataGridViewGroups.Name = "dataGridViewGroups";
            this.dataGridViewGroups.RowHeadersWidth = 51;
            this.dataGridViewGroups.RowTemplate.Height = 29;
            this.dataGridViewGroups.Size = new System.Drawing.Size(641, 361);
            this.dataGridViewGroups.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(701, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Куратор";
            // 
            // comboCurators
            // 
            this.comboCurators.FormattingEnabled = true;
            this.comboCurators.Items.AddRange(new object[] {
            "teacher",
            "admin",
            "student",
            "director"});
            this.comboCurators.Location = new System.Drawing.Point(701, 111);
            this.comboCurators.Name = "comboCurators";
            this.comboCurators.Size = new System.Drawing.Size(329, 28);
            this.comboCurators.TabIndex = 12;
            // 
            // ContolGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 456);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.comboCurators);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridViewGroups);
            this.Name = "ContolGroups";
            this.Text = "ContolGroups";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private RichTextBox richTextBox1;
        private Button deleteBtn;
        private Button editBtn;
        private TextBox txtGroupName;
        private Button btnAdd;
        private DataGridView dataGridViewGroups;
        private Label label3;
        private ComboBox comboCurators;
    }
}