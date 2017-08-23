namespace VagnerCarRental
{
    partial class RentalRates
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Economy",
            "35.95",
            "32.75",
            "28.95",
            "24.95"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Compact",
            "35.95",
            "35.75",
            "32.95",
            "28.95"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Standard",
            "45.95",
            "39.75",
            "35.95",
            "32.95"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Full Size",
            "49.95",
            "42.75",
            "38.95",
            "35.95"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Mini Van",
            "55.95",
            "50.75",
            "45.95",
            "42.95"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "SUV",
            "55.95",
            "50.75",
            "45.95",
            "42.95"}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "Truck",
            "42.75",
            "38.75",
            "35.95",
            "32.95"}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "Van",
            "69.95",
            "62.75",
            "55.95",
            "52.95"}, -1);
            this.lvwRentalRates = new System.Windows.Forms.ListView();
            this.colCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDaily = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWeekly = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMonthly = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWeekend = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvwRentalRates
            // 
            this.lvwRentalRates.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCategory,
            this.colDaily,
            this.colWeekly,
            this.colMonthly,
            this.colWeekend});
            this.lvwRentalRates.GridLines = true;
            this.lvwRentalRates.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8});
            this.lvwRentalRates.Location = new System.Drawing.Point(12, 12);
            this.lvwRentalRates.Name = "lvwRentalRates";
            this.lvwRentalRates.Size = new System.Drawing.Size(334, 164);
            this.lvwRentalRates.TabIndex = 0;
            this.lvwRentalRates.UseCompatibleStateImageBehavior = false;
            this.lvwRentalRates.View = System.Windows.Forms.View.Details;
            // 
            // colCategory
            // 
            this.colCategory.Text = "Category";
            this.colCategory.Width = 90;
            // 
            // colDaily
            // 
            this.colDaily.Text = "Daily";
            this.colDaily.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // colWeekly
            // 
            this.colWeekly.Text = "Weekly";
            this.colWeekly.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // colMonthly
            // 
            this.colMonthly.Text = "Monthly";
            this.colMonthly.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // colWeekend
            // 
            this.colWeekend.Text = "Weekend";
            this.colWeekend.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RentalRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 189);
            this.Controls.Add(this.lvwRentalRates);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RentalRates";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentalRates";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwRentalRates;
        private System.Windows.Forms.ColumnHeader colCategory;
        private System.Windows.Forms.ColumnHeader colDaily;
        private System.Windows.Forms.ColumnHeader colWeekly;
        private System.Windows.Forms.ColumnHeader colMonthly;
        private System.Windows.Forms.ColumnHeader colWeekend;
    }
}