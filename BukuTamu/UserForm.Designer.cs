namespace BukuTamu
{
    partial class UserForm
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
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.JmlTamu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnEksport = new System.Windows.Forms.Button();
            this.GridTamu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnKeluar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridTamu)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefresh.Location = new System.Drawing.Point(641, 136);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(134, 38);
            this.BtnRefresh.TabIndex = 17;
            this.BtnRefresh.Text = "Perbarui Data";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(206, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Orang";
            // 
            // JmlTamu
            // 
            this.JmlTamu.AutoSize = true;
            this.JmlTamu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JmlTamu.ForeColor = System.Drawing.SystemColors.Control;
            this.JmlTamu.Location = new System.Drawing.Point(174, 99);
            this.JmlTamu.Name = "JmlTamu";
            this.JmlTamu.Size = new System.Drawing.Size(20, 22);
            this.JmlTamu.TabIndex = 15;
            this.JmlTamu.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(27, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Total Kunjungan:";
            // 
            // BtnEksport
            // 
            this.BtnEksport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEksport.Location = new System.Drawing.Point(641, 198);
            this.BtnEksport.Name = "BtnEksport";
            this.BtnEksport.Size = new System.Drawing.Size(134, 38);
            this.BtnEksport.TabIndex = 12;
            this.BtnEksport.Text = "Eksport Data";
            this.BtnEksport.UseVisualStyleBackColor = true;
            // 
            // GridTamu
            // 
            this.GridTamu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTamu.Location = new System.Drawing.Point(31, 135);
            this.GridTamu.Name = "GridTamu";
            this.GridTamu.Size = new System.Drawing.Size(595, 267);
            this.GridTamu.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(283, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Rakap Kunjungan";
            // 
            // BtnKeluar
            // 
            this.BtnKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKeluar.Location = new System.Drawing.Point(641, 400);
            this.BtnKeluar.Name = "BtnKeluar";
            this.BtnKeluar.Size = new System.Drawing.Size(134, 38);
            this.BtnKeluar.TabIndex = 18;
            this.BtnKeluar.Text = "Keluar";
            this.BtnKeluar.UseVisualStyleBackColor = true;
            this.BtnKeluar.Click += new System.EventHandler(this.BtnKeluar_Click);
            // 
            // UserForm
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
            this.Controls.Add(this.BtnEksport);
            this.Controls.Add(this.GridTamu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buku Tamu - User";
            ((System.ComponentModel.ISupportInitialize)(this.GridTamu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label JmlTamu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnEksport;
        private System.Windows.Forms.DataGridView GridTamu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnKeluar;
    }
}