namespace selhozWk.staticPage
{
    partial class statisticPage
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.highPopularTovar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lowPopularTovar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.highPostavshik = new System.Windows.Forms.Label();
            this.summaryGisheft = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 12);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(704, 554);
            this.dataGrid.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimePicker1.Location = new System.Drawing.Point(727, 76);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(319, 34);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimePicker2.Location = new System.Drawing.Point(727, 153);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(319, 34);
            this.dateTimePicker2.TabIndex = 2;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(727, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "С какой даты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(727, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "По какую дату";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(722, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Статистика за всё время";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(723, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Самый популярный товар:\r\n";
            // 
            // highPopularTovar
            // 
            this.highPopularTovar.AutoSize = true;
            this.highPopularTovar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.highPopularTovar.Location = new System.Drawing.Point(723, 310);
            this.highPopularTovar.Name = "highPopularTovar";
            this.highPopularTovar.Size = new System.Drawing.Size(20, 28);
            this.highPopularTovar.TabIndex = 7;
            this.highPopularTovar.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(723, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Самый не популярный товар:\r\n";
            // 
            // lowPopularTovar
            // 
            this.lowPopularTovar.AutoSize = true;
            this.lowPopularTovar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lowPopularTovar.Location = new System.Drawing.Point(723, 378);
            this.lowPopularTovar.Name = "lowPopularTovar";
            this.lowPopularTovar.Size = new System.Drawing.Size(20, 28);
            this.lowPopularTovar.TabIndex = 9;
            this.lowPopularTovar.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(723, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(296, 56);
            this.label6.TabIndex = 10;
            this.label6.Text = "Найбольшая доля поставок от:\r\n\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(723, 500);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 28);
            this.label7.TabIndex = 11;
            this.label7.Text = "Суммарная прибыль";
            // 
            // highPostavshik
            // 
            this.highPostavshik.AutoSize = true;
            this.highPostavshik.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.highPostavshik.Location = new System.Drawing.Point(723, 459);
            this.highPostavshik.Name = "highPostavshik";
            this.highPostavshik.Size = new System.Drawing.Size(20, 28);
            this.highPostavshik.TabIndex = 12;
            this.highPostavshik.Text = "*";
            // 
            // summaryGisheft
            // 
            this.summaryGisheft.AutoSize = true;
            this.summaryGisheft.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.summaryGisheft.Location = new System.Drawing.Point(723, 539);
            this.summaryGisheft.Name = "summaryGisheft";
            this.summaryGisheft.Size = new System.Drawing.Size(20, 28);
            this.summaryGisheft.TabIndex = 13;
            this.summaryGisheft.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.Location = new System.Drawing.Point(727, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 28);
            this.label8.TabIndex = 14;
            this.label8.Text = "Данные для таблицы";
            // 
            // statisticPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 578);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.summaryGisheft);
            this.Controls.Add(this.highPostavshik);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lowPopularTovar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.highPopularTovar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGrid);
            this.Name = "statisticPage";
            this.Text = "Статистика";
            this.Load += new System.EventHandler(this.statisticPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label highPopularTovar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lowPopularTovar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label highPostavshik;
        private System.Windows.Forms.Label summaryGisheft;
        private System.Windows.Forms.Label label8;
    }
}