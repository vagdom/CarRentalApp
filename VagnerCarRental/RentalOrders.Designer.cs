namespace VagnerCarRental
{
    partial class RentalOrders
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
            this.lvwRentalOrders = new System.Windows.Forms.ListView();
            this.colReceiptOrderNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProcessedDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmployee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCustomer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVehicle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCarCondition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStartingMileage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEndingMileage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotalMileage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRentStartingDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRentEndingDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDaysTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDailyRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDailySubTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTaxPercentage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTaxPaid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotalOrder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatusOfOrder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNewRentalOrder = new System.Windows.Forms.Button();
            this.btnUpdateRentalOrder = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwRentalOrders
            // 
            this.lvwRentalOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colReceiptOrderNumber,
            this.colProcessedDate,
            this.colEmployee,
            this.colCustomer,
            this.colVehicle,
            this.colCarCondition,
            this.colTank,
            this.colStartingMileage,
            this.colEndingMileage,
            this.colTotalMileage,
            this.colRentStartingDate,
            this.colRentEndingDate,
            this.colDaysTotal,
            this.colDailyRate,
            this.colDailySubTotal,
            this.colTaxPercentage,
            this.colTaxPaid,
            this.colTotalOrder,
            this.colStatusOfOrder});
            this.lvwRentalOrders.GridLines = true;
            this.lvwRentalOrders.Location = new System.Drawing.Point(12, 12);
            this.lvwRentalOrders.Name = "lvwRentalOrders";
            this.lvwRentalOrders.Size = new System.Drawing.Size(1346, 209);
            this.lvwRentalOrders.TabIndex = 0;
            this.lvwRentalOrders.UseCompatibleStateImageBehavior = false;
            this.lvwRentalOrders.View = System.Windows.Forms.View.Details;
            // 
            // colReceiptOrderNumber
            // 
            this.colReceiptOrderNumber.Text = "Receipt #";
            this.colReceiptOrderNumber.Width = 65;
            // 
            // colProcessedDate
            // 
            this.colProcessedDate.Text = "Date Processed";
            this.colProcessedDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colProcessedDate.Width = 100;
            // 
            // colEmployee
            // 
            this.colEmployee.Text = "Employee";
            this.colEmployee.Width = 140;
            // 
            // colCustomer
            // 
            this.colCustomer.Text = "Customer";
            this.colCustomer.Width = 120;
            // 
            // colVehicle
            // 
            this.colVehicle.Text = "Vehicle";
            this.colVehicle.Width = 140;
            // 
            // colCarCondition
            // 
            this.colCarCondition.Text = "Car Condition";
            this.colCarCondition.Width = 90;
            // 
            // colTank
            // 
            this.colTank.Text = "Tank";
            // 
            // colStartingMileage
            // 
            this.colStartingMileage.Text = "Mileage Start";
            this.colStartingMileage.Width = 65;
            // 
            // colEndingMileage
            // 
            this.colEndingMileage.Text = "Mileage End";
            this.colEndingMileage.Width = 65;
            // 
            // colTotalMileage
            // 
            this.colTotalMileage.Text = "Total Mileage";
            this.colTotalMileage.Width = 65;
            // 
            // colRentStartingDate
            // 
            this.colRentStartingDate.Text = "Start Date";
            this.colRentStartingDate.Width = 90;
            // 
            // colRentEndingDate
            // 
            this.colRentEndingDate.Text = "Rent End";
            this.colRentEndingDate.Width = 90;
            // 
            // colDaysTotal
            // 
            this.colDaysTotal.Text = "Total Days";
            // 
            // colDailyRate
            // 
            this.colDailyRate.Text = "Cost";
            // 
            // colDailySubTotal
            // 
            this.colDailySubTotal.Text = "Sub-Total";
            this.colDailySubTotal.Width = 80;
            // 
            // colTaxPercentage
            // 
            this.colTaxPercentage.Text = "Tax Rate";
            // 
            // colTaxPaid
            // 
            this.colTaxPaid.Text = "Tax Amount";
            // 
            // colTotalOrder
            // 
            this.colTotalOrder.Text = "Total Order";
            // 
            // colStatusOfOrder
            // 
            this.colStatusOfOrder.Text = "Order Status";
            // 
            // btnNewRentalOrder
            // 
            this.btnNewRentalOrder.Location = new System.Drawing.Point(980, 227);
            this.btnNewRentalOrder.Name = "btnNewRentalOrder";
            this.btnNewRentalOrder.Size = new System.Drawing.Size(122, 23);
            this.btnNewRentalOrder.TabIndex = 1;
            this.btnNewRentalOrder.Text = "New Rental Order";
            this.btnNewRentalOrder.UseVisualStyleBackColor = true;
            this.btnNewRentalOrder.Click += new System.EventHandler(this.btnNewRentalOrder_Click);
            // 
            // btnUpdateRentalOrder
            // 
            this.btnUpdateRentalOrder.Location = new System.Drawing.Point(1108, 227);
            this.btnUpdateRentalOrder.Name = "btnUpdateRentalOrder";
            this.btnUpdateRentalOrder.Size = new System.Drawing.Size(122, 23);
            this.btnUpdateRentalOrder.TabIndex = 2;
            this.btnUpdateRentalOrder.Text = "Update Rental Order";
            this.btnUpdateRentalOrder.UseVisualStyleBackColor = true;
            this.btnUpdateRentalOrder.Click += new System.EventHandler(this.btnUpdateRentalOrder_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1236, 227);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // RentalOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 262);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdateRentalOrder);
            this.Controls.Add(this.btnNewRentalOrder);
            this.Controls.Add(this.lvwRentalOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RentalOrders";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentalOrders";
            this.Load += new System.EventHandler(this.RentalOrders_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwRentalOrders;
        private System.Windows.Forms.Button btnNewRentalOrder;
        private System.Windows.Forms.Button btnUpdateRentalOrder;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ColumnHeader colReceiptOrderNumber;
        private System.Windows.Forms.ColumnHeader colProcessedDate;
        private System.Windows.Forms.ColumnHeader colEmployee;
        private System.Windows.Forms.ColumnHeader colCustomer;
        private System.Windows.Forms.ColumnHeader colVehicle;
        private System.Windows.Forms.ColumnHeader colCarCondition;
        private System.Windows.Forms.ColumnHeader colTank;
        private System.Windows.Forms.ColumnHeader colStartingMileage;
        private System.Windows.Forms.ColumnHeader colEndingMileage;
        private System.Windows.Forms.ColumnHeader colTotalMileage;
        private System.Windows.Forms.ColumnHeader colRentStartingDate;
        private System.Windows.Forms.ColumnHeader colRentEndingDate;
        private System.Windows.Forms.ColumnHeader colDaysTotal;
        private System.Windows.Forms.ColumnHeader colDailyRate;
        private System.Windows.Forms.ColumnHeader colDailySubTotal;
        private System.Windows.Forms.ColumnHeader colTaxPercentage;
        private System.Windows.Forms.ColumnHeader colTaxPaid;
        private System.Windows.Forms.ColumnHeader colTotalOrder;
        private System.Windows.Forms.ColumnHeader colStatusOfOrder;
    }
}