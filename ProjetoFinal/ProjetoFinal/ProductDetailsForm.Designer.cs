namespace ProjetoFinal
{
    partial class ProductDetailsForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cbxActive = new System.Windows.Forms.CheckBox();
            this.pbxDelete = new System.Windows.Forms.PictureBox();
            this.pbxAdd = new System.Windows.Forms.PictureBox();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome :";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(13, 57);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 13);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Preço :";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(13, 89);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(58, 13);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Categoria :";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(77, 19);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(121, 20);
            this.tbxName.TabIndex = 4;
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(77, 54);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(121, 20);
            this.tbxPrice.TabIndex = 6;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(77, 86);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbCategory.TabIndex = 7;
            // 
            // cbxActive
            // 
            this.cbxActive.AutoSize = true;
            this.cbxActive.Location = new System.Drawing.Point(16, 118);
            this.cbxActive.Name = "cbxActive";
            this.cbxActive.Size = new System.Drawing.Size(50, 17);
            this.cbxActive.TabIndex = 8;
            this.cbxActive.Text = "Ativo";
            this.cbxActive.UseVisualStyleBackColor = true;
            // 
            // pbxDelete
            // 
            this.pbxDelete.BackgroundImage = global::ProjetoFinal.Properties.Resources.delete;
            this.pbxDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxDelete.Location = new System.Drawing.Point(161, 160);
            this.pbxDelete.Name = "pbxDelete";
            this.pbxDelete.Size = new System.Drawing.Size(22, 20);
            this.pbxDelete.TabIndex = 10;
            this.pbxDelete.TabStop = false;
            // 
            // pbxAdd
            // 
            this.pbxAdd.BackgroundImage = global::ProjetoFinal.Properties.Resources.Add;
            this.pbxAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxAdd.Location = new System.Drawing.Point(189, 160);
            this.pbxAdd.Name = "pbxAdd";
            this.pbxAdd.Size = new System.Drawing.Size(22, 20);
            this.pbxAdd.TabIndex = 9;
            this.pbxAdd.TabStop = false;
            // 
            // pbxBack
            // 
            this.pbxBack.BackgroundImage = global::ProjetoFinal.Properties.Resources.Back;
            this.pbxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxBack.Location = new System.Drawing.Point(12, 160);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(22, 20);
            this.pbxBack.TabIndex = 12;
            this.pbxBack.TabStop = false;
            // 
            // ProductDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 192);
            this.Controls.Add(this.pbxBack);
            this.Controls.Add(this.pbxDelete);
            this.Controls.Add(this.pbxAdd);
            this.Controls.Add(this.cbxActive);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Name = "ProductDetailsForm";
            this.Text = "ProductDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.CheckBox cbxActive;
        private System.Windows.Forms.PictureBox pbxAdd;
        private System.Windows.Forms.PictureBox pbxDelete;
        private System.Windows.Forms.PictureBox pbxBack;
    }
}