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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainPage));
            this.showTable = new System.Windows.Forms.Button();
            this.createJournal = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.staticBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // showTable
            // 
            this.showTable.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showTable.Location = new System.Drawing.Point(136, 61);
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
            this.createJournal.Location = new System.Drawing.Point(10, 324);
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
            this.button1.Location = new System.Drawing.Point(436, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(369, 257);
            this.button1.TabIndex = 3;
            this.button1.Text = "Создать расширеную \r\nзапись о поставщике";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // staticBtn
            // 
            this.staticBtn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.staticBtn.Location = new System.Drawing.Point(659, 61);
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
            this.button2.Location = new System.Drawing.Point(811, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(369, 257);
            this.button2.TabIndex = 5;
            this.button2.Text = "Создать расширеную запись о типах товаров";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // menuStrip3
            // 
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(1218, 28);
            this.menuStrip3.TabIndex = 8;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(13, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1193, 549);
            this.panel1.TabIndex = 9;
            this.panel1.Visible = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(1064, 431);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 115);
            this.button3.TabIndex = 0;
            this.button3.Text = "↩️";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(20, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1038, 513);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 597);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.staticBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.createJournal);
            this.Controls.Add(this.showTable);
            this.Controls.Add(this.menuStrip3);
            this.Name = "mainPage";
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.mainPage_Load);
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showTable;
        private System.Windows.Forms.Button createJournal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button staticBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
    }
}

