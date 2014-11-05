namespace Project_Tracking_System
{
    partial class projectEdit
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
            this.projectNameLbl = new System.Windows.Forms.Label();
            this.viewEmpBtn = new System.Windows.Forms.Button();
            this.viewReqBtn = new System.Windows.Forms.Button();
            this.viewRiskBtn = new System.Windows.Forms.Button();
            this.viewEffortBtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // projectNameLbl
            // 
            this.projectNameLbl.AutoSize = true;
            this.projectNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectNameLbl.Location = new System.Drawing.Point(327, 30);
            this.projectNameLbl.Name = "projectNameLbl";
            this.projectNameLbl.Size = new System.Drawing.Size(92, 13);
            this.projectNameLbl.TabIndex = 0;
            this.projectNameLbl.Text = "Current Project";
            // 
            // viewEmpBtn
            // 
            this.viewEmpBtn.Location = new System.Drawing.Point(45, 150);
            this.viewEmpBtn.Name = "viewEmpBtn";
            this.viewEmpBtn.Size = new System.Drawing.Size(133, 23);
            this.viewEmpBtn.TabIndex = 1;
            this.viewEmpBtn.Text = "View Employees";
            this.viewEmpBtn.UseVisualStyleBackColor = true;
            this.viewEmpBtn.Click += new System.EventHandler(this.viewEmpBtn_Click);
            // 
            // viewReqBtn
            // 
            this.viewReqBtn.Location = new System.Drawing.Point(389, 150);
            this.viewReqBtn.Name = "viewReqBtn";
            this.viewReqBtn.Size = new System.Drawing.Size(139, 23);
            this.viewReqBtn.TabIndex = 2;
            this.viewReqBtn.Text = "View Requirements";
            this.viewReqBtn.UseVisualStyleBackColor = true;
            this.viewReqBtn.Click += new System.EventHandler(this.viewReqBtn_Click);
            // 
            // viewRiskBtn
            // 
            this.viewRiskBtn.Location = new System.Drawing.Point(217, 150);
            this.viewRiskBtn.Name = "viewRiskBtn";
            this.viewRiskBtn.Size = new System.Drawing.Size(133, 23);
            this.viewRiskBtn.TabIndex = 3;
            this.viewRiskBtn.Text = "View Risks";
            this.viewRiskBtn.UseVisualStyleBackColor = true;
            this.viewRiskBtn.Click += new System.EventHandler(this.viewRiskBtn_Click);
            // 
            // viewEffortBtn
            // 
            this.viewEffortBtn.Location = new System.Drawing.Point(576, 150);
            this.viewEffortBtn.Name = "viewEffortBtn";
            this.viewEffortBtn.Size = new System.Drawing.Size(133, 23);
            this.viewEffortBtn.TabIndex = 4;
            this.viewEffortBtn.Text = "View Effort";
            this.viewEffortBtn.UseVisualStyleBackColor = true;
            this.viewEffortBtn.Click += new System.EventHandler(this.viewEffortBtn_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(330, 218);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Cancel";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // projectEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 253);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.viewEffortBtn);
            this.Controls.Add(this.viewRiskBtn);
            this.Controls.Add(this.viewReqBtn);
            this.Controls.Add(this.viewEmpBtn);
            this.Controls.Add(this.projectNameLbl);
            this.Name = "projectEdit";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label projectNameLbl;
        private System.Windows.Forms.Button viewEmpBtn;
        private System.Windows.Forms.Button viewReqBtn;
        private System.Windows.Forms.Button viewRiskBtn;
        private System.Windows.Forms.Button viewEffortBtn;
        private System.Windows.Forms.Button button5;
    }
}