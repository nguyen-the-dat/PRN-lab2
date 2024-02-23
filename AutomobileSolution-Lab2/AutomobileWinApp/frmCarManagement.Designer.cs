namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            txtManufacturer = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtCarName = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtCarID = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            btnDelete = new System.Windows.Forms.Button();
            btnLoad = new System.Windows.Forms.Button();
            btnNew = new System.Windows.Forms.Button();
            panel3 = new System.Windows.Forms.Panel();
            dgvCarList = new System.Windows.Forms.DataGridView();
            btnClose = new System.Windows.Forms.Button();
            panel4 = new System.Windows.Forms.Panel();
            txtReleaseYear = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtPrice = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtManufacturer);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtCarName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtCarID);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(744, 336);
            panel1.TabIndex = 0;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new System.Drawing.Point(211, 254);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new System.Drawing.Size(487, 39);
            txtManufacturer.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(38, 254);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(158, 32);
            label3.TabIndex = 4;
            label3.Text = "Manufacturer";
            // 
            // txtCarName
            // 
            txtCarName.Location = new System.Drawing.Point(211, 149);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new System.Drawing.Size(487, 39);
            txtCarName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(38, 149);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(120, 32);
            label2.TabIndex = 2;
            label2.Text = "Car Name";
            // 
            // txtCarID
            // 
            txtCarID.Location = new System.Drawing.Point(210, 40);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new System.Drawing.Size(487, 39);
            txtCarID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(37, 40);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(79, 32);
            label1.TabIndex = 0;
            label1.Text = "Car ID";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnLoad);
            panel2.Controls.Add(btnNew);
            panel2.Location = new System.Drawing.Point(279, 353);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(954, 95);
            panel2.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(735, 9);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(150, 76);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(71, 9);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(150, 76);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(403, 9);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(150, 76);
            btnNew.TabIndex = 1;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvCarList);
            panel3.Location = new System.Drawing.Point(12, 459);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(1461, 392);
            panel3.TabIndex = 1;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new System.Drawing.Point(0, 0);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.RowHeadersWidth = 82;
            dgvCarList.RowTemplate.Height = 41;
            dgvCarList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new System.Drawing.Size(1461, 389);
            dgvCarList.TabIndex = 0;
            dgvCarList.CellDoubleClick += dgvCarList_CellDoubleClick;
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(676, 855);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(150, 76);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtReleaseYear);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(txtPrice);
            panel4.Controls.Add(label6);
            panel4.Location = new System.Drawing.Point(744, 0);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(736, 336);
            panel4.TabIndex = 6;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new System.Drawing.Point(211, 149);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new System.Drawing.Size(487, 39);
            txtReleaseYear.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(38, 149);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(146, 32);
            label5.TabIndex = 2;
            label5.Text = "Relased Year";
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(210, 40);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(487, 39);
            txtPrice.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(37, 40);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(65, 32);
            label6.TabIndex = 0;
            label6.Text = "Price";
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1485, 937);
            Controls.Add(panel4);
            Controls.Add(btnClose);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmCarManagement";
            Text = "frmCarManagement";
            Load += frmCarManagement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvCarList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtReleaseYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label6;
    }
}