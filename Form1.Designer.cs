namespace _1903040168
{
    partial class Form1
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
            this.txt_bil1 = new System.Windows.Forms.TextBox();
            this.txt_bil2 = new System.Windows.Forms.TextBox();
            this.btn_jumlah = new System.Windows.Forms.Button();
            this.btn_kurang = new System.Windows.Forms.Button();
            this.btn_bagi = new System.Windows.Forms.Button();
            this.btn_kali = new System.Windows.Forms.Button();
            this.btn_mod = new System.Windows.Forms.Button();
            this.btn_pangkat = new System.Windows.Forms.Button();
            this.btn_akar = new System.Windows.Forms.Button();
            this.hasil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_bil1
            // 
            this.txt_bil1.Location = new System.Drawing.Point(62, 48);
            this.txt_bil1.Name = "txt_bil1";
            this.txt_bil1.Size = new System.Drawing.Size(150, 20);
            this.txt_bil1.TabIndex = 0;
            // 
            // txt_bil2
            // 
            this.txt_bil2.Location = new System.Drawing.Point(62, 74);
            this.txt_bil2.Name = "txt_bil2";
            this.txt_bil2.Size = new System.Drawing.Size(150, 20);
            this.txt_bil2.TabIndex = 1;
            // 
            // btn_jumlah
            // 
            this.btn_jumlah.Location = new System.Drawing.Point(62, 102);
            this.btn_jumlah.Name = "btn_jumlah";
            this.btn_jumlah.Size = new System.Drawing.Size(36, 23);
            this.btn_jumlah.TabIndex = 2;
            this.btn_jumlah.Text = "+";
            this.btn_jumlah.UseVisualStyleBackColor = true;
            this.btn_jumlah.Click += new System.EventHandler(this.btn_jumlah_Click);
            // 
            // btn_kurang
            // 
            this.btn_kurang.Location = new System.Drawing.Point(104, 102);
            this.btn_kurang.Name = "btn_kurang";
            this.btn_kurang.Size = new System.Drawing.Size(36, 23);
            this.btn_kurang.TabIndex = 3;
            this.btn_kurang.Text = "-";
            this.btn_kurang.UseVisualStyleBackColor = true;
            this.btn_kurang.Click += new System.EventHandler(this.btn_kurang_Click);
            // 
            // btn_bagi
            // 
            this.btn_bagi.Location = new System.Drawing.Point(146, 102);
            this.btn_bagi.Name = "btn_bagi";
            this.btn_bagi.Size = new System.Drawing.Size(36, 23);
            this.btn_bagi.TabIndex = 4;
            this.btn_bagi.Text = "/";
            this.btn_bagi.UseVisualStyleBackColor = true;
            this.btn_bagi.Click += new System.EventHandler(this.btn_bagi_Click);
            // 
            // btn_kali
            // 
            this.btn_kali.Location = new System.Drawing.Point(62, 131);
            this.btn_kali.Name = "btn_kali";
            this.btn_kali.Size = new System.Drawing.Size(36, 23);
            this.btn_kali.TabIndex = 5;
            this.btn_kali.Text = "x";
            this.btn_kali.UseVisualStyleBackColor = true;
            this.btn_kali.Click += new System.EventHandler(this.btn_kali_Click);
            // 
            // btn_mod
            // 
            this.btn_mod.Location = new System.Drawing.Point(104, 131);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.Size = new System.Drawing.Size(36, 23);
            this.btn_mod.TabIndex = 6;
            this.btn_mod.Text = "mod";
            this.btn_mod.UseVisualStyleBackColor = true;
            this.btn_mod.Click += new System.EventHandler(this.btn_mod_Click);
            // 
            // btn_pangkat
            // 
            this.btn_pangkat.Location = new System.Drawing.Point(146, 131);
            this.btn_pangkat.Name = "btn_pangkat";
            this.btn_pangkat.Size = new System.Drawing.Size(36, 23);
            this.btn_pangkat.TabIndex = 7;
            this.btn_pangkat.Text = "^";
            this.btn_pangkat.UseVisualStyleBackColor = true;
            this.btn_pangkat.Click += new System.EventHandler(this.btn_pangkat_Click);
            // 
            // btn_akar
            // 
            this.btn_akar.Location = new System.Drawing.Point(62, 160);
            this.btn_akar.Name = "btn_akar";
            this.btn_akar.Size = new System.Drawing.Size(36, 23);
            this.btn_akar.TabIndex = 8;
            this.btn_akar.Text = "√";
            this.btn_akar.UseVisualStyleBackColor = true;
            this.btn_akar.Click += new System.EventHandler(this.btn_akar_Click);
            // 
            // hasil
            // 
            this.hasil.AutoSize = true;
            this.hasil.Location = new System.Drawing.Point(105, 165);
            this.hasil.Name = "hasil";
            this.hasil.Size = new System.Drawing.Size(30, 13);
            this.hasil.TabIndex = 9;
            this.hasil.Text = "Hasil";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 261);
            this.Controls.Add(this.hasil);
            this.Controls.Add(this.btn_akar);
            this.Controls.Add(this.btn_pangkat);
            this.Controls.Add(this.btn_mod);
            this.Controls.Add(this.btn_kali);
            this.Controls.Add(this.btn_bagi);
            this.Controls.Add(this.btn_kurang);
            this.Controls.Add(this.btn_jumlah);
            this.Controls.Add(this.txt_bil2);
            this.Controls.Add(this.txt_bil1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_bil1;
        private System.Windows.Forms.TextBox txt_bil2;
        private System.Windows.Forms.Button btn_jumlah;
        private System.Windows.Forms.Button btn_kurang;
        private System.Windows.Forms.Button btn_bagi;
        private System.Windows.Forms.Button btn_kali;
        private System.Windows.Forms.Button btn_mod;
        private System.Windows.Forms.Button btn_pangkat;
        private System.Windows.Forms.Button btn_akar;
        private System.Windows.Forms.Label hasil;
    }
}

