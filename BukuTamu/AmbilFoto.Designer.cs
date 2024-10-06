namespace BukuTamu
{
    partial class AmbilFoto
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
            this.BtnAmbil = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.MenuWebcam = new System.Windows.Forms.ComboBox();
            this.PreviewFoto = new System.Windows.Forms.PictureBox();
            this.BtnMulai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAmbil
            // 
            this.BtnAmbil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAmbil.Location = new System.Drawing.Point(211, 333);
            this.BtnAmbil.Name = "BtnAmbil";
            this.BtnAmbil.Size = new System.Drawing.Size(111, 30);
            this.BtnAmbil.TabIndex = 1;
            this.BtnAmbil.Text = "Ambil Foto";
            this.BtnAmbil.UseVisualStyleBackColor = true;
            this.BtnAmbil.Click += new System.EventHandler(this.BtnAmbil_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(55, 333);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(111, 30);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.Text = "Kembali";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // MenuWebcam
            // 
            this.MenuWebcam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuWebcam.FormattingEnabled = true;
            this.MenuWebcam.Location = new System.Drawing.Point(77, 282);
            this.MenuWebcam.Name = "MenuWebcam";
            this.MenuWebcam.Size = new System.Drawing.Size(217, 28);
            this.MenuWebcam.TabIndex = 3;
            // 
            // PreviewFoto
            // 
            this.PreviewFoto.Location = new System.Drawing.Point(55, 59);
            this.PreviewFoto.Name = "PreviewFoto";
            this.PreviewFoto.Size = new System.Drawing.Size(267, 199);
            this.PreviewFoto.TabIndex = 0;
            this.PreviewFoto.TabStop = false;
            // 
            // BtnMulai
            // 
            this.BtnMulai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMulai.Location = new System.Drawing.Point(188, 28);
            this.BtnMulai.Name = "BtnMulai";
            this.BtnMulai.Size = new System.Drawing.Size(134, 25);
            this.BtnMulai.TabIndex = 4;
            this.BtnMulai.Text = "Aktifkan Kamera";
            this.BtnMulai.UseVisualStyleBackColor = true;
            // 
            // AmbilFoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(384, 386);
            this.Controls.Add(this.BtnMulai);
            this.Controls.Add(this.MenuWebcam);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnAmbil);
            this.Controls.Add(this.PreviewFoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "AmbilFoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buku Tamu - AmbilFoto";
            ((System.ComponentModel.ISupportInitialize)(this.PreviewFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PreviewFoto;
        private System.Windows.Forms.Button BtnAmbil;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.ComboBox MenuWebcam;
        private System.Windows.Forms.Button BtnMulai;
    }
}