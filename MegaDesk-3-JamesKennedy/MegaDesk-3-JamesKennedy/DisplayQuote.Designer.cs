namespace MegaDesk_3_JamesKennedy
{
    partial class DisplayQuote
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
            this.customerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Location = new System.Drawing.Point(12, 13);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(79, 13);
            this.customerName.TabIndex = 0;
            this.customerName.Text = "CustomerName";
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customerName);
            this.Name = "DisplayQuote";
            this.Text = "Display a Quote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerName;
    }
}