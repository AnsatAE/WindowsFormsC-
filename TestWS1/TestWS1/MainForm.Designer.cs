namespace TestWS1
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mtrBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.controlGroups = new System.Windows.Forms.Button();
            this.controlStudents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "Управление пользователями";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.controlUsers_Click);
            // 
            // mtrBtn
            // 
            this.mtrBtn.Location = new System.Drawing.Point(263, 155);
            this.mtrBtn.Name = "mtrBtn";
            this.mtrBtn.Size = new System.Drawing.Size(160, 126);
            this.mtrBtn.TabIndex = 1;
            this.mtrBtn.Text = "Мониторинг успеваемости";
            this.mtrBtn.UseVisualStyleBackColor = true;
            this.mtrBtn.Click += new System.EventHandler(this.mtrBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(429, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 126);
            this.button3.TabIndex = 1;
            this.button3.Text = "Генерация отчетов";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(595, 155);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 126);
            this.button4.TabIndex = 1;
            this.button4.Text = "Сообщения и уведомления";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // controlGroups
            // 
            this.controlGroups.Location = new System.Drawing.Point(36, 198);
            this.controlGroups.Name = "controlGroups";
            this.controlGroups.Size = new System.Drawing.Size(160, 56);
            this.controlGroups.TabIndex = 2;
            this.controlGroups.Text = "Управление группами";
            this.controlGroups.UseVisualStyleBackColor = true;
            this.controlGroups.Click += new System.EventHandler(this.controlGroups_Click);
            // 
            // controlStudents
            // 
            this.controlStudents.Location = new System.Drawing.Point(36, 260);
            this.controlStudents.Name = "controlStudents";
            this.controlStudents.Size = new System.Drawing.Size(160, 58);
            this.controlStudents.TabIndex = 3;
            this.controlStudents.Text = "Управление студентами";
            this.controlStudents.UseVisualStyleBackColor = true;
            this.controlStudents.Click += new System.EventHandler(this.controlStudents_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.controlStudents);
            this.Controls.Add(this.controlGroups);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.mtrBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button1;
        private Button mtrBtn;
        private Button button3;
        private Button button4;
        private Button controlGroups;
        private Button controlStudents;
    }
}