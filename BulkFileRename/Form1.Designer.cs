namespace BulkFileRename
{
    partial class Form1
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
            this.folderTxtBx = new System.Windows.Forms.TextBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.elapsedLabel = new System.Windows.Forms.Label();
            this.remainingLabel = new System.Windows.Forms.Label();
            this.elapsedVal = new System.Windows.Forms.Label();
            this.remainingVal = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusVal = new System.Windows.Forms.Label();
            this.currentLbl = new System.Windows.Forms.Label();
            this.newLbl = new System.Windows.Forms.Label();
            this.currentTxt = new System.Windows.Forms.TextBox();
            this.newTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // folderTxtBx
            // 
            this.folderTxtBx.Location = new System.Drawing.Point(13, 13);
            this.folderTxtBx.Name = "folderTxtBx";
            this.folderTxtBx.Size = new System.Drawing.Size(259, 20);
            this.folderTxtBx.TabIndex = 0;
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(303, 11);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(75, 23);
            this.browseBtn.TabIndex = 1;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // elapsedLabel
            // 
            this.elapsedLabel.AutoSize = true;
            this.elapsedLabel.Location = new System.Drawing.Point(12, 89);
            this.elapsedLabel.Name = "elapsedLabel";
            this.elapsedLabel.Size = new System.Drawing.Size(71, 13);
            this.elapsedLabel.TabIndex = 10;
            this.elapsedLabel.Text = "Time Elapsed";
            this.elapsedLabel.Visible = false;
            // 
            // remainingLabel
            // 
            this.remainingLabel.AutoSize = true;
            this.remainingLabel.Location = new System.Drawing.Point(12, 102);
            this.remainingLabel.Name = "remainingLabel";
            this.remainingLabel.Size = new System.Drawing.Size(132, 13);
            this.remainingLabel.TabIndex = 11;
            this.remainingLabel.Text = "Estimated Time Remaining";
            this.remainingLabel.Visible = false;
            // 
            // elapsedVal
            // 
            this.elapsedVal.AutoSize = true;
            this.elapsedVal.Location = new System.Drawing.Point(150, 89);
            this.elapsedVal.Name = "elapsedVal";
            this.elapsedVal.Size = new System.Drawing.Size(62, 13);
            this.elapsedVal.TabIndex = 12;
            this.elapsedVal.Text = "placeholder";
            this.elapsedVal.Visible = false;
            // 
            // remainingVal
            // 
            this.remainingVal.AutoSize = true;
            this.remainingVal.Location = new System.Drawing.Point(150, 102);
            this.remainingVal.Name = "remainingVal";
            this.remainingVal.Size = new System.Drawing.Size(62, 13);
            this.remainingVal.TabIndex = 13;
            this.remainingVal.Text = "placeholder";
            this.remainingVal.Visible = false;
            // 
            // okBtn
            // 
            this.okBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.okBtn.Location = new System.Drawing.Point(0, 170);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(390, 23);
            this.okBtn.TabIndex = 14;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Status";
            // 
            // statusVal
            // 
            this.statusVal.AutoSize = true;
            this.statusVal.Location = new System.Drawing.Point(150, 115);
            this.statusVal.Name = "statusVal";
            this.statusVal.Size = new System.Drawing.Size(62, 13);
            this.statusVal.TabIndex = 16;
            this.statusVal.Text = "placeholder";
            // 
            // currentLbl
            // 
            this.currentLbl.AutoSize = true;
            this.currentLbl.Location = new System.Drawing.Point(10, 43);
            this.currentLbl.Name = "currentLbl";
            this.currentLbl.Size = new System.Drawing.Size(97, 13);
            this.currentLbl.TabIndex = 17;
            this.currentLbl.Text = "Current text pattern";
            // 
            // newLbl
            // 
            this.newLbl.AutoSize = true;
            this.newLbl.Location = new System.Drawing.Point(10, 69);
            this.newLbl.Name = "newLbl";
            this.newLbl.Size = new System.Drawing.Size(85, 13);
            this.newLbl.TabIndex = 18;
            this.newLbl.Text = "New text pattern";
            // 
            // currentTxt
            // 
            this.currentTxt.Location = new System.Drawing.Point(142, 40);
            this.currentTxt.Name = "currentTxt";
            this.currentTxt.Size = new System.Drawing.Size(130, 20);
            this.currentTxt.TabIndex = 19;
            // 
            // newTxt
            // 
            this.newTxt.Location = new System.Drawing.Point(142, 66);
            this.newTxt.Name = "newTxt";
            this.newTxt.Size = new System.Drawing.Size(130, 20);
            this.newTxt.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 193);
            this.Controls.Add(this.newTxt);
            this.Controls.Add(this.currentTxt);
            this.Controls.Add(this.newLbl);
            this.Controls.Add(this.currentLbl);
            this.Controls.Add(this.statusVal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.remainingVal);
            this.Controls.Add(this.elapsedVal);
            this.Controls.Add(this.remainingLabel);
            this.Controls.Add(this.elapsedLabel);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.folderTxtBx);
            this.Name = "Form1";
            this.Text = "File Rename";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox folderTxtBx;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Label elapsedLabel;
        private System.Windows.Forms.Label remainingLabel;
        private System.Windows.Forms.Label elapsedVal;
        private System.Windows.Forms.Label remainingVal;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label statusVal;
        private System.Windows.Forms.Label currentLbl;
        private System.Windows.Forms.Label newLbl;
        private System.Windows.Forms.TextBox currentTxt;
        private System.Windows.Forms.TextBox newTxt;
    }
}

