namespace WindowsFormsApplication1
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
            this.RockBtn = new System.Windows.Forms.RadioButton();
            this.PaperBtn = new System.Windows.Forms.RadioButton();
            this.ScissorsBtn = new System.Windows.Forms.RadioButton();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.PointTxtBox = new System.Windows.Forms.TextBox();
            this.PointsLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalTxtBx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RockBtn
            // 
            this.RockBtn.AutoSize = true;
            this.RockBtn.Location = new System.Drawing.Point(13, 40);
            this.RockBtn.Name = "RockBtn";
            this.RockBtn.Size = new System.Drawing.Size(51, 17);
            this.RockBtn.TabIndex = 0;
            this.RockBtn.TabStop = true;
            this.RockBtn.Text = "Rock";
            this.RockBtn.UseVisualStyleBackColor = true;
            // 
            // PaperBtn
            // 
            this.PaperBtn.AutoSize = true;
            this.PaperBtn.Location = new System.Drawing.Point(13, 64);
            this.PaperBtn.Name = "PaperBtn";
            this.PaperBtn.Size = new System.Drawing.Size(53, 17);
            this.PaperBtn.TabIndex = 1;
            this.PaperBtn.TabStop = true;
            this.PaperBtn.Text = "Paper";
            this.PaperBtn.UseVisualStyleBackColor = true;
            // 
            // ScissorsBtn
            // 
            this.ScissorsBtn.AutoSize = true;
            this.ScissorsBtn.Location = new System.Drawing.Point(13, 88);
            this.ScissorsBtn.Name = "ScissorsBtn";
            this.ScissorsBtn.Size = new System.Drawing.Size(64, 17);
            this.ScissorsBtn.TabIndex = 2;
            this.ScissorsBtn.TabStop = true;
            this.ScissorsBtn.Text = "Scissors";
            this.ScissorsBtn.UseVisualStyleBackColor = true;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(91, 139);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(75, 23);
            this.SubmitBtn.TabIndex = 3;
            this.SubmitBtn.Text = "Submit !";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // PointTxtBox
            // 
            this.PointTxtBox.Location = new System.Drawing.Point(221, 11);
            this.PointTxtBox.Name = "PointTxtBox";
            this.PointTxtBox.Size = new System.Drawing.Size(51, 20);
            this.PointTxtBox.TabIndex = 4;
            // 
            // PointsLbl
            // 
            this.PointsLbl.AutoSize = true;
            this.PointsLbl.Location = new System.Drawing.Point(170, 14);
            this.PointsLbl.Name = "PointsLbl";
            this.PointsLbl.Size = new System.Drawing.Size(45, 13);
            this.PointsLbl.TabIndex = 5;
            this.PointsLbl.Text = "Points : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Games played :";
            // 
            // TotalTxtBx
            // 
            this.TotalTxtBx.Location = new System.Drawing.Point(94, 11);
            this.TotalTxtBx.Name = "TotalTxtBx";
            this.TotalTxtBx.Size = new System.Drawing.Size(38, 20);
            this.TotalTxtBx.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TotalTxtBx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PointsLbl);
            this.Controls.Add(this.PointTxtBox);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.ScissorsBtn);
            this.Controls.Add(this.PaperBtn);
            this.Controls.Add(this.RockBtn);
            this.Name = "Form1";
            this.Text = "Rock Paper Scissors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RockBtn;
        private System.Windows.Forms.RadioButton PaperBtn;
        private System.Windows.Forms.RadioButton ScissorsBtn;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.TextBox PointTxtBox;
        private System.Windows.Forms.Label PointsLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TotalTxtBx;
    }
}

