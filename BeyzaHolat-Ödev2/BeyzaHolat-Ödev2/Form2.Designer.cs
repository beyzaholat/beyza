
namespace BeyzaHolat_Ödev2
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
            this.btnbeyaz = new System.Windows.Forms.Button();
            this.btnmor = new System.Windows.Forms.Button();
            this.btnsari = new System.Windows.Forms.Button();
            this.btnturkuaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnbeyaz
            // 
            this.btnbeyaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbeyaz.Location = new System.Drawing.Point(134, 52);
            this.btnbeyaz.Name = "btnbeyaz";
            this.btnbeyaz.Size = new System.Drawing.Size(163, 56);
            this.btnbeyaz.TabIndex = 0;
            this.btnbeyaz.Text = "BEYAZ";
            this.btnbeyaz.UseVisualStyleBackColor = true;
            this.btnbeyaz.Click += new System.EventHandler(this.btnbeyaz_DoubleClick);
            // 
            // btnmor
            // 
            this.btnmor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmor.Location = new System.Drawing.Point(134, 148);
            this.btnmor.Name = "btnmor";
            this.btnmor.Size = new System.Drawing.Size(163, 56);
            this.btnmor.TabIndex = 0;
            this.btnmor.Text = "MOR";
            this.btnmor.UseVisualStyleBackColor = true;
            this.btnmor.Click += new System.EventHandler(this.btnmor_DoubleClick);
            // 
            // btnsari
            // 
            this.btnsari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsari.Location = new System.Drawing.Point(134, 243);
            this.btnsari.Name = "btnsari";
            this.btnsari.Size = new System.Drawing.Size(163, 56);
            this.btnsari.TabIndex = 0;
            this.btnsari.Text = "SARI";
            this.btnsari.UseVisualStyleBackColor = true;
            this.btnsari.Click += new System.EventHandler(this.btnsari_DoubleClick);
            // 
            // btnturkuaz
            // 
            this.btnturkuaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnturkuaz.Location = new System.Drawing.Point(134, 337);
            this.btnturkuaz.Name = "btnturkuaz";
            this.btnturkuaz.Size = new System.Drawing.Size(163, 56);
            this.btnturkuaz.TabIndex = 0;
            this.btnturkuaz.Text = "TURKUAZ";
            this.btnturkuaz.UseVisualStyleBackColor = true;
            this.btnturkuaz.Click += new System.EventHandler(this.btnturkuaz_DoubleClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(443, 450);
            this.Controls.Add(this.btnturkuaz);
            this.Controls.Add(this.btnsari);
            this.Controls.Add(this.btnmor);
            this.Controls.Add(this.btnbeyaz);
            this.Name = "Form2";
            this.Text = "RENGARENK";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnbeyaz;
        private System.Windows.Forms.Button btnmor;
        private System.Windows.Forms.Button btnsari;
        private System.Windows.Forms.Button btnturkuaz;
    }
}