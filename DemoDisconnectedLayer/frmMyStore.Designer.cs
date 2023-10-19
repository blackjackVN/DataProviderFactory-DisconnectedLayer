namespace DemoDisconnectedLayer
{
    partial class frmMyStore
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
            btnViewProducts = new Button();
            btnViewCategories = new Button();
            btnClose = new Button();
            dgvData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // btnViewProducts
            // 
            btnViewProducts.Location = new Point(162, 41);
            btnViewProducts.Name = "btnViewProducts";
            btnViewProducts.Size = new Size(114, 23);
            btnViewProducts.TabIndex = 0;
            btnViewProducts.Text = "View Products";
            btnViewProducts.UseVisualStyleBackColor = true;
            btnViewProducts.Click += button1_Click;
            // 
            // btnViewCategories
            // 
            btnViewCategories.Location = new Point(414, 41);
            btnViewCategories.Name = "btnViewCategories";
            btnViewCategories.Size = new Size(117, 23);
            btnViewCategories.TabIndex = 1;
            btnViewCategories.Text = "View Categories";
            btnViewCategories.UseVisualStyleBackColor = true;
            btnViewCategories.Click += button2_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(301, 373);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += button3_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(21, 106);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(676, 224);
            dgvData.TabIndex = 3;
            dgvData.CellContentClick += dataGridView1_CellContentClick;
            // 
            // frmMyStore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvData);
            Controls.Add(btnClose);
            Controls.Add(btnViewCategories);
            Controls.Add(btnViewProducts);
            Name = "frmMyStore";
            Text = "frmMyStore";
            Load += frmMyStore_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnViewProducts;
        private Button btnViewCategories;
        private Button btnClose;
        private DataGridView dgvData;
    }
}