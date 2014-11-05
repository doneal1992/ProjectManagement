namespace Project_Tracking_System
{
    partial class editProject
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.managerIDLbl = new System.Windows.Forms.Label();
            this.managerIDTxtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(168, 203);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 0;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(28, 203);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search ";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // managerIDLbl
            // 
            this.managerIDLbl.AutoSize = true;
            this.managerIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerIDLbl.Location = new System.Drawing.Point(25, 67);
            this.managerIDLbl.Name = "managerIDLbl";
            this.managerIDLbl.Size = new System.Drawing.Size(82, 15);
            this.managerIDLbl.TabIndex = 2;
            this.managerIDLbl.Text = "Manager ID";
            // 
            // managerIDTxtbox
            // 
            this.managerIDTxtbox.Location = new System.Drawing.Point(143, 67);
            this.managerIDTxtbox.Name = "managerIDTxtbox";
            this.managerIDTxtbox.Size = new System.Drawing.Size(100, 20);
            this.managerIDTxtbox.TabIndex = 3;
            // 
            // editProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.managerIDTxtbox);
            this.Controls.Add(this.managerIDLbl);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.cancelBtn);
            this.Name = "editProject";
            this.Text = "Edit Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label managerIDLbl;
        private System.Windows.Forms.TextBox managerIDTxtbox;
    }
}