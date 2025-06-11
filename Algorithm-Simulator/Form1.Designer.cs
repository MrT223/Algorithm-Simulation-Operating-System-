namespace Algorithm_Simulator
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnCPU_Distribution = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.PFSR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(749, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 345);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnCPU_Distribution
            // 
            this.btnCPU_Distribution.BackColor = System.Drawing.Color.Brown;
            this.btnCPU_Distribution.Location = new System.Drawing.Point(571, 478);
            this.btnCPU_Distribution.Name = "btnCPU_Distribution";
            this.btnCPU_Distribution.Size = new System.Drawing.Size(159, 142);
            this.btnCPU_Distribution.TabIndex = 1;
            this.btnCPU_Distribution.Text = "CÂU B ĐIỀU PHỐI CPU";
            this.btnCPU_Distribution.UseVisualStyleBackColor = false;
            this.btnCPU_Distribution.Click += new System.EventHandler(this.btnCPU_Distribution_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Brown;
            this.button3.Location = new System.Drawing.Point(916, 478);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 142);
            this.button3.TabIndex = 2;
            this.button3.Text = "CÂU D DISK SCHEDULING";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PFSR
            // 
            this.PFSR.BackColor = System.Drawing.Color.Red;
            this.PFSR.Location = new System.Drawing.Point(733, 12);
            this.PFSR.Name = "PFSR";
            this.PFSR.Size = new System.Drawing.Size(188, 108);
            this.PFSR.TabIndex = 3;
            this.PFSR.Text = "PFSR";
            this.PFSR.UseVisualStyleBackColor = false;
            this.PFSR.Click += new System.EventHandler(this.PFSR_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1577, 687);
            this.Controls.Add(this.PFSR);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCPU_Distribution);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCPU_Distribution;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button PFSR;
    }
}

