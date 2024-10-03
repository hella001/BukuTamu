namespace BukuTamu
{
    partial class DataAdmin
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
            this.GridAdmin = new System.Windows.Forms.DataGridView();
            this.BtnTambah = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnHapus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // GridAdmin
            // 
            this.GridAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAdmin.Location = new System.Drawing.Point(28, 132);
            this.GridAdmin.Name = "GridAdmin";
            this.GridAdmin.Size = new System.Drawing.Size(464, 150);
            this.GridAdmin.TabIndex = 0;
            // 
            // BtnTambah
            // 
            this.BtnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTambah.Location = new System.Drawing.Point(28, 90);
            this.BtnTambah.Name = "BtnTambah";
            this.BtnTambah.Size = new System.Drawing.Size(114, 31);
            this.BtnTambah.TabIndex = 1;
            this.BtnTambah.Text = "Tambah Data";
            this.BtnTambah.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Location = new System.Drawing.Point(160, 90);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(114, 31);
            this.BtnEdit.TabIndex = 2;
            this.BtnEdit.Text = "Edit Data";
            this.BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnHapus
            // 
            this.BtnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHapus.Location = new System.Drawing.Point(294, 90);
            this.BtnHapus.Name = "BtnHapus";
            this.BtnHapus.Size = new System.Drawing.Size(114, 31);
            this.BtnHapus.TabIndex = 3;
            this.BtnHapus.Text = "Hapus Data";
            this.BtnHapus.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(145, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Detail Data Admin";
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(433, 12);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(76, 30);
            this.BtnBack.TabIndex = 12;
            this.BtnBack.Text = "Kembali";
            this.BtnBack.UseVisualStyleBackColor = true;
            // 
            // DataAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(521, 312);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnHapus);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnTambah);
            this.Controls.Add(this.GridAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DataAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buku Tamu - Data Admin";
            ((System.ComponentModel.ISupportInitialize)(this.GridAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridAdmin;
        private System.Windows.Forms.Button BtnTambah;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnHapus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBack;
    }
}