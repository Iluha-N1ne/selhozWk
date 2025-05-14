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
            this.button1 = new System.Windows.Forms.Button();
            this.staticBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showTable
            // 
            this.showTable.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showTable.Location = new System.Drawing.Point(138, 12);
            this.showTable.Name = "showTable";
            this.showTable.Size = new System.Drawing.Size(507, 257);
            this.showTable.TabIndex = 0;
            this.showTable.Text = "Просмотр или редактирование данных";
            this.showTable.UseVisualStyleBackColor = true;
            this.showTable.Click += new System.EventHandler(this.showTable_Click);
            // 
            // createJournal
            // 
            this.createJournal.Enabled = false;
            this.createJournal.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createJournal.Location = new System.Drawing.Point(12, 275);
            this.createJournal.Name = "createJournal";
            this.createJournal.Size = new System.Drawing.Size(420, 257);
            this.createJournal.TabIndex = 2;
            this.createJournal.Text = "Создать расширеннкую запись о продаже";
            this.createJournal.UseVisualStyleBackColor = true;
            this.createJournal.Click += new System.EventHandler(this.createJournal_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(438, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(369, 257);
            this.button1.TabIndex = 3;
            this.button1.Text = "Создать расширеную \r\nзапись о поставщике";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // staticBtn
            // 
            this.staticBtn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.staticBtn.Location = new System.Drawing.Point(661, 12);
            this.staticBtn.Name = "staticBtn";
            this.staticBtn.Size = new System.Drawing.Size(545, 257);
            this.staticBtn.TabIndex = 4;
            this.staticBtn.Text = "Просмотреть статистику";
            this.staticBtn.UseVisualStyleBackColor = true;
            this.staticBtn.Click += new System.EventHandler(this.staticBtn_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(813, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(369, 257);
            this.button2.TabIndex = 5;
            this.button2.Text = "Создать расширеную запись о типах товаров";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 552);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.staticBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.createJournal);
            this.Controls.Add(this.showTable);
            this.Name = "mainPage";
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.mainPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showTable;
        private System.Windows.Forms.Button createJournal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button staticBtn;
        private System.Windows.Forms.Button button2;
    }
}

