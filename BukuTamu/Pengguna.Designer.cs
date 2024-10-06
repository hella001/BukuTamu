namespace BukuTamu
{
    partial class Pengguna
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
            this.GridAdmin = new System.Windows.Forms.DataGridView();
            this.GridUser = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDetailAdmin = new System.Windows.Forms.Button();
            this.BtnDetailUser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(62, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Admin";
            // 
            // GridAdmin
            // 
            this.GridAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAdmin.Location = new System.Drawing.Point(59, 119);
            this.GridAdmin.Name = "GridAdmin";
            this.GridAdmin.Size = new System.Drawing.Size(198, 297);
            this.GridAdmin.TabIndex = 1;
            // 
            // GridUser
            // 
            this.GridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridUser.Location = new System.Drawing.Point(311, 119);
            this.GridUser.Name = "GridUser";
            this.GridUser.Size = new System.Drawing.Size(198, 297);
            this.GridUser.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(314, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data User";
            // 
            // BtnDetailAdmin
            // 
            this.BtnDetailAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDetailAdmin.Location = new System.Drawing.Point(181, 85);
            this.BtnDetailAdmin.Name = "BtnDetailAdmin";
            this.BtnDetailAdmin.Size = new System.Drawing.Size(76, 30);
            this.BtnDetailAdmin.TabIndex = 5;
            this.BtnDetailAdmin.Text = "Detail";
            this.BtnDetailAdmin.UseVisualStyleBackColor = true;
            this.BtnDetailAdmin.Click += new System.EventHandler(this.BtnDetailAdmin_Click);
            // 
            // BtnDetailUser
            // 
            this.BtnDetailUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDetailUser.Location = new System.Drawing.Point(433, 85);
            this.BtnDetailUser.Name = "BtnDetailUser";
            this.BtnDetailUser.Size = new System.Drawing.Size(76, 30);
            this.BtnDetailUser.TabIndex = 9;
            this.BtnDetailUser.Text = "Detail";
            this.BtnDetailUser.UseVisualStyleBackColor = true;
            this.BtnDetailUser.Click += new System.EventHandler(this.BtnDetailUser_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(175, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pengguna Aktif";
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(472, 12);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(76, 30);
            this.BtnBack.TabIndex = 11;
            this.BtnBack.Text = "Kembali";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // Pengguna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnDetailUser);
            this.Controls.Add(this.BtnDetailAdmin);
            this.Controls.Add(this.GridUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GridAdmin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Pengguna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buku Tamu - Pengguna";
            ((System.ComponentModel.ISupportInitialize)(this.GridAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridAdmin;
        private System.Windows.Forms.DataGridView GridUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDetailAdmin;
        private System.Windows.Forms.Button BtnDetailUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnBack;
    }
}