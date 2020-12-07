namespace FinalProjectGUI
{
    partial class EmployeeDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DGInventoryReport = new System.Windows.Forms.DataGridView();
            this.DGEmployeeList = new System.Windows.Forms.DataGridView();
            this.DGSalesReport = new System.Windows.Forms.DataGridView();
            this.BTNAddSalesReport = new System.Windows.Forms.Button();
            this.BTNAddEmployee = new System.Windows.Forms.Button();
            this.BTNAddInventory = new System.Windows.Forms.Button();
            this.BTNBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGInventoryReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGEmployeeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGSalesReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Dashboard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sales Report";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employee List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Inventory Report";
            // 
            // DGInventoryReport
            // 
            this.DGInventoryReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGInventoryReport.Location = new System.Drawing.Point(451, 166);
            this.DGInventoryReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGInventoryReport.Name = "DGInventoryReport";
            this.DGInventoryReport.RowHeadersWidth = 51;
            this.DGInventoryReport.RowTemplate.Height = 24;
            this.DGInventoryReport.Size = new System.Drawing.Size(180, 122);
            this.DGInventoryReport.TabIndex = 4;
            // 
            // DGEmployeeList
            // 
            this.DGEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGEmployeeList.Location = new System.Drawing.Point(226, 166);
            this.DGEmployeeList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGEmployeeList.Name = "DGEmployeeList";
            this.DGEmployeeList.RowHeadersWidth = 51;
            this.DGEmployeeList.Size = new System.Drawing.Size(180, 122);
            this.DGEmployeeList.TabIndex = 5;
            // 
            // DGSalesReport
            // 
            this.DGSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGSalesReport.Location = new System.Drawing.Point(1, 166);
            this.DGSalesReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGSalesReport.Name = "DGSalesReport";
            this.DGSalesReport.RowHeadersWidth = 51;
            this.DGSalesReport.Size = new System.Drawing.Size(180, 122);
            this.DGSalesReport.TabIndex = 6;
            // 
            // BTNAddSalesReport
            // 
            this.BTNAddSalesReport.Location = new System.Drawing.Point(1, 311);
            this.BTNAddSalesReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNAddSalesReport.Name = "BTNAddSalesReport";
            this.BTNAddSalesReport.Size = new System.Drawing.Size(56, 19);
            this.BTNAddSalesReport.TabIndex = 7;
            this.BTNAddSalesReport.Text = "ADD";
            this.BTNAddSalesReport.UseVisualStyleBackColor = true;
            // 
            // BTNAddEmployee
            // 
            this.BTNAddEmployee.Location = new System.Drawing.Point(226, 311);
            this.BTNAddEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNAddEmployee.Name = "BTNAddEmployee";
            this.BTNAddEmployee.Size = new System.Drawing.Size(56, 19);
            this.BTNAddEmployee.TabIndex = 8;
            this.BTNAddEmployee.Text = "ADD";
            this.BTNAddEmployee.UseVisualStyleBackColor = true;
            // 
            // BTNAddInventory
            // 
            this.BTNAddInventory.Location = new System.Drawing.Point(451, 311);
            this.BTNAddInventory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNAddInventory.Name = "BTNAddInventory";
            this.BTNAddInventory.Size = new System.Drawing.Size(56, 19);
            this.BTNAddInventory.TabIndex = 9;
            this.BTNAddInventory.Text = "ADD";
            this.BTNAddInventory.UseVisualStyleBackColor = true;
            // 
            // BTNBack
            // 
            this.BTNBack.Location = new System.Drawing.Point(565, 378);
            this.BTNBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNBack.Name = "BTNBack";
            this.BTNBack.Size = new System.Drawing.Size(56, 19);
            this.BTNBack.TabIndex = 10;
            this.BTNBack.Text = "Back";
            this.BTNBack.UseVisualStyleBackColor = true;
            // 
            // EmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1148, 566);
            this.Controls.Add(this.BTNBack);
            this.Controls.Add(this.BTNAddInventory);
            this.Controls.Add(this.BTNAddEmployee);
            this.Controls.Add(this.BTNAddSalesReport);
            this.Controls.Add(this.DGSalesReport);
            this.Controls.Add(this.DGEmployeeList);
            this.Controls.Add(this.DGInventoryReport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EmployeeDashboard";
            this.Text = "EmployeeDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.DGInventoryReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGEmployeeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGSalesReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGInventoryReport;
        private System.Windows.Forms.DataGridView DGEmployeeList;
        private System.Windows.Forms.DataGridView DGSalesReport;
        private System.Windows.Forms.Button BTNAddSalesReport;
        private System.Windows.Forms.Button BTNAddEmployee;
        private System.Windows.Forms.Button BTNAddInventory;
        private System.Windows.Forms.Button BTNBack;
    }
}