namespace AksuSirketi
{
    partial class Form2
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
            this.linkcus = new System.Windows.Forms.LinkLabel();
            this.linksup = new System.Windows.Forms.LinkLabel();
            this.linkpdct = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkcus
            // 
            this.linkcus.AutoSize = true;
            this.linkcus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkcus.Location = new System.Drawing.Point(43, 108);
            this.linkcus.Name = "linkcus";
            this.linkcus.Size = new System.Drawing.Size(110, 20);
            this.linkcus.TabIndex = 0;
            this.linkcus.TabStop = true;
            this.linkcus.Text = "Müşteri Listesi";
            this.linkcus.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkcus_LinkClicked);
            // 
            // linksup
            // 
            this.linksup.AutoSize = true;
            this.linksup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linksup.Location = new System.Drawing.Point(269, 108);
            this.linksup.Name = "linksup";
            this.linksup.Size = new System.Drawing.Size(121, 20);
            this.linksup.TabIndex = 1;
            this.linksup.TabStop = true;
            this.linksup.Text = "Tedarikçi Listesi";
            this.linksup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linksup_LinkClicked);
            // 
            // linkpdct
            // 
            this.linkpdct.AutoSize = true;
            this.linkpdct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkpdct.Location = new System.Drawing.Point(481, 108);
            this.linkpdct.Name = "linkpdct";
            this.linkpdct.Size = new System.Drawing.Size(160, 20);
            this.linkpdct.TabIndex = 2;
            this.linkpdct.TabStop = true;
            this.linkpdct.Text = "Ürünlerin Fiyat Listesi";
            this.linkpdct.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkpdct_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(594, 255);
            this.dataGridView1.TabIndex = 3;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(47, 51);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(453, 20);
            this.txtsearch.TabIndex = 4;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(566, 51);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 5;
            this.btnsearch.Text = "Bul";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 450);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.linkpdct);
            this.Controls.Add(this.linksup);
            this.Controls.Add(this.linkcus);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Sayfası";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkcus;
        private System.Windows.Forms.LinkLabel linksup;
        private System.Windows.Forms.LinkLabel linkpdct;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnsearch;
    }
}