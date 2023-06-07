
namespace grslprogodev
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
            this.label1 = new System.Windows.Forms.Label();
            this.rdbtntumu = new System.Windows.Forms.RadioButton();
            this.rdbtntek = new System.Windows.Forms.RadioButton();
            this.rdbtncift = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbitis = new System.Windows.Forms.TextBox();
            this.txtbaslangic = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(117, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayıların Toplamı";
            // 
            // rdbtntumu
            // 
            this.rdbtntumu.AutoSize = true;
            this.rdbtntumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtntumu.Location = new System.Drawing.Point(28, 108);
            this.rdbtntumu.Name = "rdbtntumu";
            this.rdbtntumu.Size = new System.Drawing.Size(66, 22);
            this.rdbtntumu.TabIndex = 1;
            this.rdbtntumu.TabStop = true;
            this.rdbtntumu.Text = "tümü";
            this.rdbtntumu.UseVisualStyleBackColor = true;
            // 
            // rdbtntek
            // 
            this.rdbtntek.AutoSize = true;
            this.rdbtntek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtntek.Location = new System.Drawing.Point(187, 108);
            this.rdbtntek.Name = "rdbtntek";
            this.rdbtntek.Size = new System.Drawing.Size(52, 22);
            this.rdbtntek.TabIndex = 1;
            this.rdbtntek.TabStop = true;
            this.rdbtntek.Text = "tek";
            this.rdbtntek.UseVisualStyleBackColor = true;
            // 
            // rdbtncift
            // 
            this.rdbtncift.AutoSize = true;
            this.rdbtncift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtncift.Location = new System.Drawing.Point(329, 108);
            this.rdbtncift.Name = "rdbtncift";
            this.rdbtncift.Size = new System.Drawing.Size(52, 22);
            this.rdbtncift.TabIndex = 1;
            this.rdbtncift.TabStop = true;
            this.rdbtncift.Text = "çift";
            this.rdbtncift.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Başlangıç:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(24, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bitiş:";
            // 
            // txtbitis
            // 
            this.txtbitis.Location = new System.Drawing.Point(187, 240);
            this.txtbitis.Name = "txtbitis";
            this.txtbitis.Size = new System.Drawing.Size(157, 22);
            this.txtbitis.TabIndex = 3;
            // 
            // txtbaslangic
            // 
            this.txtbaslangic.Location = new System.Drawing.Point(187, 193);
            this.txtbaslangic.Name = "txtbaslangic";
            this.txtbaslangic.Size = new System.Drawing.Size(157, 22);
            this.txtbaslangic.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(105, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsonuc.Location = new System.Drawing.Point(24, 393);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(80, 20);
            this.lblsonuc.TabIndex = 5;
            this.lblsonuc.Text = "SONUÇ:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(442, 450);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbaslangic);
            this.Controls.Add(this.txtbitis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdbtncift);
            this.Controls.Add(this.rdbtntek);
            this.Controls.Add(this.rdbtntumu);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "ödev2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbtntumu;
        private System.Windows.Forms.RadioButton rdbtntek;
        private System.Windows.Forms.RadioButton rdbtncift;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbitis;
        private System.Windows.Forms.TextBox txtbaslangic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblsonuc;
    }
}