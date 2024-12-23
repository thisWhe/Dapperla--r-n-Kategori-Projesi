namespace Project5_DapperNorthwind
{
    partial class Form1
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
            this.btnCategoryList = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCategoryDescription = new System.Windows.Forms.TextBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.btnCreateCategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.btnCategoryUpdate = new System.Windows.Forms.Button();
            this.btnCategoryDelete = new System.Windows.Forms.Button();
            this.lblCategoryCount = new System.Windows.Forms.Label();
            this.Dapper = new System.Windows.Forms.GroupBox();
            this.lblSeaFoodProductTotalPrice = new System.Windows.Forms.Label();
            this.lblAvgProductStock = new System.Windows.Forms.Label();
            this.lblProductCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Dapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCategoryList
            // 
            this.btnCategoryList.Location = new System.Drawing.Point(347, 12);
            this.btnCategoryList.Name = "btnCategoryList";
            this.btnCategoryList.Size = new System.Drawing.Size(100, 37);
            this.btnCategoryList.TabIndex = 0;
            this.btnCategoryList.Text = "Kategori Liste";
            this.btnCategoryList.UseVisualStyleBackColor = true;
            this.btnCategoryList.Click += new System.EventHandler(this.btnCategoryList_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(440, 209);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtCategoryDescription
            // 
            this.txtCategoryDescription.Location = new System.Drawing.Point(112, 91);
            this.txtCategoryDescription.Multiline = true;
            this.txtCategoryDescription.Name = "txtCategoryDescription";
            this.txtCategoryDescription.Size = new System.Drawing.Size(216, 91);
            this.txtCategoryDescription.TabIndex = 2;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(112, 54);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(216, 20);
            this.txtCategoryName.TabIndex = 3;
            // 
            // btnCreateCategory
            // 
            this.btnCreateCategory.Location = new System.Drawing.Point(347, 55);
            this.btnCreateCategory.Name = "btnCreateCategory";
            this.btnCreateCategory.Size = new System.Drawing.Size(100, 37);
            this.btnCreateCategory.TabIndex = 4;
            this.btnCreateCategory.Text = "Kategori Ekle";
            this.btnCreateCategory.UseVisualStyleBackColor = true;
            this.btnCreateCategory.Click += new System.EventHandler(this.btnCreateCategory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kategori ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kategori Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kategori Açıklaması:";
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Location = new System.Drawing.Point(112, 20);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(216, 20);
            this.txtCategoryId.TabIndex = 8;
            // 
            // btnCategoryUpdate
            // 
            this.btnCategoryUpdate.Location = new System.Drawing.Point(347, 141);
            this.btnCategoryUpdate.Name = "btnCategoryUpdate";
            this.btnCategoryUpdate.Size = new System.Drawing.Size(100, 37);
            this.btnCategoryUpdate.TabIndex = 10;
            this.btnCategoryUpdate.Text = "Kategori Güncelle";
            this.btnCategoryUpdate.UseVisualStyleBackColor = true;
            this.btnCategoryUpdate.Click += new System.EventHandler(this.btnCategoryUpdate_Click);
            // 
            // btnCategoryDelete
            // 
            this.btnCategoryDelete.Location = new System.Drawing.Point(347, 98);
            this.btnCategoryDelete.Name = "btnCategoryDelete";
            this.btnCategoryDelete.Size = new System.Drawing.Size(100, 37);
            this.btnCategoryDelete.TabIndex = 9;
            this.btnCategoryDelete.Text = "Kategori Sil";
            this.btnCategoryDelete.UseVisualStyleBackColor = true;
            this.btnCategoryDelete.Click += new System.EventHandler(this.btnCategoryDelete_Click);
            // 
            // lblCategoryCount
            // 
            this.lblCategoryCount.AutoSize = true;
            this.lblCategoryCount.Location = new System.Drawing.Point(31, 30);
            this.lblCategoryCount.Name = "lblCategoryCount";
            this.lblCategoryCount.Size = new System.Drawing.Size(35, 13);
            this.lblCategoryCount.TabIndex = 11;
            this.lblCategoryCount.Text = "label4";
            this.lblCategoryCount.Click += new System.EventHandler(this.lblCategoryCount_Click);
            // 
            // Dapper
            // 
            this.Dapper.BackColor = System.Drawing.Color.DarkOrange;
            this.Dapper.Controls.Add(this.lblSeaFoodProductTotalPrice);
            this.Dapper.Controls.Add(this.lblAvgProductStock);
            this.Dapper.Controls.Add(this.lblProductCount);
            this.Dapper.Controls.Add(this.lblCategoryCount);
            this.Dapper.Location = new System.Drawing.Point(466, 12);
            this.Dapper.Name = "Dapper";
            this.Dapper.Size = new System.Drawing.Size(386, 385);
            this.Dapper.TabIndex = 12;
            this.Dapper.TabStop = false;
            this.Dapper.Text = "Dapper İstatistikler";
            // 
            // lblSeaFoodProductTotalPrice
            // 
            this.lblSeaFoodProductTotalPrice.AutoSize = true;
            this.lblSeaFoodProductTotalPrice.Location = new System.Drawing.Point(31, 152);
            this.lblSeaFoodProductTotalPrice.Name = "lblSeaFoodProductTotalPrice";
            this.lblSeaFoodProductTotalPrice.Size = new System.Drawing.Size(35, 13);
            this.lblSeaFoodProductTotalPrice.TabIndex = 14;
            this.lblSeaFoodProductTotalPrice.Text = "label4";
            // 
            // lblAvgProductStock
            // 
            this.lblAvgProductStock.AutoSize = true;
            this.lblAvgProductStock.Location = new System.Drawing.Point(31, 109);
            this.lblAvgProductStock.Name = "lblAvgProductStock";
            this.lblAvgProductStock.Size = new System.Drawing.Size(35, 13);
            this.lblAvgProductStock.TabIndex = 13;
            this.lblAvgProductStock.Text = "label4";
            // 
            // lblProductCount
            // 
            this.lblProductCount.AutoSize = true;
            this.lblProductCount.Location = new System.Drawing.Point(31, 66);
            this.lblProductCount.Name = "lblProductCount";
            this.lblProductCount.Size = new System.Drawing.Size(35, 13);
            this.lblProductCount.TabIndex = 12;
            this.lblProductCount.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 450);
            this.Controls.Add(this.Dapper);
            this.Controls.Add(this.btnCategoryUpdate);
            this.Controls.Add(this.btnCategoryDelete);
            this.Controls.Add(this.txtCategoryId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateCategory);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.txtCategoryDescription);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCategoryList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Dapper.ResumeLayout(false);
            this.Dapper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCategoryList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCategoryDescription;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Button btnCreateCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.Button btnCategoryUpdate;
        private System.Windows.Forms.Button btnCategoryDelete;
        private System.Windows.Forms.Label lblCategoryCount;
        private System.Windows.Forms.GroupBox Dapper;
        private System.Windows.Forms.Label lblSeaFoodProductTotalPrice;
        private System.Windows.Forms.Label lblAvgProductStock;
        private System.Windows.Forms.Label lblProductCount;
    }
}

