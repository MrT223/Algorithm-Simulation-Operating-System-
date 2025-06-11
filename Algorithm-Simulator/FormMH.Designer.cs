namespace Algorithm_Simulator
{
    partial class FormBanker
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblProcInput = new System.Windows.Forms.Label();
            this.lblResInput = new System.Windows.Forms.Label();
            this.txtNProc = new System.Windows.Forms.TextBox();
            this.txtNRes = new System.Windows.Forms.TextBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblAlloc = new System.Windows.Forms.Label();
            this.richAlloc = new System.Windows.Forms.RichTextBox();
            this.btnAlloc = new System.Windows.Forms.Button();
            this.txtAlloc = new System.Windows.Forms.TextBox();
            this.lblMax = new System.Windows.Forms.Label();
            this.richMax = new System.Windows.Forms.RichTextBox();
            this.lblAvail = new System.Windows.Forms.Label();
            this.txtAvail = new System.Windows.Forms.TextBox();
            this.lblNeed = new System.Windows.Forms.Label();
            this.richNeed = new System.Windows.Forms.RichTextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.richOutput = new System.Windows.Forms.RichTextBox();
            this.radiobtnSafe = new System.Windows.Forms.RadioButton();
            this.radiobtnRequest = new System.Windows.Forms.RadioButton();
            this.lblProcReq = new System.Windows.Forms.Label();
            this.lblResReq = new System.Windows.Forms.Label();
            this.txtProcReq = new System.Windows.Forms.TextBox();
            this.txtResReq = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(668, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(258, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Banker\'s Algorithm";
            // 
            // lblProcInput
            // 
            this.lblProcInput.AutoSize = true;
            this.lblProcInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcInput.Location = new System.Drawing.Point(12, 77);
            this.lblProcInput.Name = "lblProcInput";
            this.lblProcInput.Size = new System.Drawing.Size(186, 20);
            this.lblProcInput.TabIndex = 1;
            this.lblProcInput.Text = "Nhập số lượng quá trình";
            // 
            // lblResInput
            // 
            this.lblResInput.AutoSize = true;
            this.lblResInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResInput.Location = new System.Drawing.Point(12, 149);
            this.lblResInput.Name = "lblResInput";
            this.lblResInput.Size = new System.Drawing.Size(197, 20);
            this.lblResInput.TabIndex = 1;
            this.lblResInput.Text = "Nhập số lượng tài nguyên";
            // 
            // txtNProc
            // 
            this.txtNProc.Location = new System.Drawing.Point(263, 77);
            this.txtNProc.Name = "txtNProc";
            this.txtNProc.Size = new System.Drawing.Size(120, 22);
            this.txtNProc.TabIndex = 2;
            this.txtNProc.TextChanged += new System.EventHandler(this.txtNProc_TextChanged);
            // 
            // txtNRes
            // 
            this.txtNRes.Location = new System.Drawing.Point(263, 147);
            this.txtNRes.Name = "txtNRes";
            this.txtNRes.Size = new System.Drawing.Size(120, 22);
            this.txtNRes.TabIndex = 2;
            this.txtNRes.TextChanged += new System.EventHandler(this.txtNRes_TextChanged);
            // 
            // btnContinue
            // 
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(412, 109);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(133, 33);
            this.btnContinue.TabIndex = 3;
            this.btnContinue.Text = "Tiếp tục";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblAlloc
            // 
            this.lblAlloc.AutoSize = true;
            this.lblAlloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlloc.Location = new System.Drawing.Point(31, 228);
            this.lblAlloc.Name = "lblAlloc";
            this.lblAlloc.Size = new System.Drawing.Size(139, 20);
            this.lblAlloc.TabIndex = 1;
            this.lblAlloc.Text = "Ma trận cung cấp";
            // 
            // richAlloc
            // 
            this.richAlloc.Location = new System.Drawing.Point(229, 228);
            this.richAlloc.Name = "richAlloc";
            this.richAlloc.Size = new System.Drawing.Size(279, 182);
            this.richAlloc.TabIndex = 4;
            this.richAlloc.Text = "";
            // 
            // btnAlloc
            // 
            this.btnAlloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlloc.Location = new System.Drawing.Point(35, 338);
            this.btnAlloc.Name = "btnAlloc";
            this.btnAlloc.Size = new System.Drawing.Size(109, 31);
            this.btnAlloc.TabIndex = 5;
            this.btnAlloc.Text = "Thêm hàng";
            this.btnAlloc.UseVisualStyleBackColor = true;
            this.btnAlloc.Click += new System.EventHandler(this.btnAlloc_Click);
            // 
            // txtAlloc
            // 
            this.txtAlloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlloc.Location = new System.Drawing.Point(16, 275);
            this.txtAlloc.Name = "txtAlloc";
            this.txtAlloc.Size = new System.Drawing.Size(154, 26);
            this.txtAlloc.TabIndex = 2;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.Location = new System.Drawing.Point(553, 228);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(135, 20);
            this.lblMax.TabIndex = 1;
            this.lblMax.Text = "Ma trận cần thiết";
            // 
            // richMax
            // 
            this.richMax.Location = new System.Drawing.Point(740, 228);
            this.richMax.Name = "richMax";
            this.richMax.Size = new System.Drawing.Size(279, 182);
            this.richMax.TabIndex = 4;
            this.richMax.Text = "";
            // 
            // lblAvail
            // 
            this.lblAvail.AutoSize = true;
            this.lblAvail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvail.Location = new System.Drawing.Point(1059, 228);
            this.lblAvail.Name = "lblAvail";
            this.lblAvail.Size = new System.Drawing.Size(138, 20);
            this.lblAvail.TabIndex = 1;
            this.lblAvail.Text = "Ma trận khả dụng";
            // 
            // txtAvail
            // 
            this.txtAvail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvail.Location = new System.Drawing.Point(1224, 225);
            this.txtAvail.Name = "txtAvail";
            this.txtAvail.Size = new System.Drawing.Size(181, 26);
            this.txtAvail.TabIndex = 2;
            // 
            // lblNeed
            // 
            this.lblNeed.AutoSize = true;
            this.lblNeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeed.Location = new System.Drawing.Point(31, 439);
            this.lblNeed.Name = "lblNeed";
            this.lblNeed.Size = new System.Drawing.Size(130, 20);
            this.lblNeed.TabIndex = 1;
            this.lblNeed.Text = "Ma trận còn cần";
            // 
            // richNeed
            // 
            this.richNeed.Location = new System.Drawing.Point(16, 476);
            this.richNeed.Name = "richNeed";
            this.richNeed.Size = new System.Drawing.Size(455, 199);
            this.richNeed.TabIndex = 4;
            this.richNeed.Text = "";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(572, 439);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(66, 20);
            this.lblOutput.TabIndex = 1;
            this.lblOutput.Text = "Kết quả";
            // 
            // richOutput
            // 
            this.richOutput.Location = new System.Drawing.Point(557, 476);
            this.richOutput.Name = "richOutput";
            this.richOutput.Size = new System.Drawing.Size(331, 199);
            this.richOutput.TabIndex = 4;
            this.richOutput.Text = "";
            // 
            // radiobtnSafe
            // 
            this.radiobtnSafe.AutoSize = true;
            this.radiobtnSafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnSafe.Location = new System.Drawing.Point(1063, 435);
            this.radiobtnSafe.Name = "radiobtnSafe";
            this.radiobtnSafe.Size = new System.Drawing.Size(165, 24);
            this.radiobtnSafe.TabIndex = 6;
            this.radiobtnSafe.TabStop = true;
            this.radiobtnSafe.Text = "Trạng thái an toàn";
            this.radiobtnSafe.UseVisualStyleBackColor = true;
            this.radiobtnSafe.CheckedChanged += new System.EventHandler(this.radiobtnSafe_CheckedChanged);
            // 
            // radiobtnRequest
            // 
            this.radiobtnRequest.AutoSize = true;
            this.radiobtnRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnRequest.Location = new System.Drawing.Point(1304, 435);
            this.radiobtnRequest.Name = "radiobtnRequest";
            this.radiobtnRequest.Size = new System.Drawing.Size(90, 24);
            this.radiobtnRequest.TabIndex = 6;
            this.radiobtnRequest.TabStop = true;
            this.radiobtnRequest.Text = "Yêu cầu";
            this.radiobtnRequest.UseVisualStyleBackColor = true;
            this.radiobtnRequest.CheckedChanged += new System.EventHandler(this.radiobtnRequest_CheckedChanged);
            // 
            // lblProcReq
            // 
            this.lblProcReq.AutoSize = true;
            this.lblProcReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcReq.Location = new System.Drawing.Point(1059, 492);
            this.lblProcReq.Name = "lblProcReq";
            this.lblProcReq.Size = new System.Drawing.Size(141, 20);
            this.lblProcReq.TabIndex = 1;
            this.lblProcReq.Text = "Quá trình yêu cầu";
            // 
            // lblResReq
            // 
            this.lblResReq.AutoSize = true;
            this.lblResReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResReq.Location = new System.Drawing.Point(1059, 558);
            this.lblResReq.Name = "lblResReq";
            this.lblResReq.Size = new System.Drawing.Size(153, 20);
            this.lblResReq.TabIndex = 1;
            this.lblResReq.Text = "Tài nguyên yêu cầu";
            // 
            // txtProcReq
            // 
            this.txtProcReq.Location = new System.Drawing.Point(1304, 490);
            this.txtProcReq.Name = "txtProcReq";
            this.txtProcReq.Size = new System.Drawing.Size(181, 22);
            this.txtProcReq.TabIndex = 2;
            // 
            // txtResReq
            // 
            this.txtResReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResReq.Location = new System.Drawing.Point(1304, 552);
            this.txtResReq.Name = "txtResReq";
            this.txtResReq.Size = new System.Drawing.Size(181, 26);
            this.txtResReq.TabIndex = 2;
            // 
            // txtMax
            // 
            this.txtMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMax.Location = new System.Drawing.Point(534, 275);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(154, 26);
            this.txtMax.TabIndex = 2;
            // 
            // btnMax
            // 
            this.btnMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.Location = new System.Drawing.Point(557, 338);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(109, 31);
            this.btnMax.TabIndex = 5;
            this.btnMax.Text = "Thêm hàng";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(1063, 614);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(134, 49);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "Kiểm tra";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1304, 614);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 49);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Làm mới";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FormBanker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1577, 687);
            this.Controls.Add(this.radiobtnRequest);
            this.Controls.Add(this.radiobtnSafe);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnAlloc);
            this.Controls.Add(this.richMax);
            this.Controls.Add(this.richOutput);
            this.Controls.Add(this.richNeed);
            this.Controls.Add(this.richAlloc);
            this.Controls.Add(this.txtResReq);
            this.Controls.Add(this.txtAvail);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtAlloc);
            this.Controls.Add(this.lblAvail);
            this.Controls.Add(this.txtNRes);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtProcReq);
            this.Controls.Add(this.txtNProc);
            this.Controls.Add(this.lblResReq);
            this.Controls.Add(this.lblProcReq);
            this.Controls.Add(this.lblNeed);
            this.Controls.Add(this.lblAlloc);
            this.Controls.Add(this.lblResInput);
            this.Controls.Add(this.lblProcInput);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormBanker";
            this.Text = "FormBanker";
            this.Load += new System.EventHandler(this.FormBanker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProcInput;
        private System.Windows.Forms.Label lblResInput;
        private System.Windows.Forms.TextBox txtNProc;
        private System.Windows.Forms.TextBox txtNRes;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblAlloc;
        private System.Windows.Forms.RichTextBox richAlloc;
        private System.Windows.Forms.Button btnAlloc;
        private System.Windows.Forms.TextBox txtAlloc;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.RichTextBox richMax;
        private System.Windows.Forms.Label lblAvail;
        private System.Windows.Forms.TextBox txtAvail;
        private System.Windows.Forms.Label lblNeed;
        private System.Windows.Forms.RichTextBox richNeed;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.RichTextBox richOutput;
        private System.Windows.Forms.RadioButton radiobtnSafe;
        private System.Windows.Forms.RadioButton radiobtnRequest;
        private System.Windows.Forms.Label lblProcReq;
        private System.Windows.Forms.Label lblResReq;
        private System.Windows.Forms.TextBox txtProcReq;
        private System.Windows.Forms.TextBox txtResReq;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnClear;
    }
}