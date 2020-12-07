namespace FinalProjectGUI
{
    partial class CustomerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGCustomerInfo = new System.Windows.Forms.DataGridView();
            this.BTNUpdateInfo = new System.Windows.Forms.Button();
            this.BTNShoppingCart = new System.Windows.Forms.Button();
            this.BTNOrderTracking = new System.Windows.Forms.Button();
            this.BTNBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGCustomerInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(497, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Dashboard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Information";
            // 
            // DGCustomerInfo
            // 
            this.DGCustomerInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCustomerInfo.Location = new System.Drawing.Point(335, 197);
            this.DGCustomerInfo.Margin = new System.Windows.Forms.Padding(2);
            this.DGCustomerInfo.Name = "DGCustomerInfo";
            this.DGCustomerInfo.RowHeadersWidth = 51;
            this.DGCustomerInfo.RowTemplate.Height = 24;
            this.DGCustomerInfo.Size = new System.Drawing.Size(273, 216);
            this.DGCustomerInfo.TabIndex = 2;
            // 
            // BTNUpdateInfo
            // 
            this.BTNUpdateInfo.Location = new System.Drawing.Point(666, 197);
            this.BTNUpdateInfo.Margin = new System.Windows.Forms.Padding(2);
            this.BTNUpdateInfo.Name = "BTNUpdateInfo";
            this.BTNUpdateInfo.Size = new System.Drawing.Size(68, 40);
            this.BTNUpdateInfo.TabIndex = 3;
            this.BTNUpdateInfo.Text = "Update Info";
            this.BTNUpdateInfo.UseVisualStyleBackColor = true;
            // 
            // BTNShoppingCart
            // 
            this.BTNShoppingCart.Location = new System.Drawing.Point(666, 266);
            this.BTNShoppingCart.Margin = new System.Windows.Forms.Padding(2);
            this.BTNShoppingCart.Name = "BTNShoppingCart";
            this.BTNShoppingCart.Size = new System.Drawing.Size(68, 42);
            this.BTNShoppingCart.TabIndex = 4;
            this.BTNShoppingCart.Text = "Shopping Cart";
            this.BTNShoppingCart.UseVisualStyleBackColor = true;
            // 
            // BTNOrderTracking
            // 
            this.BTNOrderTracking.Location = new System.Drawing.Point(666, 341);
            this.BTNOrderTracking.Margin = new System.Windows.Forms.Padding(2);
            this.BTNOrderTracking.Name = "BTNOrderTracking";
            this.BTNOrderTracking.Size = new System.Drawing.Size(68, 42);
            this.BTNOrderTracking.TabIndex = 5;
            this.BTNOrderTracking.Text = "Order Tracking";
            this.BTNOrderTracking.UseVisualStyleBackColor = true;
            // 
            // BTNBack
            // 
            this.BTNBack.Location = new System.Drawing.Point(841, 381);
            this.BTNBack.Margin = new System.Windows.Forms.Padding(2);
            this.BTNBack.Name = "BTNBack";
            this.BTNBack.Size = new System.Drawing.Size(56, 19);
            this.BTNBack.TabIndex = 6;
            this.BTNBack.Text = "Back";
            this.BTNBack.UseVisualStyleBackColor = true;
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1148, 566);
            this.Controls.Add(this.BTNBack);
            this.Controls.Add(this.BTNOrderTracking);
            this.Controls.Add(this.BTNShoppingCart);
            this.Controls.Add(this.BTNUpdateInfo);
            this.Controls.Add(this.DGCustomerInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerDashboard";
            this.Text = "CustomerDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.DGCustomerInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGCustomerInfo;
        private System.Windows.Forms.Button BTNUpdateInfo;
        private System.Windows.Forms.Button BTNShoppingCart;
        private System.Windows.Forms.Button BTNOrderTracking;
        private System.Windows.Forms.Button BTNBack;
    }
}