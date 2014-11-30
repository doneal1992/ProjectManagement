namespace Project_Tracking_System
{
    partial class addRequirement
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
            this.funcReqBtn = new System.Windows.Forms.RadioButton();
            this.nonFuncReqBtn = new System.Windows.Forms.RadioButton();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.descriptionTxtbox = new System.Windows.Forms.RichTextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // funcReqBtn
            // 
            this.funcReqBtn.AutoSize = true;
            this.funcReqBtn.Location = new System.Drawing.Point(43, 33);
            this.funcReqBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.funcReqBtn.Name = "funcReqBtn";
            this.funcReqBtn.Size = new System.Drawing.Size(94, 21);
            this.funcReqBtn.TabIndex = 0;
            this.funcReqBtn.TabStop = true;
            this.funcReqBtn.Text = "Functional";
            this.funcReqBtn.UseVisualStyleBackColor = true;
            // 
            // nonFuncReqBtn
            // 
            this.nonFuncReqBtn.AutoSize = true;
            this.nonFuncReqBtn.Location = new System.Drawing.Point(43, 78);
            this.nonFuncReqBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nonFuncReqBtn.Name = "nonFuncReqBtn";
            this.nonFuncReqBtn.Size = new System.Drawing.Size(125, 21);
            this.nonFuncReqBtn.TabIndex = 1;
            this.nonFuncReqBtn.TabStop = true;
            this.nonFuncReqBtn.Text = "Non-Functional";
            this.nonFuncReqBtn.UseVisualStyleBackColor = true;
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLbl.Location = new System.Drawing.Point(39, 149);
            this.descriptionLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(71, 13);
            this.descriptionLbl.TabIndex = 2;
            this.descriptionLbl.Text = "Description";
            // 
            // descriptionTxtbox
            // 
            this.descriptionTxtbox.Location = new System.Drawing.Point(156, 149);
            this.descriptionTxtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptionTxtbox.Name = "descriptionTxtbox";
            this.descriptionTxtbox.Size = new System.Drawing.Size(277, 112);
            this.descriptionTxtbox.TabIndex = 3;
            this.descriptionTxtbox.Text = "";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(119, 288);
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
            this.cancelBtn.Location = new System.Drawing.Point(335, 288);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 28);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addRequirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 332);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.descriptionTxtbox);
            this.Controls.Add(this.descriptionLbl);
            this.Controls.Add(this.nonFuncReqBtn);
            this.Controls.Add(this.funcReqBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(530, 379);
            this.Name = "addRequirement";
            this.Text = "Add Requirement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton funcReqBtn;
        private System.Windows.Forms.RadioButton nonFuncReqBtn;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.RichTextBox descriptionTxtbox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}