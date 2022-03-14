
namespace PraktikumWinforms
{
    partial class FormData
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
            this.LblSimpanNama = new System.Windows.Forms.Label();
            this.LblSimpanAlamat = new System.Windows.Forms.Label();
            this.LabelSimpanTelp = new System.Windows.Forms.Label();
            this.BtnKembali = new System.Windows.Forms.Button();
            this.BtnPrevData = new System.Windows.Forms.Button();
            this.BtnNextData = new System.Windows.Forms.Button();
            this.BoxTampilNama = new System.Windows.Forms.TextBox();
            this.BoxTampilAlamat = new System.Windows.Forms.TextBox();
            this.TampilTelp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblSimpanNama
            // 
            this.LblSimpanNama.AutoSize = true;
            this.LblSimpanNama.Location = new System.Drawing.Point(13, 55);
            this.LblSimpanNama.Name = "LblSimpanNama";
            this.LblSimpanNama.Size = new System.Drawing.Size(56, 20);
            this.LblSimpanNama.TabIndex = 0;
            this.LblSimpanNama.Text = "Nama :";
            // 
            // LblSimpanAlamat
            // 
            this.LblSimpanAlamat.AutoSize = true;
            this.LblSimpanAlamat.Location = new System.Drawing.Point(13, 94);
            this.LblSimpanAlamat.Name = "LblSimpanAlamat";
            this.LblSimpanAlamat.Size = new System.Drawing.Size(64, 20);
            this.LblSimpanAlamat.TabIndex = 1;
            this.LblSimpanAlamat.Text = "Alamat :";
            // 
            // LabelSimpanTelp
            // 
            this.LabelSimpanTelp.AutoSize = true;
            this.LabelSimpanTelp.Location = new System.Drawing.Point(13, 135);
            this.LabelSimpanTelp.Name = "LabelSimpanTelp";
            this.LabelSimpanTelp.Size = new System.Drawing.Size(48, 20);
            this.LabelSimpanTelp.TabIndex = 2;
            this.LabelSimpanTelp.Text = "Telp : ";
            // 
            // BtnKembali
            // 
            this.BtnKembali.Location = new System.Drawing.Point(32, 189);
            this.BtnKembali.Name = "BtnKembali";
            this.BtnKembali.Size = new System.Drawing.Size(94, 29);
            this.BtnKembali.TabIndex = 3;
            this.BtnKembali.Text = "Kembali";
            this.BtnKembali.UseVisualStyleBackColor = true;
            this.BtnKembali.Click += new System.EventHandler(this.BtnKembali_Click);
            // 
            // BtnPrevData
            // 
            this.BtnPrevData.Location = new System.Drawing.Point(178, 189);
            this.BtnPrevData.Name = "BtnPrevData";
            this.BtnPrevData.Size = new System.Drawing.Size(94, 29);
            this.BtnPrevData.TabIndex = 4;
            this.BtnPrevData.Text = "Prev Data";
            this.BtnPrevData.UseVisualStyleBackColor = true;
            this.BtnPrevData.Click += new System.EventHandler(this.BtnPrevData_Click);
            // 
            // BtnNextData
            // 
            this.BtnNextData.Location = new System.Drawing.Point(333, 189);
            this.BtnNextData.Name = "BtnNextData";
            this.BtnNextData.Size = new System.Drawing.Size(94, 29);
            this.BtnNextData.TabIndex = 5;
            this.BtnNextData.Text = "Next Data";
            this.BtnNextData.UseVisualStyleBackColor = true;
            this.BtnNextData.Click += new System.EventHandler(this.BtnNextData_Click);
            // 
            // BoxTampilNama
            // 
            this.BoxTampilNama.Enabled = false;
            this.BoxTampilNama.Location = new System.Drawing.Point(76, 55);
            this.BoxTampilNama.Name = "BoxTampilNama";
            this.BoxTampilNama.Size = new System.Drawing.Size(729, 27);
            this.BoxTampilNama.TabIndex = 6;
            this.BoxTampilNama.TextChanged += new System.EventHandler(this.BoxTampilNama_TextChanged);
            // 
            // BoxTampilAlamat
            // 
            this.BoxTampilAlamat.Enabled = false;
            this.BoxTampilAlamat.Location = new System.Drawing.Point(76, 94);
            this.BoxTampilAlamat.Name = "BoxTampilAlamat";
            this.BoxTampilAlamat.Size = new System.Drawing.Size(721, 27);
            this.BoxTampilAlamat.TabIndex = 7;
            this.BoxTampilAlamat.TextChanged += new System.EventHandler(this.BoxTampilAlamat_TextChanged);
            // 
            // TampilTelp
            // 
            this.TampilTelp.Enabled = false;
            this.TampilTelp.Location = new System.Drawing.Point(76, 135);
            this.TampilTelp.Name = "TampilTelp";
            this.TampilTelp.Size = new System.Drawing.Size(318, 27);
            this.TampilTelp.TabIndex = 8;
            this.TampilTelp.TextChanged += new System.EventHandler(this.TampilTelp_TextChanged);
            // 
            // FormData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 281);
            this.Controls.Add(this.TampilTelp);
            this.Controls.Add(this.BoxTampilAlamat);
            this.Controls.Add(this.BoxTampilNama);
            this.Controls.Add(this.BtnNextData);
            this.Controls.Add(this.BtnPrevData);
            this.Controls.Add(this.BtnKembali);
            this.Controls.Add(this.LabelSimpanTelp);
            this.Controls.Add(this.LblSimpanAlamat);
            this.Controls.Add(this.LblSimpanNama);
            this.Name = "FormData";
            this.Text = "Tampil Data";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSimpanNama;
        private System.Windows.Forms.Label LblSimpanAlamat;
        private System.Windows.Forms.Label LabelSimpanTelp;
        private System.Windows.Forms.Button BtnKembali;
        private System.Windows.Forms.Button BtnPrevData;
        private System.Windows.Forms.Button BtnNextData;
        private System.Windows.Forms.TextBox BoxTampilNama;
        private System.Windows.Forms.TextBox BoxTampilAlamat;
        private System.Windows.Forms.TextBox TampilTelp;
    }
}