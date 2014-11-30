namespace Project_Tracking_System
{
    partial class addRisk
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
            this.statusLbl = new System.Windows.Forms.Label();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.statusTxtbox = new System.Windows.Forms.TextBox();
            this.descriptionTxtbox = new System.Windows.Forms.RichTextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLbl.Location = new System.Drawing.Point(43, 55);
            this.statusLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(43, 13);
            this.statusLbl.TabIndex = 0;
            this.statusLbl.Text = "Status";
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLbl.Location = new System.Drawing.Point(43, 154);
            this.descriptionLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(71, 13);
            this.descriptionLbl.TabIndex = 1;
            this.descriptionLbl.Text = "Description";
            // 
            // statusTxtbox
            // 
            this.statusTxtbox.Location = new System.Drawing.Point(195, 55);
            this.statusTxtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statusTxtbox.Name = "statusTxtbox";
            this.statusTxtbox.Size = new System.Drawing.Size(132, 22);
            this.statusTxtbox.TabIndex = 2;
            // 
            // descriptionTxtbox
            // 
            this.descriptionTxtbox.Location = new System.Drawing.Point(195, 154);
            this.descriptionTxtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptionTxtbox.Name = "descriptionTxtbox";
            this.descriptionTxtbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.descriptionTxtbox.Size = new System.Drawing.Size(254, 80);
            this.descriptionTxtbox.TabIndex = 3;
            this.descriptionTxtbox.Text = "";
            this.descriptionTxtbox.WordWrap = false;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(124, 268);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(100, 28);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(349, 268);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 28);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addRisk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 311);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.descriptionTxtbox);
            this.Controls.Add(this.statusTxtbox);
            this.Controls.Add(this.descriptionLbl);
            this.Controls.Add(this.statusLbl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(578, 358);
            this.Name = "addRisk";
            this.Text = "addRisk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.TextBox statusTxtbox;
        private System.Windows.Forms.RichTextBox descriptionTxtbox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}