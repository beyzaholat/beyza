
namespace BeyzaHolat_Ödev4
{
    partial class Form3
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
            this.txtBxSayi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBxSayi
            // 
            this.txtBxSayi.Location = new System.Drawing.Point(94, 134);
            this.txtBxSayi.Name = "txtBxSayi";
            this.txtBxSayi.Size = new System.Drawing.Size(213, 22);
            this.txtBxSayi.TabIndex = 0;
            this.txtBxSayi.TextChanged += new System.EventHandler(this.txtBxSayi_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(404, 288);
            this.Controls.Add(this.txtBxSayi);
            this.Name = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxSayi;
    }
}