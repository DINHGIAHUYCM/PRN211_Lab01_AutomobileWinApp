namespace AutomobileWinApp
{
    partial class frmCarDetails
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
            btnSave = new Button();
            lbCarID = new Label();
            lbCarName = new Label();
            lbManufacturer = new Label();
            lbPrice = new Label();
            lbReleaseYear = new Label();
            txtCarID = new TextBox();
            txtCarName = new TextBox();
            txtPrice = new MaskedTextBox();
            txtReleaseYear = new MaskedTextBox();
            cboManufacturer = new ComboBox();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(378, 382);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new Point(62, 47);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(61, 25);
            lbCarID.TabIndex = 2;
            lbCarID.Text = "Car ID";
            lbCarID.Click += lbCarID_Click;
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(62, 101);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(90, 25);
            lbCarName.TabIndex = 3;
            lbCarName.Text = "Car Name";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new Point(62, 160);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(117, 25);
            lbManufacturer.TabIndex = 4;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(62, 216);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(49, 25);
            lbPrice.TabIndex = 5;
            lbPrice.Text = "Price";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new Point(62, 269);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(107, 25);
            lbReleaseYear.TabIndex = 6;
            lbReleaseYear.Text = "Release Year";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(218, 44);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(355, 31);
            txtCarID.TabIndex = 7;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(218, 98);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(354, 31);
            txtCarName.TabIndex = 8;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(216, 215);
            txtPrice.Mask = "000000000";
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(356, 31);
            txtPrice.TabIndex = 9;
            txtPrice.Text = "0";
            txtPrice.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(218, 269);
            txtReleaseYear.Mask = "0000";
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(356, 31);
            txtReleaseYear.TabIndex = 10;
            txtReleaseYear.Text = "0";
            // 
            // cboManufacturer
            // 
            cboManufacturer.FormattingEnabled = true;
            cboManufacturer.Items.AddRange(new object[] { "Audi", "BMW", "Ford", "Honda", "Hyundai", "Kia", "Suzuki", "Toyota" });
            cboManufacturer.Location = new Point(216, 157);
            cboManufacturer.Name = "cboManufacturer";
            cboManufacturer.Size = new Size(352, 33);
            cboManufacturer.TabIndex = 11;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(533, 382);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmCarDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(cboManufacturer);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Controls.Add(btnSave);
            Name = "frmCarDetails";
            Text = "frmCarDetails";
            Load += frmCarDetails_Load;
            Click += btnSave_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSave;
        private Label lbCarID;
        private Label lbCarName;
        private Label lbManufacturer;
        private Label lbPrice;
        private Label lbReleaseYear;
        private TextBox txtCarID;
        private TextBox txtCarName;
        private MaskedTextBox txtPrice;
        private MaskedTextBox txtReleaseYear;
        private ComboBox cboManufacturer;
        private Button btnCancel;
    }
}