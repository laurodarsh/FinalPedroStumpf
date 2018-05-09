namespace ProjetoFinal
{
    partial class HomeForm
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
            this.pbxProduct = new System.Windows.Forms.PictureBox();
            this.pbxUserProfile = new System.Windows.Forms.PictureBox();
            this.pbxLog = new System.Windows.Forms.PictureBox();
            this.pbxCategory = new System.Windows.Forms.PictureBox();
            this.pbxUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxProduct
            // 
            this.pbxProduct.BackgroundImage = global::ProjetoFinal.Properties.Resources.Product;
            this.pbxProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxProduct.Location = new System.Drawing.Point(13, 23);
            this.pbxProduct.Name = "pbxProduct";
            this.pbxProduct.Size = new System.Drawing.Size(100, 50);
            this.pbxProduct.TabIndex = 0;
            this.pbxProduct.TabStop = false;
            // 
            // pbxUserProfile
            // 
            this.pbxUserProfile.BackgroundImage = global::ProjetoFinal.Properties.Resources.User;
            this.pbxUserProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxUserProfile.Location = new System.Drawing.Point(145, 108);
            this.pbxUserProfile.Name = "pbxUserProfile";
            this.pbxUserProfile.Size = new System.Drawing.Size(100, 50);
            this.pbxUserProfile.TabIndex = 1;
            this.pbxUserProfile.TabStop = false;
            // 
            // pbxLog
            // 
            this.pbxLog.BackgroundImage = global::ProjetoFinal.Properties.Resources.Log;
            this.pbxLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxLog.Location = new System.Drawing.Point(78, 180);
            this.pbxLog.Name = "pbxLog";
            this.pbxLog.Size = new System.Drawing.Size(100, 50);
            this.pbxLog.TabIndex = 2;
            this.pbxLog.TabStop = false;
            // 
            // pbxCategory
            // 
            this.pbxCategory.BackgroundImage = global::ProjetoFinal.Properties.Resources.Category;
            this.pbxCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxCategory.Location = new System.Drawing.Point(143, 23);
            this.pbxCategory.Name = "pbxCategory";
            this.pbxCategory.Size = new System.Drawing.Size(100, 50);
            this.pbxCategory.TabIndex = 3;
            this.pbxCategory.TabStop = false;
            // 
            // pbxUser
            // 
            this.pbxUser.BackgroundImage = global::ProjetoFinal.Properties.Resources.User_Profile;
            this.pbxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxUser.Location = new System.Drawing.Point(12, 108);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(100, 50);
            this.pbxUser.TabIndex = 4;
            this.pbxUser.TabStop = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 261);
            this.Controls.Add(this.pbxUser);
            this.Controls.Add(this.pbxCategory);
            this.Controls.Add(this.pbxLog);
            this.Controls.Add(this.pbxUserProfile);
            this.Controls.Add(this.pbxProduct);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbxProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxProduct;
        private System.Windows.Forms.PictureBox pbxUserProfile;
        private System.Windows.Forms.PictureBox pbxLog;
        private System.Windows.Forms.PictureBox pbxCategory;
        private System.Windows.Forms.PictureBox pbxUser;
    }
}