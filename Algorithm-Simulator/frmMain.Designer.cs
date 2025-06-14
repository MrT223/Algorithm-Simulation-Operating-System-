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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(708, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 110);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCPU_Distribution
            // 
            this.btnCPU_Distribution.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCPU_Distribution.Location = new System.Drawing.Point(924, 267);
            this.btnCPU_Distribution.Name = "btnCPU_Distribution";
            this.btnCPU_Distribution.Size = new System.Drawing.Size(210, 110);
            this.btnCPU_Distribution.TabIndex = 1;
            this.btnCPU_Distribution.Text = "CÂU B ĐIỀU PHỐI CPU";
            this.btnCPU_Distribution.UseVisualStyleBackColor = false;
            this.btnCPU_Distribution.Click += new System.EventHandler(this.btnCPU_Distribution_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(1356, 446);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(210, 110);
            this.button3.TabIndex = 2;
            this.button3.Text = "CÂU D DISK SCHEDULING";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PFSR
            // 
            this.PFSR.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PFSR.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PFSR.Location = new System.Drawing.Point(1140, 356);
            this.PFSR.Name = "PFSR";
            this.PFSR.Size = new System.Drawing.Size(210, 110);
            this.PFSR.TabIndex = 3;
            this.PFSR.Text = "PSFR";
            this.PFSR.UseVisualStyleBackColor = false;
            this.PFSR.Click += new System.EventHandler(this.PFSR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1077, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhóm 10 Balls";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Newsreader 60pt", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(203, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(1208, 67);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "Chương trình minh họa các giải thuật - Hệ Điều Hành";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(593, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "Giải thuật Banker tìm và giải quyết deadlock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(378, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(531, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giải thuật phân phối CPU các tiến trình";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(514, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(620, 36);
            this.label5.TabIndex = 9;
            this.label5.Text = "Giải thuật thay thế trang trong quy trình PFSR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(563, 489);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(787, 36);
            this.label6.TabIndex = 10;
            this.label6.Text = "Giải thuật định thời truy cập đĩa để quản lý hệ thống tập tin";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1577, 687);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PFSR);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCPU_Distribution);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCPU_Distribution;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button PFSR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

