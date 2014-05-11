namespace OmegleSharp
{
    partial class CommonInterestsDialog
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
            this.lbTags = new System.Windows.Forms.ListBox();
            this.btnAddtag = new System.Windows.Forms.Button();
            this.btnRemovetag = new System.Windows.Forms.Button();
            this.tbAddTag = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbTags
            // 
            this.lbTags.FormattingEnabled = true;
            this.lbTags.Location = new System.Drawing.Point(3, 28);
            this.lbTags.Name = "lbTags";
            this.lbTags.Size = new System.Drawing.Size(285, 251);
            this.lbTags.TabIndex = 0;
            // 
            // btnAddtag
            // 
            this.btnAddtag.Location = new System.Drawing.Point(294, 292);
            this.btnAddtag.Name = "btnAddtag";
            this.btnAddtag.Size = new System.Drawing.Size(75, 23);
            this.btnAddtag.TabIndex = 1;
            this.btnAddtag.Text = "Add Tag";
            this.btnAddtag.UseVisualStyleBackColor = true;
            this.btnAddtag.Click += new System.EventHandler(this.btnAddtag_Click);
            // 
            // btnRemovetag
            // 
            this.btnRemovetag.Location = new System.Drawing.Point(294, 28);
            this.btnRemovetag.Name = "btnRemovetag";
            this.btnRemovetag.Size = new System.Drawing.Size(75, 42);
            this.btnRemovetag.TabIndex = 2;
            this.btnRemovetag.Text = "Remove This Tag";
            this.btnRemovetag.UseVisualStyleBackColor = true;
            this.btnRemovetag.Click += new System.EventHandler(this.btnRemovetag_Click);
            // 
            // tbAddTag
            // 
            this.tbAddTag.Location = new System.Drawing.Point(3, 292);
            this.tbAddTag.Name = "tbAddTag";
            this.tbAddTag.Size = new System.Drawing.Size(285, 20);
            this.tbAddTag.TabIndex = 3;
            // 
            // CommonInterestsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 327);
            this.Controls.Add(this.tbAddTag);
            this.Controls.Add(this.btnRemovetag);
            this.Controls.Add(this.btnAddtag);
            this.Controls.Add(this.lbTags);
            this.Name = "CommonInterestsDialog";
            this.Text = "CommonInterestsDialog";
            this.Load += new System.EventHandler(this.CommonInterestsDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTags;
        private System.Windows.Forms.Button btnAddtag;
        private System.Windows.Forms.Button btnRemovetag;
        private System.Windows.Forms.TextBox tbAddTag;

    }
}