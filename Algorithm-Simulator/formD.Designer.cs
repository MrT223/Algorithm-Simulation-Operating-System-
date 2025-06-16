namespace Algorithm_Simulator
{
    partial class FormD
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnLoadInput = new System.Windows.Forms.Button();
            this.txtHead = new System.Windows.Forms.TextBox();
            this.lnType = new System.Windows.Forms.Label();
            this.txtRequests = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRunAlgo = new System.Windows.Forms.Button();
            this.btnFCFS = new System.Windows.Forms.Button();
            this.txtDiskSize = new System.Windows.Forms.TextBox();
            this.lbDiskSize = new System.Windows.Forms.Label();
            this.btnSSTF = new System.Windows.Forms.Button();
            this.btnCSCAN = new System.Windows.Forms.Button();
            this.btnSCAN = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbRequests = new System.Windows.Forms.Label();
            this.lbHead = new System.Windows.Forms.Label();
            this.lbInput1 = new System.Windows.Forms.Label();
            this.lbInput2 = new System.Windows.Forms.Label();
            this.lbProgress = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.btnLoadInput);
            this.panel1.Controls.Add(this.txtHead);
            this.panel1.Controls.Add(this.lnType);
            this.panel1.Controls.Add(this.txtRequests);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 687);
            this.panel1.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(329, 205);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(110, 38);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnLoadInput
            // 
            this.btnLoadInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadInput.Location = new System.Drawing.Point(34, 235);
            this.btnLoadInput.Name = "btnLoadInput";
            this.btnLoadInput.Size = new System.Drawing.Size(297, 38);
            this.btnLoadInput.TabIndex = 6;
            this.btnLoadInput.Text = "Bắt đầu khởi tạo dữ liệu";
            this.btnLoadInput.UseVisualStyleBackColor = true;
            this.btnLoadInput.Click += new System.EventHandler(this.btnLoadInput_Click);
            // 
            // txtHead
            // 
            this.txtHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHead.Location = new System.Drawing.Point(34, 190);
            this.txtHead.Name = "txtHead";
            this.txtHead.Size = new System.Drawing.Size(527, 30);
            this.txtHead.TabIndex = 5;
            this.txtHead.Text = "50";
            // 
            // lnType
            // 
            this.lnType.AutoSize = true;
            this.lnType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnType.Location = new System.Drawing.Point(29, 290);
            this.lnType.Name = "lnType";
            this.lnType.Size = new System.Drawing.Size(0, 25);
            this.lnType.TabIndex = 4;
            // 
            // txtRequests
            // 
            this.txtRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequests.Location = new System.Drawing.Point(34, 103);
            this.txtRequests.Name = "txtRequests";
            this.txtRequests.Size = new System.Drawing.Size(527, 30);
            this.txtRequests.TabIndex = 0;
            this.txtRequests.Text = "82|170|43|140|24|16|190";
            this.txtRequests.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRequests_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRunAlgo);
            this.groupBox1.Controls.Add(this.btnFCFS);
            this.groupBox1.Controls.Add(this.txtDiskSize);
            this.groupBox1.Controls.Add(this.lbDiskSize);
            this.groupBox1.Controls.Add(this.btnSSTF);
            this.groupBox1.Controls.Add(this.btnCSCAN);
            this.groupBox1.Controls.Add(this.btnSCAN);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 360);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 253);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn thuật toán";
            // 
            // btnRunAlgo
            // 
            this.btnRunAlgo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunAlgo.Location = new System.Drawing.Point(22, 184);
            this.btnRunAlgo.Name = "btnRunAlgo";
            this.btnRunAlgo.Size = new System.Drawing.Size(529, 38);
            this.btnRunAlgo.TabIndex = 12;
            this.btnRunAlgo.Text = "Bắt đầu thuật toán";
            this.btnRunAlgo.UseVisualStyleBackColor = true;
            this.btnRunAlgo.Click += new System.EventHandler(this.btnRunAlgo_Click);
            // 
            // btnFCFS
            // 
            this.btnFCFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFCFS.Location = new System.Drawing.Point(22, 29);
            this.btnFCFS.Name = "btnFCFS";
            this.btnFCFS.Size = new System.Drawing.Size(118, 64);
            this.btnFCFS.TabIndex = 7;
            this.btnFCFS.Text = "FCFS ";
            this.btnFCFS.UseVisualStyleBackColor = true;
            this.btnFCFS.Click += new System.EventHandler(this.btnFCFS_Click);
            // 
            // txtDiskSize
            // 
            this.txtDiskSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiskSize.Location = new System.Drawing.Point(22, 141);
            this.txtDiskSize.Name = "txtDiskSize";
            this.txtDiskSize.Size = new System.Drawing.Size(116, 30);
            this.txtDiskSize.TabIndex = 13;
            this.txtDiskSize.Text = "200";
            // 
            // lbDiskSize
            // 
            this.lbDiskSize.AutoSize = true;
            this.lbDiskSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiskSize.ForeColor = System.Drawing.Color.White;
            this.lbDiskSize.Location = new System.Drawing.Point(17, 113);
            this.lbDiskSize.Name = "lbDiskSize";
            this.lbDiskSize.Size = new System.Drawing.Size(133, 20);
            this.lbDiskSize.TabIndex = 14;
            this.lbDiskSize.Text = "Nhập disk size";
            // 
            // btnSSTF
            // 
            this.btnSSTF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSSTF.Location = new System.Drawing.Point(161, 32);
            this.btnSSTF.Name = "btnSSTF";
            this.btnSSTF.Size = new System.Drawing.Size(118, 61);
            this.btnSSTF.TabIndex = 8;
            this.btnSSTF.Text = "SSTF";
            this.btnSSTF.UseVisualStyleBackColor = true;
            this.btnSSTF.Click += new System.EventHandler(this.btnSSTF_Click);
            // 
            // btnCSCAN
            // 
            this.btnCSCAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSCAN.Location = new System.Drawing.Point(301, 32);
            this.btnCSCAN.Name = "btnCSCAN";
            this.btnCSCAN.Size = new System.Drawing.Size(118, 61);
            this.btnCSCAN.TabIndex = 10;
            this.btnCSCAN.Text = "C-SCAN";
            this.btnCSCAN.UseVisualStyleBackColor = true;
            this.btnCSCAN.Click += new System.EventHandler(this.btnCSCAN_Click);
            // 
            // btnSCAN
            // 
            this.btnSCAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSCAN.Location = new System.Drawing.Point(433, 32);
            this.btnSCAN.Name = "btnSCAN";
            this.btnSCAN.Size = new System.Drawing.Size(118, 61);
            this.btnSCAN.TabIndex = 9;
            this.btnSCAN.Text = "SCAN";
            this.btnSCAN.UseVisualStyleBackColor = true;
            this.btnSCAN.Click += new System.EventHandler(this.btnSCAN_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.lbRequests);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.lbHead);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(575, 270);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Khởi tạo input";
            // 
            // lbRequests
            // 
            this.lbRequests.AutoSize = true;
            this.lbRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRequests.ForeColor = System.Drawing.Color.White;
            this.lbRequests.Location = new System.Drawing.Point(12, 50);
            this.lbRequests.Name = "lbRequests";
            this.lbRequests.Size = new System.Drawing.Size(427, 20);
            this.lbRequests.TabIndex = 1;
            this.lbRequests.Text = "Nhập các yêu cầu truy cập đĩa (cách nhau bằng |)";
            // 
            // lbHead
            // 
            this.lbHead.AutoSize = true;
            this.lbHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHead.ForeColor = System.Drawing.Color.White;
            this.lbHead.Location = new System.Drawing.Point(12, 137);
            this.lbHead.Name = "lbHead";
            this.lbHead.Size = new System.Drawing.Size(308, 20);
            this.lbHead.TabIndex = 2;
            this.lbHead.Text = "Nhập giá trị bắt đầu (1 số duy nhất)";
            // 
            // lbInput1
            // 
            this.lbInput1.AutoSize = true;
            this.lbInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInput1.Location = new System.Drawing.Point(665, 65);
            this.lbInput1.Name = "lbInput1";
            this.lbInput1.Size = new System.Drawing.Size(102, 25);
            this.lbInput1.TabIndex = 2;
            this.lbInput1.Text = "Requests";
            this.lbInput1.Visible = false;
            // 
            // lbInput2
            // 
            this.lbInput2.AutoSize = true;
            this.lbInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInput2.Location = new System.Drawing.Point(665, 132);
            this.lbInput2.Name = "lbInput2";
            this.lbInput2.Size = new System.Drawing.Size(63, 25);
            this.lbInput2.TabIndex = 3;
            this.lbInput2.Text = "Head";
            this.lbInput2.Visible = false;
            this.lbInput2.Click += new System.EventHandler(this.lbInput2_Click);
            // 
            // lbProgress
            // 
            this.lbProgress.AutoSize = true;
            this.lbProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProgress.ForeColor = System.Drawing.Color.Lime;
            this.lbProgress.Location = new System.Drawing.Point(663, 211);
            this.lbProgress.Name = "lbProgress";
            this.lbProgress.Size = new System.Drawing.Size(98, 25);
            this.lbProgress.TabIndex = 5;
            this.lbProgress.Text = "Progress";
            this.lbProgress.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(459, 205);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 38);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1577, 687);
            this.Controls.Add(this.lbProgress);
            this.Controls.Add(this.lbInput2);
            this.Controls.Add(this.lbInput1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formD";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRequests;
        private System.Windows.Forms.TextBox txtHead;
        private System.Windows.Forms.Label lnType;
        private System.Windows.Forms.Label lbHead;
        private System.Windows.Forms.Label lbRequests;
        private System.Windows.Forms.Button btnFCFS;
        private System.Windows.Forms.Button btnLoadInput;
        private System.Windows.Forms.Button btnCSCAN;
        private System.Windows.Forms.Button btnSCAN;
        private System.Windows.Forms.Button btnSSTF;
        private System.Windows.Forms.Label lbInput1;
        private System.Windows.Forms.Label lbInput2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRunAlgo;
        private System.Windows.Forms.Label lbProgress;
        private System.Windows.Forms.TextBox txtDiskSize;
        private System.Windows.Forms.Label lbDiskSize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExit;
    }
}