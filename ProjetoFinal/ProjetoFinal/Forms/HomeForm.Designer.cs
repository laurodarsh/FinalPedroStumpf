﻿namespace ProjetoFinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUserProfile = new System.Windows.Forms.Label();
            this.lblLog = new System.Windows.Forms.Label();
            this.pbxLog = new System.Windows.Forms.PictureBox();
            this.pbxCategory = new System.Windows.Forms.PictureBox();
            this.pbxUserProfile = new System.Windows.Forms.PictureBox();
            this.pbxUser = new System.Windows.Forms.PictureBox();
            this.pbxProduct = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(71, 110);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(58, 17);
            this.lblProduct.TabIndex = 5;
            this.lblProduct.Text = "Produto";
            this.lblProduct.Visible = false;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(282, 110);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(69, 17);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Categoria";
            this.lblCategory.Visible = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(71, 242);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(57, 17);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "Usuário";
            this.lblUser.Visible = false;
            // 
            // lblUserProfile
            // 
            this.lblUserProfile.AutoSize = true;
            this.lblUserProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserProfile.Location = new System.Drawing.Point(264, 242);
            this.lblUserProfile.Name = "lblUserProfile";
            this.lblUserProfile.Size = new System.Drawing.Size(113, 17);
            this.lblUserProfile.TabIndex = 8;
            this.lblUserProfile.Text = "Perfil de Usuário";
            this.lblUserProfile.Visible = false;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLog.Location = new System.Drawing.Point(196, 355);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(32, 17);
            this.lblLog.TabIndex = 9;
            this.lblLog.Text = "Log";
            this.lblLog.Visible = false;
            // 
            // pbxLog
            // 
            this.pbxLog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxLog.BackgroundImage")));
            this.pbxLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxLog.Location = new System.Drawing.Point(156, 272);
            this.pbxLog.Name = "pbxLog";
            this.pbxLog.Size = new System.Drawing.Size(130, 80);
            this.pbxLog.TabIndex = 15;
            this.pbxLog.TabStop = false;
            this.pbxLog.Click += new System.EventHandler(this.pbxLog_Click);
            this.pbxLog.MouseEnter += new System.EventHandler(this.pbxLog_MouseEnter);
            this.pbxLog.MouseLeave += new System.EventHandler(this.pbxLog_MouseLeave);
            // 
            // pbxCategory
            // 
            this.pbxCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxCategory.BackgroundImage")));
            this.pbxCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxCategory.Location = new System.Drawing.Point(256, 23);
            this.pbxCategory.Name = "pbxCategory";
            this.pbxCategory.Size = new System.Drawing.Size(130, 80);
            this.pbxCategory.TabIndex = 14;
            this.pbxCategory.TabStop = false;
            this.pbxCategory.Click += new System.EventHandler(this.pbxCategory_Click);
            this.pbxCategory.MouseEnter += new System.EventHandler(this.pbxCategory_MouseEnter);
            this.pbxCategory.MouseLeave += new System.EventHandler(this.pbxCategory_MouseLeave);
            // 
            // pbxUserProfile
            // 
            this.pbxUserProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxUserProfile.BackgroundImage")));
            this.pbxUserProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxUserProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxUserProfile.Location = new System.Drawing.Point(256, 139);
            this.pbxUserProfile.Name = "pbxUserProfile";
            this.pbxUserProfile.Size = new System.Drawing.Size(130, 100);
            this.pbxUserProfile.TabIndex = 13;
            this.pbxUserProfile.TabStop = false;
            this.pbxUserProfile.Click += new System.EventHandler(this.pbxUserProfile_Click);
            this.pbxUserProfile.MouseEnter += new System.EventHandler(this.pbxUserProfile_MouseEnter);
            this.pbxUserProfile.MouseLeave += new System.EventHandler(this.pbxUserProfile_MouseLeave);
            // 
            // pbxUser
            // 
            this.pbxUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxUser.BackgroundImage")));
            this.pbxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxUser.Location = new System.Drawing.Point(35, 148);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(130, 80);
            this.pbxUser.TabIndex = 12;
            this.pbxUser.TabStop = false;
            this.pbxUser.Click += new System.EventHandler(this.pbxUser_Click);
            this.pbxUser.MouseEnter += new System.EventHandler(this.pbxUser_MouseEnter);
            this.pbxUser.MouseLeave += new System.EventHandler(this.pbxUser_MouseLeave);
            // 
            // pbxProduct
            // 
            this.pbxProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxProduct.BackgroundImage")));
            this.pbxProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxProduct.Location = new System.Drawing.Point(35, 23);
            this.pbxProduct.Name = "pbxProduct";
            this.pbxProduct.Size = new System.Drawing.Size(130, 80);
            this.pbxProduct.TabIndex = 11;
            this.pbxProduct.TabStop = false;
            this.pbxProduct.Click += new System.EventHandler(this.pbxProduct_Click);
            this.pbxProduct.MouseEnter += new System.EventHandler(this.pbxProduct_MouseEnter);
            this.pbxProduct.MouseLeave += new System.EventHandler(this.pbxProduct_MouseLeave);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(434, 381);
            this.Controls.Add(this.pbxLog);
            this.Controls.Add(this.pbxCategory);
            this.Controls.Add(this.pbxUserProfile);
            this.Controls.Add(this.pbxUser);
            this.Controls.Add(this.pbxProduct);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.lblUserProfile);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblProduct);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblUserProfile;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.PictureBox pbxProduct;
        private System.Windows.Forms.PictureBox pbxUser;
        private System.Windows.Forms.PictureBox pbxUserProfile;
        private System.Windows.Forms.PictureBox pbxCategory;
        private System.Windows.Forms.PictureBox pbxLog;
    }
}