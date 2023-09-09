﻿namespace GUI.Product
{
    partial class AddProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCodeProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPriceProduct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCategoryProduct = new System.Windows.Forms.ComboBox();
            this.btnSaveAddProduct = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSaveAddProduct);
            this.panel1.Controls.Add(this.cbCategoryProduct);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPriceProduct);
            this.panel1.Controls.Add(this.txtNameProduct);
            this.panel1.Controls.Add(this.txtCodeProduct);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 278);
            this.panel1.TabIndex = 0;
            // 
            // txtCodeProduct
            // 
            this.txtCodeProduct.Location = new System.Drawing.Point(75, 56);
            this.txtCodeProduct.Name = "txtCodeProduct";
            this.txtCodeProduct.Size = new System.Drawing.Size(283, 20);
            this.txtCodeProduct.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sản phẩm";
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Location = new System.Drawing.Point(75, 103);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(283, 20);
            this.txtNameProduct.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sản phẩm";
            // 
            // txtPriceProduct
            // 
            this.txtPriceProduct.Location = new System.Drawing.Point(75, 152);
            this.txtPriceProduct.Name = "txtPriceProduct";
            this.txtPriceProduct.Size = new System.Drawing.Size(283, 20);
            this.txtPriceProduct.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giá sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Danh mục sản phẩm";
            // 
            // cbCategoryProduct
            // 
            this.cbCategoryProduct.FormattingEnabled = true;
            this.cbCategoryProduct.Location = new System.Drawing.Point(78, 200);
            this.cbCategoryProduct.Name = "cbCategoryProduct";
            this.cbCategoryProduct.Size = new System.Drawing.Size(280, 21);
            this.cbCategoryProduct.TabIndex = 2;
            // 
            // btnSaveAddProduct
            // 
            this.btnSaveAddProduct.Location = new System.Drawing.Point(263, 228);
            this.btnSaveAddProduct.Name = "btnSaveAddProduct";
            this.btnSaveAddProduct.Size = new System.Drawing.Size(94, 23);
            this.btnSaveAddProduct.TabIndex = 3;
            this.btnSaveAddProduct.Text = "Tạo sản phẩm";
            this.btnSaveAddProduct.UseVisualStyleBackColor = true;
            this.btnSaveAddProduct.Click += new System.EventHandler(this.btnSaveAddProduct_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 303);
            this.Controls.Add(this.panel1);
            this.Name = "AddProduct";
            this.Text = "Tạo mới sản phẩm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddProduct_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodeProduct;
        private System.Windows.Forms.Button btnSaveAddProduct;
        private System.Windows.Forms.ComboBox cbCategoryProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPriceProduct;
        private System.Windows.Forms.TextBox txtNameProduct;
    }
}