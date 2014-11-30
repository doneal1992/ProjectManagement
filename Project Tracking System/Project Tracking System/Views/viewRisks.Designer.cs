namespace Project_Tracking_System.Views
{
    partial class viewRisks
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.doneBtn = new System.Windows.Forms.Button();
            this.addRiskBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(152, 44);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTextBox1.Size = new System.Drawing.Size(440, 135);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Status:                       Description:";
            this.richTextBox1.WordWrap = false;
            // 
            // doneBtn
            // 
            this.doneBtn.Location = new System.Drawing.Point(458, 220);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(105, 33);
            this.doneBtn.TabIndex = 1;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // addRiskBtn
            // 
            this.addRiskBtn.Location = new System.Drawing.Point(169, 220);
            this.addRiskBtn.Name = "addRiskBtn";
            this.addRiskBtn.Size = new System.Drawing.Size(105, 33);
            this.addRiskBtn.TabIndex = 2;
            this.addRiskBtn.Text = "Add";
            this.addRiskBtn.UseVisualStyleBackColor = true;
            this.addRiskBtn.Click += new System.EventHandler(this.addRiskBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Risk List";
            // 
            // viewRisks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 293);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addRiskBtn);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.richTextBox1);
            this.MinimumSize = new System.Drawing.Size(692, 340);
            this.Name = "viewRisks";
            this.Text = "View Risks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.Button addRiskBtn;
        private System.Windows.Forms.Label label1;
    }
}