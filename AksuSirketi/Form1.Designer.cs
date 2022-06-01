namespace AksuSirketi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_user = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.btn_lgn = new System.Windows.Forms.Button();
            this.btn_ext = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_user.Location = new System.Drawing.Point(49, 70);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(97, 20);
            this.lbl_user.TabIndex = 0;
            this.lbl_user.Text = "Kullanıcı Adı:";
            // 
            // txt_user
            // 
            this.txt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_user.Location = new System.Drawing.Point(174, 67);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(202, 26);
            this.txt_user.TabIndex = 1;
            // 
            // btn_lgn
            // 
            this.btn_lgn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_lgn.Location = new System.Drawing.Point(174, 163);
            this.btn_lgn.Name = "btn_lgn";
            this.btn_lgn.Size = new System.Drawing.Size(78, 29);
            this.btn_lgn.TabIndex = 2;
            this.btn_lgn.Text = "Giriş";
            this.btn_lgn.UseVisualStyleBackColor = true;
            this.btn_lgn.Click += new System.EventHandler(this.btn_lgn_Click);
            // 
            // btn_ext
            // 
            this.btn_ext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ext.Location = new System.Drawing.Point(298, 163);
            this.btn_ext.Name = "btn_ext";
            this.btn_ext.Size = new System.Drawing.Size(78, 29);
            this.btn_ext.TabIndex = 5;
            this.btn_ext.Text = "Çıkış";
            this.btn_ext.UseVisualStyleBackColor = true;
            this.btn_ext.Click += new System.EventHandler(this.btn_ext_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_pass.Location = new System.Drawing.Point(174, 112);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(202, 26);
            this.txt_pass.TabIndex = 4;
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_pass.Location = new System.Drawing.Point(100, 115);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(46, 20);
            this.lbl_pass.TabIndex = 3;
            this.lbl_pass.Text = "Şifre:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 257);
            this.Controls.Add(this.btn_ext);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.btn_lgn);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.lbl_user);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Button btn_lgn;
        private System.Windows.Forms.Button btn_ext;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label lbl_pass;
    }
}

