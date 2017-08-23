namespace VagnerCarRental
{
    partial class VehicleEditor
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSelectPicture = new System.Windows.Forms.Button();
            this.lblPictureName = new System.Windows.Forms.Label();
            this.txtTagNumber = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtDoors = new System.Windows.Forms.TextBox();
            this.txtPassengers = new System.Windows.Forms.TextBox();
            this.cbxConditions = new System.Windows.Forms.ComboBox();
            this.cbxCategories = new System.Windows.Forms.ComboBox();
            this.cbxAvailabilities = new System.Windows.Forms.ComboBox();
            this.pbxVehicle = new System.Windows.Forms.PictureBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dlgPicture = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Tag Number: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "M&ake: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "M&odel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "&Doors: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "&Passengers:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Con&dition: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "&Category: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "&Availability: ";
            // 
            // btnSelectPicture
            // 
            this.btnSelectPicture.Location = new System.Drawing.Point(16, 400);
            this.btnSelectPicture.Name = "btnSelectPicture";
            this.btnSelectPicture.Size = new System.Drawing.Size(205, 36);
            this.btnSelectPicture.TabIndex = 8;
            this.btnSelectPicture.Text = "&Select &Vehicle &Picture...";
            this.btnSelectPicture.UseVisualStyleBackColor = true;
            this.btnSelectPicture.Click += new System.EventHandler(this.btnSelectPicture_Click);
            // 
            // lblPictureName
            // 
            this.lblPictureName.AutoSize = true;
            this.lblPictureName.Location = new System.Drawing.Point(16, 463);
            this.lblPictureName.Name = "lblPictureName";
            this.lblPictureName.Size = new System.Drawing.Size(71, 13);
            this.lblPictureName.TabIndex = 9;
            this.lblPictureName.Text = "Picture Name";
            // 
            // txtTagNumber
            // 
            this.txtTagNumber.Location = new System.Drawing.Point(100, 35);
            this.txtTagNumber.Name = "txtTagNumber";
            this.txtTagNumber.Size = new System.Drawing.Size(121, 20);
            this.txtTagNumber.TabIndex = 10;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(100, 80);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(121, 20);
            this.txtMake.TabIndex = 11;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(100, 125);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(121, 20);
            this.txtModel.TabIndex = 12;
            // 
            // txtDoors
            // 
            this.txtDoors.Location = new System.Drawing.Point(100, 170);
            this.txtDoors.Name = "txtDoors";
            this.txtDoors.Size = new System.Drawing.Size(121, 20);
            this.txtDoors.TabIndex = 13;
            // 
            // txtPassengers
            // 
            this.txtPassengers.Location = new System.Drawing.Point(100, 215);
            this.txtPassengers.Name = "txtPassengers";
            this.txtPassengers.Size = new System.Drawing.Size(121, 20);
            this.txtPassengers.TabIndex = 14;
            // 
            // cbxConditions
            // 
            this.cbxConditions.FormattingEnabled = true;
            this.cbxConditions.Items.AddRange(new object[] {
            "Good",
            "Other",
            "Excellent",
            "Driveable",
            "Needs Repair"});
            this.cbxConditions.Location = new System.Drawing.Point(100, 258);
            this.cbxConditions.Name = "cbxConditions";
            this.cbxConditions.Size = new System.Drawing.Size(121, 21);
            this.cbxConditions.TabIndex = 15;
            // 
            // cbxCategories
            // 
            this.cbxCategories.FormattingEnabled = true;
            this.cbxCategories.Items.AddRange(new object[] {
            "SUV",
            "Truck",
            "FullSize",
            "Mini Van",
            "Compact",
            "Standard",
            "Economy",
            "Passenger Van"});
            this.cbxCategories.Location = new System.Drawing.Point(100, 303);
            this.cbxCategories.Name = "cbxCategories";
            this.cbxCategories.Size = new System.Drawing.Size(121, 21);
            this.cbxCategories.TabIndex = 16;
            // 
            // cbxAvailabilities
            // 
            this.cbxAvailabilities.FormattingEnabled = true;
            this.cbxAvailabilities.Items.AddRange(new object[] {
            "Rented",
            "Available",
            "Being Serviced"});
            this.cbxAvailabilities.Location = new System.Drawing.Point(100, 348);
            this.cbxAvailabilities.Name = "cbxAvailabilities";
            this.cbxAvailabilities.Size = new System.Drawing.Size(121, 21);
            this.cbxAvailabilities.TabIndex = 17;
            // 
            // pbxVehicle
            // 
            this.pbxVehicle.Location = new System.Drawing.Point(239, 35);
            this.pbxVehicle.Name = "pbxVehicle";
            this.pbxVehicle.Size = new System.Drawing.Size(580, 401);
            this.pbxVehicle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxVehicle.TabIndex = 18;
            this.pbxVehicle.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(642, 453);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 19;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(744, 452);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dlgPicture
            // 
            this.dlgPicture.DefaultExt = "jpg";
            this.dlgPicture.FileName = "Open";
            this.dlgPicture.Filter = "JPEG Files (*.jpg,*.jpeg)|*.jpg|GIF Files (*.gif)|*.gif|Bitmap Files (*.bmp)|*.bm" +
    "p|PNG Files (*.png)|*.png";
            // 
            // VehicleEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 498);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pbxVehicle);
            this.Controls.Add(this.cbxAvailabilities);
            this.Controls.Add(this.cbxCategories);
            this.Controls.Add(this.cbxConditions);
            this.Controls.Add(this.txtPassengers);
            this.Controls.Add(this.txtDoors);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.txtTagNumber);
            this.Controls.Add(this.lblPictureName);
            this.Controls.Add(this.btnSelectPicture);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VehicleEditor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VehicleEditor";
            this.Load += new System.EventHandler(this.VehicleEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxVehicle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSelectPicture;
        private System.Windows.Forms.Label lblPictureName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.OpenFileDialog dlgPicture;
        public System.Windows.Forms.TextBox txtTagNumber;
        public System.Windows.Forms.TextBox txtMake;
        public System.Windows.Forms.TextBox txtModel;
        public System.Windows.Forms.TextBox txtDoors;
        public System.Windows.Forms.TextBox txtPassengers;
        public System.Windows.Forms.ComboBox cbxConditions;
        public System.Windows.Forms.ComboBox cbxCategories;
        public System.Windows.Forms.ComboBox cbxAvailabilities;
        public System.Windows.Forms.PictureBox pbxVehicle;
    }
}