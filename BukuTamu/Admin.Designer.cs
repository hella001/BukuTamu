namespace BukuTamu
{
    partial class Admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.GridTamu = new System.Windows.Forms.DataGridView();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnEksport = new System.Windows.Forms.Button();
            this.BtnUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.JmlTamu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnKeluar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridTamu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(286, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rakap Kunjungan";
            // 
            // GridTamu
            // 
            this.GridTamu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTamu.Location = new System.Drawing.Point(34, 134);
            this.GridTamu.Name = "GridTamu";
            this.GridTamu.Size = new System.Drawing.Size(595, 267);
            this.GridTamu.TabIndex = 1;
            this.GridTamu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridTamu_CellContentClick);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Location = new System.Drawing.Point(644, 197);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(134, 38);
            this.BtnEdit.TabIndex = 2;
            this.BtnEdit.Text = "Edit Data";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnEksport
            // 
            this.BtnEksport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEksport.Location = new System.Drawing.Point(644, 263);
            this.BtnEksport.Name = "BtnEksport";
            this.BtnEksport.Size = new System.Drawing.Size(134, 38);
            this.BtnEksport.TabIndex = 3;
            this.BtnEksport.Text = "Eksport Data";
            this.BtnEksport.UseVisualStyleBackColor = true;
            this.BtnEksport.Click += new System.EventHandler(this.BtnEksport_Click);
            // 
            // BtnUser
            // 
            this.BtnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUser.Location = new System.Drawing.Point(644, 332);
            this.BtnUser.Name = "BtnUser";
            this.BtnUser.Size = new System.Drawing.Size(134, 38);
            this.BtnUser.TabIndex = 4;
            this.BtnUser.Text = "Pengguna";
            this.BtnUser.UseVisualStyleBackColor = true;
            this.BtnUser.Click += new System.EventHandler(this.BtnUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(30, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Kunjungan:";
            // 
            // JmlTamu
            // 
            this.JmlTamu.AutoSize = true;
            this.JmlTamu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JmlTamu.ForeColor = System.Drawing.SystemColors.Control;
            this.JmlTamu.Location = new System.Drawing.Point(177, 98);
            this.JmlTamu.Name = "JmlTamu";
            this.JmlTamu.Size = new System.Drawing.Size(20, 22);
            this.JmlTamu.TabIndex = 6;
            this.JmlTamu.Text = "5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(209, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Orang";
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefresh.Location = new System.Drawing.Point(644, 135);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(134, 38);
            this.BtnRefresh.TabIndex = 8;
            this.BtnRefresh.Text = "Perbarui Data";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnKeluar
            // 
            this.BtnKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKeluar.Location = new System.Drawing.Point(644, 400);
            this.BtnKeluar.Name = "BtnKeluar";
            this.BtnKeluar.Size = new System.Drawing.Size(134, 38);
            this.BtnKeluar.TabIndex = 9;
            this.BtnKeluar.Text = "Keluar";
            this.BtnKeluar.UseVisualStyleBackColor = true;
            this.BtnKeluar.Click += new System.EventHandler(this.BtnKeluar_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnKeluar);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.JmlTamu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnUser);
            this.Controls.Add(this.BtnEksport);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.GridTamu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buku Tamu - Admin";
            ((System.ComponentModel.ISupportInitialize)(this.GridTamu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridTamu;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnEksport;
        private System.Windows.Forms.Button BtnUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label JmlTamu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnKeluar;
    }
}