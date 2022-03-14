
namespace PraktikumWinforms
{
    partial class FormInput
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelNama = new System.Windows.Forms.Label();
            this.LabelAlamat = new System.Windows.Forms.Label();
            this.LabelTelp = new System.Windows.Forms.Label();
            this.ButtonSimpan = new System.Windows.Forms.Button();
            this.BtnSeeData = new System.Windows.Forms.Button();
            this.TxtBoxSimpanNama = new System.Windows.Forms.TextBox();
            this.TxtBoxSimpanAlm = new System.Windows.Forms.TextBox();
            this.TxtBoxTelp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelNama
            // 
            this.LabelNama.AutoSize = true;
            this.LabelNama.Location = new System.Drawing.Point(13, 53);
            this.LabelNama.Name = "LabelNama";
            this.LabelNama.Size = new System.Drawing.Size(56, 20);
            this.LabelNama.TabIndex = 0;
            this.LabelNama.Text = "Nama :";
            // 
            // LabelAlamat
            // 
            this.LabelAlamat.AutoSize = true;
            this.LabelAlamat.Location = new System.Drawing.Point(13, 92);
            this.LabelAlamat.Name = "LabelAlamat";
            this.LabelAlamat.Size = new System.Drawing.Size(64, 20);
            this.LabelAlamat.TabIndex = 1;
            this.LabelAlamat.Text = "Alamat :";
            // 
            // LabelTelp
            // 
            this.LabelTelp.AutoSize = true;
            this.LabelTelp.Location = new System.Drawing.Point(13, 133);
            this.LabelTelp.Name = "LabelTelp";
            this.LabelTelp.Size = new System.Drawing.Size(48, 20);
            this.LabelTelp.TabIndex = 2;
            this.LabelTelp.Text = "Telp : ";
            // 
            // ButtonSimpan
            // 
            this.ButtonSimpan.Location = new System.Drawing.Point(47, 203);
            this.ButtonSimpan.Name = "ButtonSimpan";
            this.ButtonSimpan.Size = new System.Drawing.Size(94, 29);
            this.ButtonSimpan.TabIndex = 3;
            this.ButtonSimpan.Text = "Simpan";
            this.ButtonSimpan.UseVisualStyleBackColor = true;
            this.ButtonSimpan.Click += new System.EventHandler(this.ButtonSimpan_Click);
            // 
            // BtnSeeData
            // 
            this.BtnSeeData.Location = new System.Drawing.Point(217, 203);
            this.BtnSeeData.Name = "BtnSeeData";
            this.BtnSeeData.Size = new System.Drawing.Size(94, 29);
            this.BtnSeeData.TabIndex = 4;
            this.BtnSeeData.Text = "Lihat Data";
            this.BtnSeeData.UseVisualStyleBackColor = true;
            this.BtnSeeData.Click += new System.EventHandler(this.BtnSeeData_Click);
            // 
            // TxtBoxSimpanNama
            // 
            this.TxtBoxSimpanNama.Location = new System.Drawing.Point(75, 53);
            this.TxtBoxSimpanNama.Name = "TxtBoxSimpanNama";
            this.TxtBoxSimpanNama.Size = new System.Drawing.Size(661, 27);
            this.TxtBoxSimpanNama.TabIndex = 5;
            this.TxtBoxSimpanNama.TextChanged += new System.EventHandler(this.TxtBoxSimpanNama_TextChanged);
            // 
            // TxtBoxSimpanAlm
            // 
            this.TxtBoxSimpanAlm.Location = new System.Drawing.Point(84, 92);
            this.TxtBoxSimpanAlm.Name = "TxtBoxSimpanAlm";
            this.TxtBoxSimpanAlm.Size = new System.Drawing.Size(652, 27);
            this.TxtBoxSimpanAlm.TabIndex = 6;
            this.TxtBoxSimpanAlm.TextChanged += new System.EventHandler(this.TxtBoxSimpanAlm_TextChanged);
            // 
            // TxtBoxTelp
            // 
            this.TxtBoxTelp.Location = new System.Drawing.Point(68, 133);
            this.TxtBoxTelp.Name = "TxtBoxTelp";
            this.TxtBoxTelp.Size = new System.Drawing.Size(222, 27);
            this.TxtBoxTelp.TabIndex = 7;
            this.TxtBoxTelp.TextChanged += new System.EventHandler(this.TxtBoxTelp_TextChanged);
            this.TxtBoxTelp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxTelp_KeyPress);
            // 
            // FormInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 278);
            this.Controls.Add(this.TxtBoxTelp);
            this.Controls.Add(this.TxtBoxSimpanAlm);
            this.Controls.Add(this.TxtBoxSimpanNama);
            this.Controls.Add(this.BtnSeeData);
            this.Controls.Add(this.ButtonSimpan);
            this.Controls.Add(this.LabelTelp);
            this.Controls.Add(this.LabelAlamat);
            this.Controls.Add(this.LabelNama);
            this.Name = "FormInput";
            this.Text = "Input Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNama;
        private System.Windows.Forms.Label LabelAlamat;
        private System.Windows.Forms.Label LabelTelp;
        private System.Windows.Forms.Button ButtonSimpan;
        private System.Windows.Forms.Button BtnSeeData;
        private System.Windows.Forms.TextBox TxtBoxSimpanNama;
        private System.Windows.Forms.TextBox TxtBoxSimpanAlm;
        private System.Windows.Forms.TextBox TxtBoxTelp;
    }
}

