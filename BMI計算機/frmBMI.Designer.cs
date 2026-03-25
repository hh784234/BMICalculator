namespace BMI計算機
{
    partial class frmBMI
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.grpInput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInput
            // 
            this.grpInput.BackColor = System.Drawing.Color.LavenderBlush;
            this.grpInput.Controls.Add(this.btnRun);
            this.grpInput.Controls.Add(this.lblWeight);
            this.grpInput.Controls.Add(this.lblHeight);
            this.grpInput.Controls.Add(this.txtWeight);
            this.grpInput.Controls.Add(this.txtHeight);
            this.grpInput.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpInput.Location = new System.Drawing.Point(52, 29);
            this.grpInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpInput.Name = "grpInput";
            this.grpInput.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpInput.Size = new System.Drawing.Size(525, 127);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "輸入";
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.Pink;
            this.btnRun.Location = new System.Drawing.Point(434, 54);
            this.btnRun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(76, 38);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "計算";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(4, 84);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(82, 24);
            this.lblWeight.TabIndex = 3;
            this.lblWeight.Text = "體重(kg)";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(4, 31);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(87, 24);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "身高(cm)";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(208, 82);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(204, 32);
            this.txtWeight.TabIndex = 1;
            // 
            // txtHeight
            // 
            this.txtHeight.BackColor = System.Drawing.SystemColors.Window;
            this.txtHeight.Location = new System.Drawing.Point(208, 31);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(204, 32);
            this.txtHeight.TabIndex = 0;
            // 
            // grpOutput
            // 
            this.grpOutput.BackColor = System.Drawing.Color.LavenderBlush;
            this.grpOutput.Controls.Add(this.lblResult);
            this.grpOutput.Controls.Add(this.lblBMI);
            this.grpOutput.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpOutput.Location = new System.Drawing.Point(52, 161);
            this.grpOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpOutput.Size = new System.Drawing.Size(525, 142);
            this.grpOutput.TabIndex = 1;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "計算結果";
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.Window;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(208, 69);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(202, 30);
            this.lblResult.TabIndex = 4;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(4, 73);
            this.lblBMI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(171, 24);
            this.lblBMI.TabIndex = 3;
            this.lblBMI.Text = "身體質量指數(bmi)";
            // 
            // frmBMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(598, 347);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpInput);
            this.Location = new System.Drawing.Point(300, 300);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmBMI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI";
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnRun;
    }
}

