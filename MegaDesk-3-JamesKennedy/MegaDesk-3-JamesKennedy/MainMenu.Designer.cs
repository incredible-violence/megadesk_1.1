namespace MegaDesk_3_JamesKennedy
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.addNewQuote = new System.Windows.Forms.Button();
            this.viewQuotes = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.searchQuotes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewQuote
            // 
            this.addNewQuote.Font = new System.Drawing.Font("Hack", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewQuote.Location = new System.Drawing.Point(12, 12);
            this.addNewQuote.Name = "addNewQuote";
            this.addNewQuote.Size = new System.Drawing.Size(207, 61);
            this.addNewQuote.TabIndex = 0;
            this.addNewQuote.Text = "Add New Quote";
            this.addNewQuote.UseVisualStyleBackColor = true;
            this.addNewQuote.Click += new System.EventHandler(this.addNewQuote_Click);
            // 
            // viewQuotes
            // 
            this.viewQuotes.Font = new System.Drawing.Font("Hack", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQuotes.Location = new System.Drawing.Point(12, 79);
            this.viewQuotes.Name = "viewQuotes";
            this.viewQuotes.Size = new System.Drawing.Size(207, 61);
            this.viewQuotes.TabIndex = 1;
            this.viewQuotes.Text = "View Quotes";
            this.viewQuotes.UseVisualStyleBackColor = true;
            this.viewQuotes.Click += new System.EventHandler(this.viewQuotes_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Hack", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(12, 213);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(207, 61);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // searchQuotes
            // 
            this.searchQuotes.Font = new System.Drawing.Font("Hack", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuotes.Location = new System.Drawing.Point(12, 146);
            this.searchQuotes.Name = "searchQuotes";
            this.searchQuotes.Size = new System.Drawing.Size(207, 61);
            this.searchQuotes.TabIndex = 2;
            this.searchQuotes.Text = "Search Quotes";
            this.searchQuotes.UseVisualStyleBackColor = true;
            this.searchQuotes.Click += new System.EventHandler(this.searchQuotes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(256, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 299);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.searchQuotes);
            this.Controls.Add(this.viewQuotes);
            this.Controls.Add(this.addNewQuote);
            this.Name = "MainMenu";
            this.Text = "MegaDesk";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addNewQuote;
        private System.Windows.Forms.Button viewQuotes;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button searchQuotes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

