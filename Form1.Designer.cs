namespace selhozWk
{
    partial class mainPage
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.showTable = new System.Windows.Forms.Button();
            this.createJournal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rabochiyCm = new System.Windows.Forms.ComboBox();
            this.rasteniyeCm = new System.Windows.Forms.ComboBox();
            this.ugodiyeCm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.zasevEdit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // showTable
            // 
            this.showTable.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showTable.Location = new System.Drawing.Point(264, 12);
            this.showTable.Name = "showTable";
            this.showTable.Size = new System.Drawing.Size(507, 257);
            this.showTable.TabIndex = 0;
            this.showTable.Text = "Просмотр или редактирование данных";
            this.showTable.UseVisualStyleBackColor = true;
            this.showTable.Click += new System.EventHandler(this.showTable_Click);
            // 
            // createJournal
            // 
            this.createJournal.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createJournal.Location = new System.Drawing.Point(13, 12);
            this.createJournal.Name = "createJournal";
            this.createJournal.Size = new System.Drawing.Size(245, 257);
            this.createJournal.TabIndex = 2;
            this.createJournal.Text = "Создать запись в журнале";
            this.createJournal.UseVisualStyleBackColor = true;
            this.createJournal.Click += new System.EventHandler(this.createJournal_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.datePicker);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.zasevEdit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ugodiyeCm);
            this.panel1.Controls.Add(this.rasteniyeCm);
            this.panel1.Controls.Add(this.rabochiyCm);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 256);
            this.panel1.TabIndex = 3;
            // 
            // rabochiyCm
            // 
            this.rabochiyCm.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.rabochiyCm.FormattingEnabled = true;
            this.rabochiyCm.Location = new System.Drawing.Point(3, 39);
            this.rabochiyCm.Name = "rabochiyCm";
            this.rabochiyCm.Size = new System.Drawing.Size(209, 45);
            this.rabochiyCm.TabIndex = 0;
            // 
            // rasteniyeCm
            // 
            this.rasteniyeCm.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.rasteniyeCm.FormattingEnabled = true;
            this.rasteniyeCm.Location = new System.Drawing.Point(280, 39);
            this.rasteniyeCm.Name = "rasteniyeCm";
            this.rasteniyeCm.Size = new System.Drawing.Size(209, 45);
            this.rasteniyeCm.TabIndex = 1;
            // 
            // ugodiyeCm
            // 
            this.ugodiyeCm.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.ugodiyeCm.FormattingEnabled = true;
            this.ugodiyeCm.Location = new System.Drawing.Point(549, 39);
            this.ugodiyeCm.Name = "ugodiyeCm";
            this.ugodiyeCm.Size = new System.Drawing.Size(209, 45);
            this.ugodiyeCm.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ответственный";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(335, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Растение";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(600, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Угодие";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(215, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дата";
            // 
            // zasevEdit
            // 
            this.zasevEdit.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.zasevEdit.Location = new System.Drawing.Point(417, 142);
            this.zasevEdit.Name = "zasevEdit";
            this.zasevEdit.Size = new System.Drawing.Size(209, 43);
            this.zasevEdit.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(435, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Площадь засева";
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.addBtn.Location = new System.Drawing.Point(79, 191);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(676, 62);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "Внести данные";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datePicker.Location = new System.Drawing.Point(145, 151);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 34);
            this.datePicker.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(3, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 62);
            this.button1.TabIndex = 12;
            this.button1.Text = "↩️";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 283);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.createJournal);
            this.Controls.Add(this.showTable);
            this.Name = "mainPage";
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.mainPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showTable;
        private System.Windows.Forms.Button createJournal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox zasevEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ugodiyeCm;
        private System.Windows.Forms.ComboBox rasteniyeCm;
        private System.Windows.Forms.ComboBox rabochiyCm;
        private System.Windows.Forms.Button button1;
    }
}

