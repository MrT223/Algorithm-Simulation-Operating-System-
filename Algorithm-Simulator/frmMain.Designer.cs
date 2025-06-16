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
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.bntC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblmember = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblmemA = new System.Windows.Forms.Label();
            this.lblmemB = new System.Windows.Forms.Label();
            this.lblmemC = new System.Windows.Forms.Label();
            this.lblmemD = new System.Windows.Forms.Label();
            this.lblE = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(831, 214);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(210, 110);
            this.btnA.TabIndex = 0;
            this.btnA.Text = "Banker\'s algorithm";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.Location = new System.Drawing.Point(992, 339);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(210, 110);
            this.btnB.TabIndex = 1;
            this.btnB.Text = "CPU scheduling algorithms";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnCPU_Distribution_Click);
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.Location = new System.Drawing.Point(898, 533);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(210, 110);
            this.btnD.TabIndex = 2;
            this.btnD.Text = "Disk access scheduling algorithms";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.button3_Click);
            // 
            // bntC
            // 
            this.bntC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bntC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntC.Location = new System.Drawing.Point(1126, 468);
            this.bntC.Name = "bntC";
            this.bntC.Size = new System.Drawing.Size(210, 110);
            this.bntC.TabIndex = 3;
            this.bntC.Text = "Page replacement algorithms";
            this.bntC.UseVisualStyleBackColor = false;
            this.bntC.Click += new System.EventHandler(this.PFSR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhóm 10 Balls";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.SystemColors.Control;
            this.lbl1.Font = new System.Drawing.Font("Newsreader 60pt", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl1.Location = new System.Drawing.Point(38, 27);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(1208, 67);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "Chương trình minh họa các giải thuật - Hệ Điều Hành";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblE);
            this.panel1.Controls.Add(this.lblmemD);
            this.panel1.Controls.Add(this.lblmemC);
            this.panel1.Controls.Add(this.lblmemB);
            this.panel1.Controls.Add(this.lblmemA);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 512);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblmember);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(705, 82);
            this.panel2.TabIndex = 1;
            // 
            // lblmember
            // 
            this.lblmember.AutoSize = true;
            this.lblmember.Font = new System.Drawing.Font("Baskerville Old Face", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmember.Location = new System.Drawing.Point(188, 26);
            this.lblmember.Name = "lblmember";
            this.lblmember.Size = new System.Drawing.Size(297, 34);
            this.lblmember.TabIndex = 0;
            this.lblmember.Text = "Danh sách thành viên";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(1049, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(254, 41);
            this.panel3.TabIndex = 7;
            // 
            // lblmemA
            // 
            this.lblmemA.AutoSize = true;
            this.lblmemA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmemA.Location = new System.Drawing.Point(133, 124);
            this.lblmemA.Name = "lblmemA";
            this.lblmemA.Size = new System.Drawing.Size(403, 36);
            this.lblmemA.TabIndex = 2;
            this.lblmemA.Text = "Bùi Minh Tín - 49.01.104.152";
            // 
            // lblmemB
            // 
            this.lblmemB.AutoSize = true;
            this.lblmemB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmemB.Location = new System.Drawing.Point(133, 196);
            this.lblmemB.Name = "lblmemB";
            this.lblmemB.Size = new System.Drawing.Size(250, 36);
            this.lblmemB.TabIndex = 3;
            this.lblmemB.Text = "Cao Võ Tuấn Kiệt";
            // 
            // lblmemC
            // 
            this.lblmemC.AutoSize = true;
            this.lblmemC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmemC.Location = new System.Drawing.Point(133, 270);
            this.lblmemC.Name = "lblmemC";
            this.lblmemC.Size = new System.Drawing.Size(335, 36);
            this.lblmemC.TabIndex = 4;
            this.lblmemC.Text = "Nguyễn Võ Minh Hoàng";
            // 
            // lblmemD
            // 
            this.lblmemD.AutoSize = true;
            this.lblmemD.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmemD.Location = new System.Drawing.Point(133, 346);
            this.lblmemD.Name = "lblmemD";
            this.lblmemD.Size = new System.Drawing.Size(336, 36);
            this.lblmemD.TabIndex = 5;
            this.lblmemD.Text = "Nguyễn Hữu Minh Quân";
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE.Location = new System.Drawing.Point(133, 415);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(300, 36);
            this.lblE.TabIndex = 6;
            this.lblE.Text = "Nguyễn Quang Khắm";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1385, 687);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.bntC);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button bntC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblmember;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblmemD;
        private System.Windows.Forms.Label lblmemC;
        private System.Windows.Forms.Label lblmemB;
        private System.Windows.Forms.Label lblmemA;
        private System.Windows.Forms.Label lblE;
    }
}

