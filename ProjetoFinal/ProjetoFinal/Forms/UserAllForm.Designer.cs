﻿namespace ProjetoFinal.Forms
{
    partial class UserAllForm
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
            this.pbxAdd = new System.Windows.Forms.PictureBox();
            this.pbxEdit = new System.Windows.Forms.PictureBox();
            this.pbxDelete = new System.Windows.Forms.PictureBox();
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            this.pbxSearch = new System.Windows.Forms.PictureBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxAdd
            // 
            this.pbxAdd.BackgroundImage = global::ProjetoFinal.Properties.Resources.Add;
            this.pbxAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxAdd.Location = new System.Drawing.Point(299, 269);
            this.pbxAdd.Name = "pbxAdd";
            this.pbxAdd.Size = new System.Drawing.Size(35, 30);
            this.pbxAdd.TabIndex = 33;
            this.pbxAdd.TabStop = false;
            // 
            // pbxEdit
            // 
            this.pbxEdit.BackgroundImage = global::ProjetoFinal.Properties.Resources.Edit;
            this.pbxEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxEdit.Location = new System.Drawing.Point(340, 269);
            this.pbxEdit.Name = "pbxEdit";
            this.pbxEdit.Size = new System.Drawing.Size(35, 30);
            this.pbxEdit.TabIndex = 32;
            this.pbxEdit.TabStop = false;
            // 
            // pbxDelete
            // 
            this.pbxDelete.BackgroundImage = global::ProjetoFinal.Properties.Resources.delete;
            this.pbxDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxDelete.Location = new System.Drawing.Point(387, 269);
            this.pbxDelete.Name = "pbxDelete";
            this.pbxDelete.Size = new System.Drawing.Size(35, 30);
            this.pbxDelete.TabIndex = 31;
            this.pbxDelete.TabStop = false;
            // 
            // dgvLog
            // 
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Location = new System.Drawing.Point(16, 50);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.Size = new System.Drawing.Size(406, 210);
            this.dgvLog.TabIndex = 30;
            // 
            // pbxBack
            // 
            this.pbxBack.BackgroundImage = global::ProjetoFinal.Properties.Resources.Back;
            this.pbxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxBack.Location = new System.Drawing.Point(12, 266);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(35, 30);
            this.pbxBack.TabIndex = 29;
            this.pbxBack.TabStop = false;
            // 
            // pbxSearch
            // 
            this.pbxSearch.BackgroundImage = global::ProjetoFinal.Properties.Resources.search;
            this.pbxSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSearch.Location = new System.Drawing.Point(374, 14);
            this.pbxSearch.Name = "pbxSearch";
            this.pbxSearch.Size = new System.Drawing.Size(35, 30);
            this.pbxSearch.TabIndex = 28;
            this.pbxSearch.TabStop = false;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(143, 21);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(150, 21);
            this.tbxSearch.TabIndex = 27;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(13, 24);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(79, 17);
            this.lblSearch.TabIndex = 26;
            this.lblSearch.Text = "Pesquisar :";
            // 
            // UserAllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.pbxAdd);
            this.Controls.Add(this.pbxEdit);
            this.Controls.Add(this.pbxDelete);
            this.Controls.Add(this.dgvLog);
            this.Controls.Add(this.pbxBack);
            this.Controls.Add(this.pbxSearch);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lblSearch);
            this.Name = "UserAllForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuário";
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxAdd;
        private System.Windows.Forms.PictureBox pbxEdit;
        private System.Windows.Forms.PictureBox pbxDelete;
        private System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.PictureBox pbxBack;
        private System.Windows.Forms.PictureBox pbxSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}