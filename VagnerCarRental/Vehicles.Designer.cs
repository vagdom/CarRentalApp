namespace VagnerCarRental
{
    partial class Vehicles
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
            this.lvwVehicles = new System.Windows.Forms.ListView();
            this.colTagNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMake = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDoors = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPassengers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCondition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAvailability = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pbxVehicle = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNewVehicle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(721, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vagner Rental Cars Inventory";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvwVehicles
            // 
            this.lvwVehicles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTagNumber,
            this.colMake,
            this.colModel,
            this.colDoors,
            this.colPassengers,
            this.colCondition,
            this.colCategory,
            this.colAvailability});
            this.lvwVehicles.FullRowSelect = true;
            this.lvwVehicles.GridLines = true;
            this.lvwVehicles.Location = new System.Drawing.Point(12, 87);
            this.lvwVehicles.Name = "lvwVehicles";
            this.lvwVehicles.Size = new System.Drawing.Size(721, 199);
            this.lvwVehicles.TabIndex = 1;
            this.lvwVehicles.UseCompatibleStateImageBehavior = false;
            this.lvwVehicles.View = System.Windows.Forms.View.Details;
            this.lvwVehicles.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvwVehicles_ItemSelectionChanged);
            // 
            // colTagNumber
            // 
            this.colTagNumber.Text = "Tag #";
            this.colTagNumber.Width = 55;
            // 
            // colMake
            // 
            this.colMake.Text = "Make";
            this.colMake.Width = 70;
            // 
            // colModel
            // 
            this.colModel.Text = "Model";
            this.colModel.Width = 120;
            // 
            // colDoors
            // 
            this.colDoors.Text = "Doors";
            this.colDoors.Width = 40;
            // 
            // colPassengers
            // 
            this.colPassengers.Text = "Passengers";
            this.colPassengers.Width = 70;
            // 
            // colCondition
            // 
            this.colCondition.Text = "Condition";
            this.colCondition.Width = 120;
            // 
            // colCategory
            // 
            this.colCategory.Text = "Category";
            this.colCategory.Width = 120;
            // 
            // colAvailability
            // 
            this.colAvailability.Text = "Availability";
            this.colAvailability.Width = 120;
            // 
            // pbxVehicle
            // 
            this.pbxVehicle.Location = new System.Drawing.Point(182, 292);
            this.pbxVehicle.Name = "pbxVehicle";
            this.pbxVehicle.Size = new System.Drawing.Size(414, 334);
            this.pbxVehicle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxVehicle.TabIndex = 2;
            this.pbxVehicle.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(625, 643);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNewVehicle
            // 
            this.btnNewVehicle.Location = new System.Drawing.Point(513, 643);
            this.btnNewVehicle.Name = "btnNewVehicle";
            this.btnNewVehicle.Size = new System.Drawing.Size(106, 23);
            this.btnNewVehicle.TabIndex = 4;
            this.btnNewVehicle.Text = "New Vehicle";
            this.btnNewVehicle.UseVisualStyleBackColor = true;
            this.btnNewVehicle.Click += new System.EventHandler(this.btnNewVehicle_Click);
            // 
            // Vehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 681);
            this.Controls.Add(this.btnNewVehicle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pbxVehicle);
            this.Controls.Add(this.lvwVehicles);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Vehicles";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicles";
            this.Load += new System.EventHandler(this.Vehicles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxVehicle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvwVehicles;
        private System.Windows.Forms.ColumnHeader colTagNumber;
        private System.Windows.Forms.ColumnHeader colMake;
        private System.Windows.Forms.ColumnHeader colModel;
        private System.Windows.Forms.ColumnHeader colDoors;
        private System.Windows.Forms.ColumnHeader colPassengers;
        private System.Windows.Forms.ColumnHeader colCondition;
        private System.Windows.Forms.ColumnHeader colCategory;
        private System.Windows.Forms.ColumnHeader colAvailability;
        private System.Windows.Forms.PictureBox pbxVehicle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNewVehicle;
    }
}