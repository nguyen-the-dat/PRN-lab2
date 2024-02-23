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
            panel1 = new System.Windows.Forms.Panel();
            txtCarID = new System.Windows.Forms.TextBox();
            lbCarId = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            txtCarName = new System.Windows.Forms.TextBox();
            car = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            cboManufacturer = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            txtPrice = new System.Windows.Forms.MaskedTextBox();
            label3 = new System.Windows.Forms.Label();
            panel5 = new System.Windows.Forms.Panel();
            txtReleaseYear = new System.Windows.Forms.MaskedTextBox();
            label4 = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtCarID);
            panel1.Controls.Add(lbCarId);
            panel1.Location = new System.Drawing.Point(25, 24);
            panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(413, 42);
            panel1.TabIndex = 0;
            // 
            // txtCarID
            // 
            txtCarID.Location = new System.Drawing.Point(97, 11);
            txtCarID.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new System.Drawing.Size(299, 23);
            txtCarID.TabIndex = 1;
            // 
            // lbCarId
            // 
            lbCarId.AutoSize = true;
            lbCarId.Location = new System.Drawing.Point(2, 13);
            lbCarId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbCarId.Name = "lbCarId";
            lbCarId.Size = new System.Drawing.Size(39, 15);
            lbCarId.TabIndex = 0;
            lbCarId.Text = "Car ID";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtCarName);
            panel2.Controls.Add(car);
            panel2.Location = new System.Drawing.Point(25, 74);
            panel2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(413, 42);
            panel2.TabIndex = 2;
            // 
            // txtCarName
            // 
            txtCarName.Location = new System.Drawing.Point(97, 11);
            txtCarName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new System.Drawing.Size(299, 23);
            txtCarName.TabIndex = 2;
            // 
            // car
            // 
            car.AutoSize = true;
            car.Location = new System.Drawing.Point(2, 13);
            car.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            car.Name = "car";
            car.Size = new System.Drawing.Size(60, 15);
            car.TabIndex = 0;
            car.Text = "Car Name";
            // 
            // panel3
            // 
            panel3.Controls.Add(cboManufacturer);
            panel3.Controls.Add(label2);
            panel3.Location = new System.Drawing.Point(25, 126);
            panel3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(413, 42);
            panel3.TabIndex = 2;
            // 
            // cboManufacturer
            // 
            cboManufacturer.FormattingEnabled = true;
            cboManufacturer.Items.AddRange(new object[] { "Audi", "BMW", "Ford", "Honda", "Hyundai", "Kia", "Suzuki", "Toyota" });
            cboManufacturer.Location = new System.Drawing.Point(97, 13);
            cboManufacturer.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            cboManufacturer.Name = "cboManufacturer";
            cboManufacturer.Size = new System.Drawing.Size(299, 23);
            cboManufacturer.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(2, 13);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 15);
            label2.TabIndex = 0;
            label2.Text = "Manufacturer";
            // 
            // panel4
            // 
            panel4.Controls.Add(txtPrice);
            panel4.Controls.Add(label3);
            panel4.Location = new System.Drawing.Point(25, 177);
            panel4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(413, 42);
            panel4.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(97, 13);
            txtPrice.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            txtPrice.Mask = "00000000";
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(299, 23);
            txtPrice.TabIndex = 4;
            txtPrice.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(2, 13);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(33, 15);
            label3.TabIndex = 0;
            label3.Text = "Price";
            // 
            // panel5
            // 
            panel5.Controls.Add(txtReleaseYear);
            panel5.Controls.Add(label4);
            panel5.Location = new System.Drawing.Point(25, 227);
            panel5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(413, 42);
            panel5.TabIndex = 2;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new System.Drawing.Point(97, 11);
            txtReleaseYear.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            txtReleaseYear.Mask = "0000";
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new System.Drawing.Size(299, 23);
            txtReleaseYear.TabIndex = 5;
            txtReleaseYear.Text = "2000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(2, 13);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(78, 15);
            label4.TabIndex = 0;
            label4.Text = "Released year";
            // 
            // btnSave
            // 
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.Location = new System.Drawing.Point(117, 292);
            btnSave.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(81, 33);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(244, 292);
            btnCancel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(81, 33);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmCarDetails
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(463, 340);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            Name = "frmCarDetails";
            Text = "frmCarDetails";
            Load += frmCarDetails_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCarId;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.Label car;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboManufacturer;
        private System.Windows.Forms.MaskedTextBox txtPrice;
        private System.Windows.Forms.MaskedTextBox txtReleaseYear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}