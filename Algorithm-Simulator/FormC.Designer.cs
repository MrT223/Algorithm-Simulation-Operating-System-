namespace Algorithm_Simulator
{
    partial class FormC
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
            this.grBoxInp = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkStepByStep = new System.Windows.Forms.CheckBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClock = new System.Windows.Forms.Button();
            this.btnLRU = new System.Windows.Forms.Button();
            this.btnFIFO = new System.Windows.Forms.Button();
            this.btnOPT = new System.Windows.Forms.Button();
            this.grBoxInp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grBoxInp
            // 
            this.grBoxInp.Controls.Add(this.label2);
            this.grBoxInp.Controls.Add(this.label1);
            this.grBoxInp.Controls.Add(this.btnCreate);
            this.grBoxInp.Controls.Add(this.txtPage);
            this.grBoxInp.Controls.Add(this.txtStep);
            this.grBoxInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxInp.Location = new System.Drawing.Point(26, 33);
            this.grBoxInp.Name = "grBoxInp";
            this.grBoxInp.Size = new System.Drawing.Size(367, 156);
            this.grBoxInp.TabIndex = 0;
            this.grBoxInp.TabStop = false;
            this.grBoxInp.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Page Frame";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Step";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(246, 44);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(91, 37);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtPage
            // 
            this.txtPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPage.Location = new System.Drawing.Point(22, 118);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(218, 22);
            this.txtPage.TabIndex = 1;
            // 
            // txtStep
            // 
            this.txtStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStep.Location = new System.Drawing.Point(22, 59);
            this.txtStep.Name = "txtStep";
            this.txtStep.Size = new System.Drawing.Size(218, 22);
            this.txtStep.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(427, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1088, 663);
            this.dataGridView.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnClock);
            this.groupBox1.Controls.Add(this.btnLRU);
            this.groupBox1.Controls.Add(this.btnFIFO);
            this.groupBox1.Controls.Add(this.btnOPT);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 375);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Algorithm";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.chkStepByStep);
            this.groupBox2.Controls.Add(this.btnRestart);
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Location = new System.Drawing.Point(26, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 132);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Run";
            // 
            // chkStepByStep
            // 
            this.chkStepByStep.AutoSize = true;
            this.chkStepByStep.Location = new System.Drawing.Point(26, 95);
            this.chkStepByStep.Name = "chkStepByStep";
            this.chkStepByStep.Size = new System.Drawing.Size(118, 20);
            this.chkStepByStep.TabIndex = 6;
            this.chkStepByStep.Text = "Step by Step";
            this.chkStepByStep.UseVisualStyleBackColor = true;
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(145, 43);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(103, 46);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(16, 43);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(106, 46);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClock
            // 
            this.btnClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClock.Location = new System.Drawing.Point(195, 127);
            this.btnClock.Name = "btnClock";
            this.btnClock.Size = new System.Drawing.Size(142, 61);
            this.btnClock.TabIndex = 3;
            this.btnClock.Text = "Clock";
            this.btnClock.UseVisualStyleBackColor = true;
            this.btnClock.Click += new System.EventHandler(this.btnClock_Click);
            // 
            // btnLRU
            // 
            this.btnLRU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLRU.Location = new System.Drawing.Point(26, 127);
            this.btnLRU.Name = "btnLRU";
            this.btnLRU.Size = new System.Drawing.Size(142, 61);
            this.btnLRU.TabIndex = 2;
            this.btnLRU.Text = "LRU";
            this.btnLRU.UseVisualStyleBackColor = true;
            this.btnLRU.Click += new System.EventHandler(this.btnLRU_Click);
            // 
            // btnFIFO
            // 
            this.btnFIFO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFIFO.Location = new System.Drawing.Point(195, 34);
            this.btnFIFO.Name = "btnFIFO";
            this.btnFIFO.Size = new System.Drawing.Size(142, 61);
            this.btnFIFO.TabIndex = 1;
            this.btnFIFO.Text = "FIFO";
            this.btnFIFO.UseVisualStyleBackColor = true;
            this.btnFIFO.Click += new System.EventHandler(this.btnFIFO_Click);
            // 
            // btnOPT
            // 
            this.btnOPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOPT.Location = new System.Drawing.Point(26, 34);
            this.btnOPT.Name = "btnOPT";
            this.btnOPT.Size = new System.Drawing.Size(142, 61);
            this.btnOPT.TabIndex = 0;
            this.btnOPT.Text = "OPT";
            this.btnOPT.UseVisualStyleBackColor = true;
            this.btnOPT.Click += new System.EventHandler(this.btnOPT_Click);
            // 
            // FormC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1577, 687);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.grBoxInp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PFSR_Form";
            this.grBoxInp.ResumeLayout(false);
            this.grBoxInp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grBoxInp;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.TextBox txtStep;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClock;
        private System.Windows.Forms.Button btnLRU;
        private System.Windows.Forms.Button btnFIFO;
        private System.Windows.Forms.Button btnOPT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox chkStepByStep;
        private System.Windows.Forms.Button btnRestart;
    }
}