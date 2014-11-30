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
            this.viewEmpBtn = new System.Windows.Forms.Button();
            this.viewReqBtn = new System.Windows.Forms.Button();
            this.viewRiskBtn = new System.Windows.Forms.Button();
            this.viewEffortBtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.projectNameLbl = new System.Windows.Forms.Label();
            this.managerIDLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // viewEmpBtn
            // 
            this.viewEmpBtn.Location = new System.Drawing.Point(60, 185);
            this.viewEmpBtn.Margin = new System.Windows.Forms.Padding(4);
            this.viewEmpBtn.Name = "viewEmpBtn";
            this.viewEmpBtn.Size = new System.Drawing.Size(177, 28);
            this.viewEmpBtn.TabIndex = 1;
            this.viewEmpBtn.Text = "View Employees";
            this.viewEmpBtn.UseVisualStyleBackColor = true;
            this.viewEmpBtn.Click += new System.EventHandler(this.viewEmpBtn_Click);
            // 
            // viewReqBtn
            // 
            this.viewReqBtn.Location = new System.Drawing.Point(519, 185);
            this.viewReqBtn.Margin = new System.Windows.Forms.Padding(4);
            this.viewReqBtn.Name = "viewReqBtn";
            this.viewReqBtn.Size = new System.Drawing.Size(185, 28);
            this.viewReqBtn.TabIndex = 2;
            this.viewReqBtn.Text = "View Requirements";
            this.viewReqBtn.UseVisualStyleBackColor = true;
            this.viewReqBtn.Click += new System.EventHandler(this.viewReqBtn_Click);
            // 
            // viewRiskBtn
            // 
            this.viewRiskBtn.Location = new System.Drawing.Point(289, 185);
            this.viewRiskBtn.Margin = new System.Windows.Forms.Padding(4);
            this.viewRiskBtn.Name = "viewRiskBtn";
            this.viewRiskBtn.Size = new System.Drawing.Size(177, 28);
            this.viewRiskBtn.TabIndex = 3;
            this.viewRiskBtn.Text = "View Risks";
            this.viewRiskBtn.UseVisualStyleBackColor = true;
            this.viewRiskBtn.Click += new System.EventHandler(this.viewRiskBtn_Click);
            // 
            // viewEffortBtn
            // 
            this.viewEffortBtn.Location = new System.Drawing.Point(768, 185);
            this.viewEffortBtn.Margin = new System.Windows.Forms.Padding(4);
            this.viewEffortBtn.Name = "viewEffortBtn";
            this.viewEffortBtn.Size = new System.Drawing.Size(177, 28);
            this.viewEffortBtn.TabIndex = 4;
            this.viewEffortBtn.Text = "View Effort";
            this.viewEffortBtn.UseVisualStyleBackColor = true;
            this.viewEffortBtn.Click += new System.EventHandler(this.viewEffortBtn_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(440, 268);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 28);
            this.button5.TabIndex = 5;
            this.button5.Text = "Done";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Project Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Manager ID:";
            // 
            // projectNameLbl
            // 
            this.projectNameLbl.AutoSize = true;
            this.projectNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectNameLbl.Location = new System.Drawing.Point(448, 37);
            this.projectNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.projectNameLbl.Name = "projectNameLbl";
            this.projectNameLbl.Size = new System.Drawing.Size(92, 13);
            this.projectNameLbl.TabIndex = 0;
            this.projectNameLbl.Text = "Current Project";
            // 
            // managerIDLBL
            // 
            this.managerIDLBL.AutoSize = true;
            this.managerIDLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerIDLBL.Location = new System.Drawing.Point(463, 94);
            this.managerIDLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.managerIDLBL.Name = "managerIDLBL";
            this.managerIDLBL.Size = new System.Drawing.Size(65, 13);
            this.managerIDLBL.TabIndex = 8;
            this.managerIDLBL.Text = "Current ID";
            // 
            // projectEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 311);
            this.Controls.Add(this.managerIDLBL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.viewEffortBtn);
            this.Controls.Add(this.viewRiskBtn);
            this.Controls.Add(this.viewReqBtn);
            this.Controls.Add(this.viewEmpBtn);
            this.Controls.Add(this.projectNameLbl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1045, 358);
            this.Name = "projectEdit";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewEmpBtn;
        private System.Windows.Forms.Button viewReqBtn;
        private System.Windows.Forms.Button viewRiskBtn;
        private System.Windows.Forms.Button viewEffortBtn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label projectNameLbl;
        private System.Windows.Forms.Label managerIDLBL;
    }
}