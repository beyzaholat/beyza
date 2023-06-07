
namespace BeyzaHolat_Ödev2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtbxelemanekle = new System.Windows.Forms.TextBox();
            this.txtbxelemangoster = new System.Windows.Forms.TextBox();
            this.btntmzle = new System.Windows.Forms.Button();
            this.btnelemanekle = new System.Windows.Forms.Button();
            this.btnsirala = new System.Windows.Forms.Button();
            this.btnelemangoster = new System.Windows.Forms.Button();
            this.btnsay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(244, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(332, 420);
            this.listBox1.TabIndex = 0;
            // 
            // txtbxelemanekle
            // 
            this.txtbxelemanekle.Location = new System.Drawing.Point(38, 102);
            this.txtbxelemanekle.Name = "txtbxelemanekle";
            this.txtbxelemanekle.Size = new System.Drawing.Size(158, 22);
            this.txtbxelemanekle.TabIndex = 1;
            // 
            // txtbxelemangoster
            // 
            this.txtbxelemangoster.Enabled = false;
            this.txtbxelemangoster.Location = new System.Drawing.Point(38, 208);
            this.txtbxelemangoster.Name = "txtbxelemangoster";
            this.txtbxelemangoster.Size = new System.Drawing.Size(158, 22);
            this.txtbxelemangoster.TabIndex = 1;
            // 
            // btntmzle
            // 
            this.btntmzle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntmzle.Location = new System.Drawing.Point(643, 44);
            this.btntmzle.Name = "btntmzle";
            this.btntmzle.Size = new System.Drawing.Size(165, 56);
            this.btntmzle.TabIndex = 2;
            this.btntmzle.Text = "TEMİZLE";
            this.btntmzle.UseVisualStyleBackColor = true;
            this.btntmzle.Click += new System.EventHandler(this.btntmzle_Click);
            // 
            // btnelemanekle
            // 
            this.btnelemanekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnelemanekle.Location = new System.Drawing.Point(643, 133);
            this.btnelemanekle.Name = "btnelemanekle";
            this.btnelemanekle.Size = new System.Drawing.Size(165, 56);
            this.btnelemanekle.TabIndex = 2;
            this.btnelemanekle.Text = "ELEMAN EKLE";
            this.btnelemanekle.UseVisualStyleBackColor = true;
            this.btnelemanekle.Click += new System.EventHandler(this.btnelemanekle_Click);
            // 
            // btnsirala
            // 
            this.btnsirala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsirala.Location = new System.Drawing.Point(643, 225);
            this.btnsirala.Name = "btnsirala";
            this.btnsirala.Size = new System.Drawing.Size(165, 56);
            this.btnsirala.TabIndex = 2;
            this.btnsirala.Text = "SIRALA";
            this.btnsirala.UseVisualStyleBackColor = true;
            this.btnsirala.Click += new System.EventHandler(this.btnsirala_Click);
            // 
            // btnelemangoster
            // 
            this.btnelemangoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnelemangoster.Location = new System.Drawing.Point(643, 316);
            this.btnelemangoster.Name = "btnelemangoster";
            this.btnelemangoster.Size = new System.Drawing.Size(165, 56);
            this.btnelemangoster.TabIndex = 2;
            this.btnelemangoster.Text = "SEÇİLİ ELEMANI GÖSTER";
            this.btnelemangoster.UseVisualStyleBackColor = true;
            this.btnelemangoster.Click += new System.EventHandler(this.btnelemangoster_Click);
            // 
            // btnsay
            // 
            this.btnsay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsay.Location = new System.Drawing.Point(643, 408);
            this.btnsay.Name = "btnsay";
            this.btnsay.Size = new System.Drawing.Size(165, 56);
            this.btnsay.TabIndex = 2;
            this.btnsay.Text = "SAY";
            this.btnsay.UseVisualStyleBackColor = true;
            this.btnsay.Click += new System.EventHandler(this.btnsay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(855, 515);
            this.Controls.Add(this.btnsay);
            this.Controls.Add(this.btnelemangoster);
            this.Controls.Add(this.btnsirala);
            this.Controls.Add(this.btnelemanekle);
            this.Controls.Add(this.btntmzle);
            this.Controls.Add(this.txtbxelemangoster);
            this.Controls.Add(this.txtbxelemanekle);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Eleman İşlemleri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtbxelemanekle;
        private System.Windows.Forms.TextBox txtbxelemangoster;
        private System.Windows.Forms.Button btntmzle;
        private System.Windows.Forms.Button btnelemanekle;
        private System.Windows.Forms.Button btnsirala;
        private System.Windows.Forms.Button btnelemangoster;
        private System.Windows.Forms.Button btnsay;
    }
}

