
namespace BeyzaHolat_Ödev4
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            this.progressBarSaat = new System.Windows.Forms.ProgressBar();
            this.progressBarDakika = new System.Windows.Forms.ProgressBar();
            this.progressBarSaniye = new System.Windows.Forms.ProgressBar();
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblDakika = new System.Windows.Forms.Label();
            this.lblSaniye = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // progressBarSaat
            // 
            this.progressBarSaat.Location = new System.Drawing.Point(67, 79);
            this.progressBarSaat.Name = "progressBarSaat";
            this.progressBarSaat.Size = new System.Drawing.Size(100, 23);
            this.progressBarSaat.TabIndex = 0;
            // 
            // progressBarDakika
            // 
            this.progressBarDakika.Location = new System.Drawing.Point(188, 79);
            this.progressBarDakika.Name = "progressBarDakika";
            this.progressBarDakika.Size = new System.Drawing.Size(100, 23);
            this.progressBarDakika.TabIndex = 1;
            // 
            // progressBarSaniye
            // 
            this.progressBarSaniye.Location = new System.Drawing.Point(312, 79);
            this.progressBarSaniye.Name = "progressBarSaniye";
            this.progressBarSaniye.Size = new System.Drawing.Size(100, 23);
            this.progressBarSaniye.TabIndex = 2;
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.Location = new System.Drawing.Point(64, 125);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(47, 20);
            this.lblSaat.TabIndex = 3;
            this.lblSaat.Text = "Saat";
            // 
            // lblDakika
            // 
            this.lblDakika.AutoSize = true;
            this.lblDakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDakika.Location = new System.Drawing.Point(185, 125);
            this.lblDakika.Name = "lblDakika";
            this.lblDakika.Size = new System.Drawing.Size(66, 20);
            this.lblDakika.TabIndex = 3;
            this.lblDakika.Text = "Dakika";
            // 
            // lblSaniye
            // 
            this.lblSaniye.AutoSize = true;
            this.lblSaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaniye.Location = new System.Drawing.Point(309, 125);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(65, 20);
            this.lblSaniye.TabIndex = 3;
            this.lblSaniye.Text = "Saniye";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(502, 192);
            this.Controls.Add(this.lblSaniye);
            this.Controls.Add(this.lblDakika);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.progressBarSaniye);
            this.Controls.Add(this.progressBarDakika);
            this.Controls.Add(this.progressBarSaat);
            this.Name = "Form5";
            this.Text = "Saat";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarSaat;
        private System.Windows.Forms.ProgressBar progressBarDakika;
        private System.Windows.Forms.ProgressBar progressBarSaniye;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblDakika;
        private System.Windows.Forms.Label lblSaniye;
        private System.Windows.Forms.Timer timer1;
    }
}