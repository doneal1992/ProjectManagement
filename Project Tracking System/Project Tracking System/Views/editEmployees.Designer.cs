namespace Project_Tracking_System
{
    partial class editEmployees
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
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.addEmpBtn = new System.Windows.Forms.Button();
            this.removeEmpBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee List";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(132, 29);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(272, 84);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // addEmpBtn
            // 
            this.addEmpBtn.Location = new System.Drawing.Point(15, 211);
            this.addEmpBtn.Name = "addEmpBtn";
            this.addEmpBtn.Size = new System.Drawing.Size(75, 23);
            this.addEmpBtn.TabIndex = 2;
            this.addEmpBtn.Text = "Add";
            this.addEmpBtn.UseVisualStyleBackColor = true;
            this.addEmpBtn.Click += new System.EventHandler(this.addEmpBtn_Click);
            // 
            // removeEmpBtn
            // 
            this.removeEmpBtn.Location = new System.Drawing.Point(182, 211);
            this.removeEmpBtn.Name = "removeEmpBtn";
            this.removeEmpBtn.Size = new System.Drawing.Size(75, 23);
            this.removeEmpBtn.TabIndex = 3;
            this.removeEmpBtn.Text = "Remove";
            this.removeEmpBtn.UseVisualStyleBackColor = true;
            this.removeEmpBtn.Click += new System.EventHandler(this.removeEmpBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(341, 211);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // editEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 253);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.removeEmpBtn);
            this.Controls.Add(this.addEmpBtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "editEmployees";
            this.Text = "Add/Remove Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button addEmpBtn;
        private System.Windows.Forms.Button removeEmpBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}