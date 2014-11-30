namespace Project_Tracking_System.Views
{
    partial class addManager
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.fnamelbl = new System.Windows.Forms.Label();
            this.lnamelbl = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.fNameTxtBox = new System.Windows.Forms.TextBox();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.idNumberTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(96, 241);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(100, 28);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(304, 241);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 28);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // fnamelbl
            // 
            this.fnamelbl.AutoSize = true;
            this.fnamelbl.Location = new System.Drawing.Point(92, 59);
            this.fnamelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fnamelbl.Name = "fnamelbl";
            this.fnamelbl.Size = new System.Drawing.Size(76, 17);
            this.fnamelbl.TabIndex = 2;
            this.fnamelbl.Text = "First Name";
            // 
            // lnamelbl
            // 
            this.lnamelbl.AutoSize = true;
            this.lnamelbl.Location = new System.Drawing.Point(92, 117);
            this.lnamelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnamelbl.Name = "lnamelbl";
            this.lnamelbl.Size = new System.Drawing.Size(76, 17);
            this.lnamelbl.TabIndex = 3;
            this.lnamelbl.Text = "Last Name";
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(92, 171);
            this.idLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(19, 17);
            this.idLbl.TabIndex = 4;
            this.idLbl.Text = "Id";
            // 
            // fNameTxtBox
            // 
            this.fNameTxtBox.Location = new System.Drawing.Point(271, 59);
            this.fNameTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fNameTxtBox.Name = "fNameTxtBox";
            this.fNameTxtBox.Size = new System.Drawing.Size(132, 22);
            this.fNameTxtBox.TabIndex = 5;
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.Location = new System.Drawing.Point(271, 117);
            this.lNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(132, 22);
            this.lNameTextBox.TabIndex = 6;
            // 
            // idNumberTxtBox
            // 
            this.idNumberTxtBox.Location = new System.Drawing.Point(271, 171);
            this.idNumberTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idNumberTxtBox.Name = "idNumberTxtBox";
            this.idNumberTxtBox.Size = new System.Drawing.Size(132, 22);
            this.idNumberTxtBox.TabIndex = 7;
            // 
            // addManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 311);
            this.Controls.Add(this.idNumberTxtBox);
            this.Controls.Add(this.lNameTextBox);
            this.Controls.Add(this.fNameTxtBox);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.lnamelbl);
            this.Controls.Add(this.fnamelbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(509, 358);
            this.Name = "addManager";
            this.Text = "New Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label fnamelbl;
        private System.Windows.Forms.Label lnamelbl;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.TextBox fNameTxtBox;
        private System.Windows.Forms.TextBox lNameTextBox;
        private System.Windows.Forms.TextBox idNumberTxtBox;
    }
}