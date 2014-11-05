namespace Project_Tracking_System
{
    partial class employeeInfo
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
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.positionLbl = new System.Windows.Forms.Label();
            this.firstNameTxtbox = new System.Windows.Forms.TextBox();
            this.lastNameTxtbox = new System.Windows.Forms.TextBox();
            this.positionTxtbox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLbl.Location = new System.Drawing.Point(12, 24);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(67, 13);
            this.firstNameLbl.TabIndex = 0;
            this.firstNameLbl.Text = "First Name";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLbl.Location = new System.Drawing.Point(10, 86);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(67, 13);
            this.lastNameLbl.TabIndex = 1;
            this.lastNameLbl.Text = "Last Name";
            // 
            // positionLbl
            // 
            this.positionLbl.AutoSize = true;
            this.positionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionLbl.Location = new System.Drawing.Point(12, 151);
            this.positionLbl.Name = "positionLbl";
            this.positionLbl.Size = new System.Drawing.Size(52, 13);
            this.positionLbl.TabIndex = 2;
            this.positionLbl.Text = "Position";
            // 
            // firstNameTxtbox
            // 
            this.firstNameTxtbox.Location = new System.Drawing.Point(132, 24);
            this.firstNameTxtbox.Name = "firstNameTxtbox";
            this.firstNameTxtbox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTxtbox.TabIndex = 3;
            // 
            // lastNameTxtbox
            // 
            this.lastNameTxtbox.Location = new System.Drawing.Point(132, 83);
            this.lastNameTxtbox.Name = "lastNameTxtbox";
            this.lastNameTxtbox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTxtbox.TabIndex = 4;
            // 
            // positionTxtbox
            // 
            this.positionTxtbox.Location = new System.Drawing.Point(132, 151);
            this.positionTxtbox.Name = "positionTxtbox";
            this.positionTxtbox.Size = new System.Drawing.Size(100, 20);
            this.positionTxtbox.TabIndex = 5;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(24, 213);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(89, 24);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(186, 213);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(89, 24);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // employeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 252);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.positionTxtbox);
            this.Controls.Add(this.lastNameTxtbox);
            this.Controls.Add(this.firstNameTxtbox);
            this.Controls.Add(this.positionLbl);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.firstNameLbl);
            this.Name = "employeeInfo";
            this.Text = "Employee Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Label positionLbl;
        private System.Windows.Forms.TextBox firstNameTxtbox;
        private System.Windows.Forms.TextBox lastNameTxtbox;
        private System.Windows.Forms.TextBox positionTxtbox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}