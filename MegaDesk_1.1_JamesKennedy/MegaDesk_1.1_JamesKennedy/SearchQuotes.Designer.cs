namespace MegaDesk_3_JamesKennedy
{
    partial class SearchQuotes
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
            this.searchButton = new System.Windows.Forms.Button();
            this.MatComboBox = new System.Windows.Forms.ComboBox();
            this.ResultsView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(229, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(182, 26);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search by Material Type";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // MatComboBox
            // 
            this.MatComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatComboBox.FormattingEnabled = true;
            this.MatComboBox.Location = new System.Drawing.Point(12, 12);
            this.MatComboBox.Name = "MatComboBox";
            this.MatComboBox.Size = new System.Drawing.Size(211, 28);
            this.MatComboBox.TabIndex = 3;
            // 
            // ResultsView
            // 
            this.ResultsView.Location = new System.Drawing.Point(22, 64);
            this.ResultsView.Name = "ResultsView";
            this.ResultsView.Size = new System.Drawing.Size(389, 374);
            this.ResultsView.TabIndex = 4;
            this.ResultsView.UseCompatibleStateImageBehavior = false;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 450);
            this.Controls.Add(this.ResultsView);
            this.Controls.Add(this.MatComboBox);
            this.Controls.Add(this.searchButton);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.Load += new System.EventHandler(this.SearchQuotes_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox MatComboBox;
        private System.Windows.Forms.ListView ResultsView;
    }
}