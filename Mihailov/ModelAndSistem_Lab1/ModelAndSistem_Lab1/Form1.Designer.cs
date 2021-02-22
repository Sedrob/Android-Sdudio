namespace ModelAndSistem_Lab1
{
    partial class Form1
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
            this.primaryData = new System.Windows.Forms.DataGridView();
            this.inputDataStart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericPrimaryData = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.primaryDataWorkC = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveSalary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.primaryData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrimaryData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primaryDataWorkC)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // primaryData
            // 
            this.primaryData.AllowUserToAddRows = false;
            this.primaryData.AllowUserToDeleteRows = false;
            this.primaryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.primaryData.Location = new System.Drawing.Point(6, 105);
            this.primaryData.Name = "primaryData";
            this.primaryData.ReadOnly = true;
            this.primaryData.RowHeadersWidth = 51;
            this.primaryData.RowTemplate.Height = 24;
            this.primaryData.Size = new System.Drawing.Size(399, 187);
            this.primaryData.TabIndex = 0;
            // 
            // inputDataStart
            // 
            this.inputDataStart.Location = new System.Drawing.Point(174, 51);
            this.inputDataStart.Name = "inputDataStart";
            this.inputDataStart.Size = new System.Drawing.Size(100, 22);
            this.inputDataStart.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вход цепи";
            // 
            // numericPrimaryData
            // 
            this.numericPrimaryData.Location = new System.Drawing.Point(6, 51);
            this.numericPrimaryData.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericPrimaryData.Name = "numericPrimaryData";
            this.numericPrimaryData.Size = new System.Drawing.Size(120, 22);
            this.numericPrimaryData.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Переходные вероятности";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Размерность цепи";
            // 
            // primaryDataWorkC
            // 
            this.primaryDataWorkC.AllowUserToAddRows = false;
            this.primaryDataWorkC.AllowUserToDeleteRows = false;
            this.primaryDataWorkC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.primaryDataWorkC.Location = new System.Drawing.Point(432, 105);
            this.primaryDataWorkC.Name = "primaryDataWorkC";
            this.primaryDataWorkC.ReadOnly = true;
            this.primaryDataWorkC.RowHeadersWidth = 51;
            this.primaryDataWorkC.RowTemplate.Height = 24;
            this.primaryDataWorkC.Size = new System.Drawing.Size(120, 187);
            this.primaryDataWorkC.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Трудоемкость";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaveSalary);
            this.groupBox1.Controls.Add(this.primaryData);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.inputDataStart);
            this.groupBox1.Controls.Add(this.primaryDataWorkC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericPrimaryData);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 337);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Начальные данные";
            // 
            // SaveSalary
            // 
            this.SaveSalary.Location = new System.Drawing.Point(405, 13);
            this.SaveSalary.Name = "SaveSalary";
            this.SaveSalary.Size = new System.Drawing.Size(161, 29);
            this.SaveSalary.TabIndex = 8;
            this.SaveSalary.Text = "Сохранить данные";
            this.SaveSalary.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 487);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.primaryData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrimaryData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primaryDataWorkC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView primaryData;
        private System.Windows.Forms.TextBox inputDataStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericPrimaryData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView primaryDataWorkC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SaveSalary;
    }
}

